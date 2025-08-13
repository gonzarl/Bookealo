﻿using CleanBookings.Application.Exceptions;
using CleanBookings.Domain.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanBookings.Infrastructure;

public sealed class ApplicationDbContext : DbContext, IUnitOfWork
{
    private IPublisher _publisher;
    public ApplicationDbContext(DbContextOptions options, IPublisher publisher)
        : base(options)
    {
        _publisher = publisher;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            var result = await base.SaveChangesAsync(cancellationToken);
            await PublishDomainEventsAsync();
            return result;
        }
        catch (DbUpdateConcurrencyException ex)
        {
            throw new ConcurrencyException("Concurrency exception occured.", ex);
        }
    }

    private async Task PublishDomainEventsAsync()
    {
        var domainEvents = ChangeTracker    
            .Entries<Entity>()
            .Select(entry => entry.Entity)
            .SelectMany(entity =>
            { 
                var domainEvents = entity.GetDomainEvents();
                entity.ClearDomainEvents();
                return domainEvents;
            })
            .ToList();

        foreach (var domainEvent in domainEvents) 
        {
            await _publisher.Publish(domainEvent);
        }
    }
}

using CleanBookings.Domain.Abstractions;

namespace CleanBookings.Domain.Reviews.Events;
public sealed record ReviewCreatedDomainEvent(Guid ReviewId) : IDomainEvent;
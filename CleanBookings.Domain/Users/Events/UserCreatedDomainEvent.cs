using CleanBookings.Domain.Abstractions;

namespace CleanBookings.Domain.Users.Events;
public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;

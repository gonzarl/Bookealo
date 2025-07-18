using CleanBookings.Domain.Abstractions;

namespace CleanBookings.Domain.Bookings.Events;

public sealed record BookingCompletedDomainEvent(Guid BookingId) : IDomainEvent;

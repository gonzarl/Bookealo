using CleanBookings.Domain.Abstractions;

namespace CleanBookings.Domain.Bookings.Events;

public sealed record BookingRejectedDomainEvent(Guid BookingId) : IDomainEvent;

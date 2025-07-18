using CleanBookings.Domain.Abstractions;

namespace CleanBookings.Domain.Bookings.Events;

public sealed record BookingCancelledDomainEvent(Guid BookingId) : IDomainEvent;

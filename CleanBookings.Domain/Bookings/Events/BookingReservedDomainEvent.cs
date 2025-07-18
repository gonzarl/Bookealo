using CleanBookings.Domain.Abstractions;

namespace CleanBookings.Domain.Bookings.Events;

public sealed record BookingReservedDomainEvent(Guid BookingId) : IDomainEvent;

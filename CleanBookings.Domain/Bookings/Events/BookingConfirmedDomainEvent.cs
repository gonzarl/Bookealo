using CleanBookings.Domain.Abstractions;

namespace CleanBookings.Domain.Bookings.Events;

public sealed record BookingConfirmedDomainEvent(Guid BookingId) : IDomainEvent;

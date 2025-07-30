using CleanBookings.Application.Abstractions.Messaging;

namespace CleanBookings.Application.Bookings.GetBooking;

public sealed record GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>;

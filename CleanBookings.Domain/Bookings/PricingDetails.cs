using CleanBookings.Domain.Shared;

namespace CleanBookings.Domain.Bookings;

public record PricingDetails(
    Money PriceForPeriod,
    Money CleaningFee,
    Money AmenitiesUpcharge,
    Money TotalPrice);
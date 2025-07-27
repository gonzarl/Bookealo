using CleanBookings.Domain.Abstractions;

namespace CleanBookings.Domain.Apartments;

public static class ApartmentErrors
{
    public static Error NotFound = new(
        "Apartment.Found",
        "The apartment with the specified identifier was not found");
}

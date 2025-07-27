using CleanBookings.Domain.Abstractions;

namespace CleanBookings.Domain.Users;

public static class UserErrors
{
    public static Error NotFound = new(
        "User.Found",
        "The user with the specified identifier was not found");
}

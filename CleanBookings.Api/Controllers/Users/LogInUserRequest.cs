namespace CleanBookings.Api.Controllers.Users;

public sealed record LogInUserRequest(
    string Email,
    string Password);

using CleanBookings.Application.Abstractions.Messaging;

namespace CleanBookings.Application.Users.LogInUser;

public sealed record LogInUserCommand(string Email, string Password)
    : ICommand<AccessTokenResponse>;

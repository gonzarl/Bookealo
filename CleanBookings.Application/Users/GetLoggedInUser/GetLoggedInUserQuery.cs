using CleanBookings.Application.Abstractions.Messaging;

namespace CleanBookings.Application.Users.GetLoggedInUser;

public sealed record GetLoggedInUserQuery : IQuery<UserResponse>;

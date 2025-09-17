using CleanBookings.Domain.Users;

namespace CleanBookings.Application.Abstractions.Authentication;

public interface IAuthenticationService
{
    Task<string> RegisterAsync(
        User user,
        string password,
        CancellationToken cancellation = default);
}

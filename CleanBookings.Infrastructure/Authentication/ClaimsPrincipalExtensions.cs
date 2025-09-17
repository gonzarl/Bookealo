using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CleanBookings.Infrastructure.Authentication;

internal static class ClaimsPrincipalExtensions
{
    public static Guid GetUserId(this ClaimsPrincipal? principal)
    {
        var userId = principal?.FindFirstValue(JwtRegisteredClaimNames.Sub);
        return  Guid.TryParse(userId, out Guid parsedUserId) ?
            parsedUserId :
               throw new ApplicationException("User idetifier is unavailable");
    }

    public static string GetIdentityId(this ClaimsPrincipal? principal)
    {
        return principal?.FindFirstValue(ClaimTypes.NameIdentifier) ??
               throw new ApplicationException("User identity is unavailable");
    }
}


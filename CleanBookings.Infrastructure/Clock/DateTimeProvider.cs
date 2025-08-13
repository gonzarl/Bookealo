using CleanBookings.Application.Abstractions.Clock;

namespace CleanBookings.Infrastructure.Clock;

internal sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}

namespace CleanBookings.Domain.Shared;

public record Currency
{
    internal static readonly Currency None = new Currency("");
    public static readonly Currency Usd = new Currency("USD");
    public static readonly Currency Ars = new Currency("ARS");
    private Currency(string code) => Code = code;
    
    public string Code { get; init; }

    public static Currency FromCode(string code) 
    {
        return All.FirstOrDefault(c => c.Code == code) ??
            throw new ApplicationException("Invalid currency code");
    }

    public static readonly IReadOnlyCollection<Currency> All = new[]
    {
        Usd,
        Ars
    };
}


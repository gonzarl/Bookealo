using CleanBookings.Domain.Apartments;

namespace CleanBookings.Infrastructure.Repositories;

internal sealed class ApartmentRepository : Repository<Apartment>, IApartmentRepository
{
    public ApartmentRepository(ApplicationDbContext dbContext) 
        : base(dbContext)
    {
    }
}

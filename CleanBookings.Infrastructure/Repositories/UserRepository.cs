using CleanBookings.Domain.Users;

namespace CleanBookings.Infrastructure.Repositories;

internal sealed class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext dbContext) 
        : base(dbContext)
    {
    }
}

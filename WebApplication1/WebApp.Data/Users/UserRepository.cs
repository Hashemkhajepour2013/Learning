using WebApp.Data.Users.Contracts;
using WebApp.Entities.Users;

namespace WebApp.Data.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Register(User user, CancellationToken cancellationToken)
        {
            await _context.AddAsync(user, cancellationToken);           
        }
    }
}

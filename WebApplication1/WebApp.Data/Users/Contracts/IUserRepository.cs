using WebApp.Entities.Users;

namespace WebApp.Data.Users.Contracts
{
    public interface IUserRepository
    {
        Task Register(User user, CancellationToken cancellationToken);
    }
}

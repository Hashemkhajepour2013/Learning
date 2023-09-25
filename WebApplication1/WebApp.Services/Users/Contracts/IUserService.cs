using WebApp.Services.Users.Contracts.Dtos;

namespace WebApp.Services.Users.Contracts
{
    public interface IUserService
    {
        Task<string> Register(RegisterUserDto dto, CancellationToken cancellationToken);
    }
}

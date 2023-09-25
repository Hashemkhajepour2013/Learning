using WebApp.Common.Utilities;
using WebApp.Data.UnitOfWork.Contracts;
using WebApp.Data.Users.Contracts;
using WebApp.Entities.Users;
using WebApp.Services.Users.Contracts;
using WebApp.Services.Users.Contracts.Dtos;

namespace WebApp.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _repository;

        public UserService(
            IUnitOfWork unitOfWork,
            IUserRepository repository)  
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<string> Register(RegisterUserDto dto, CancellationToken cancellationToken)
        {
            var user = new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                UserName = dto.UserName,
                Password = dto.Password
            };

            await _repository.Register(user, cancellationToken);

            await _unitOfWork.Complete();

            AES aES = new AES();

            aES.Encrypt(dto.Password);

            return user.Id.ToString();
        }
    }
}

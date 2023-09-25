using Microsoft.AspNetCore.Mvc;
using WebApp.Services.Users.Contracts;
using WebApp.Services.Users.Contracts.Dtos;

namespace WebApplication1.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<string> Register(RegisterUserDto dto, CancellationToken cancellationToken)
        {
            return await _service.Register(dto, cancellationToken);
        }
    }
}

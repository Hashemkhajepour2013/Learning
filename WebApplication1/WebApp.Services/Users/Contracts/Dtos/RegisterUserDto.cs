using System.ComponentModel.DataAnnotations;

namespace WebApp.Services.Users.Contracts.Dtos
{
    public class RegisterUserDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string Password { get; set; } = null!;
    }
}

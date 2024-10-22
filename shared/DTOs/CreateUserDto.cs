using System.ComponentModel.DataAnnotations;

namespace shared.DTOs
{
    public class CreateUserDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Username { get; set; } = string.Empty;
    }
}

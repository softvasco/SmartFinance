using api.Models;
using shared.DTOs.Users;

namespace api.Mappers
{
    public static class UserMappers
    {
        public static User ToUserFromCreateUserDto(this CreateUserDto createUserDto)
        {
            return new User
            {
                Name = createUserDto.Name,
                Email = createUserDto.Email,
                Username = createUserDto.Username,
                IsActive = true,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
        }
    }
}

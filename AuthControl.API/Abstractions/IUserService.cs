using AuthControl.API.DTO;
using AuthControl.API.Entitites;
using Microsoft.AspNetCore.Mvc;

namespace AuthControl.API.Abstractions
{
    public interface IUserService
    {
        Task<IActionResult> CreateUserAsync(CreateUserDTO user);
        Task<UserEntity> DeleteUserAsync(string username);
        Task<UserEntity> UpdateUserAsync(UserEntity user);
        Task<UserEntity> GetUserByIdAsync(int id);
        Task<UserEntity> GetUserByEmailAsync(string email);
        Task<UserEntity> GetAllUsers();
        Task<UserEntity> Login(LoginDTO login);
    }
}

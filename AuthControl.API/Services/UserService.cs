using AuthControl.API.Abstractions;
using AuthControl.API.DTO;
using AuthControl.API.Entitites;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AuthControl.API.Services
{
    public class UserService : IUserService
    {

        public Task<UserEntity> UpdateUserAsync(UserEntity user)
        {
            throw new NotImplementedException();
        }

        Task<IActionResult> IUserService.CreateUserAsync(CreateUserDTO user)
        {
            return Task.FromResult<IActionResult>(new OkResult());
        }

        Task<UserEntity> IUserService.DeleteUserAsync(string username)
        {
            throw new NotImplementedException();
        }

        Task<UserEntity> IUserService.GetAllUsers()
        {
            throw new NotImplementedException();
        }

        Task<UserEntity> IUserService.GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        Task<UserEntity> IUserService.GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<UserEntity> IUserService.Login(LoginDTO login)
        {
            throw new NotImplementedException();
        }
    }
}

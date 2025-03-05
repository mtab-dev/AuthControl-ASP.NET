using AuthControl.API.Entitites;
using System.Runtime.InteropServices;

namespace AuthControl.API.Abstractions
{
    public interface IUserRepository
    {
        Task<UserEntity> CreateUser(UserEntity user);
        Task<UserEntity> DeleteUserAsync(string username);
        Task<UserEntity> UpdateUserAsync(UserEntity user);
        Task<UserEntity> GetUserByIdAsync(int id);
        Task<UserEntity> GetUserByEmailAsync(string email);
        Task<List<UserEntity>> GetAllUsers();
        Task<UserEntity> Login(string username, string password);
    }
}

using AuthControl.API.DTO;
using AuthControl.API.Entitites;

namespace AuthControl.API.Abstractions
{
    public interface IUserService
    {
        Task<UserEntity> CreateUserAsync(CreateUserDTO user);
        Task<UserEntity> DeleteUserAsync(string username);
        Task<UserEntity> UpdateUserAsync(UserEntity user);
        Task<UserEntity> GetUserByIdAsync(int id);
        Task<UserEntity> GetUserByEmailAsync(string email);
        Task<List<UserEntity>> GetAllUsers();
        Task<LoginResponseDTO> Login(LoginDTO login);
    }
}

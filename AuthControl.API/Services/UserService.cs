using AuthControl.API.Abstractions;
using AuthControl.API.DTO;
using AuthControl.API.Entitites;
using AuthControl.API.Utils;
using Microsoft.AspNet.Identity;

namespace AuthControl.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IPasswordHasher _passwordHasher;

        public UserService(IUserRepository repository, IPasswordHasher passwordHasher)
        {
            _repository = repository;
            _passwordHasher = passwordHasher;
        }

        public async Task<UserEntity> CreateUserAsync(CreateUserDTO user)
        {
            string username = GenerateUsername.Run(user.Name);
            string hashedPassword = _passwordHasher.HashPassword(user.Password);

            var newUser = new UserEntity
            {
                Id = Guid.NewGuid(),
                UserName = username,
                Name = user.Name,
                Email = user.Email,
                Password = hashedPassword,
                BirthDate = DateTime.Parse(user.BirthDate),
                Role = "Client"
            };

            return await _repository.CreateUser(newUser);
        }

        public Task<UserEntity> DeleteUserAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> Login(LoginDTO login)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> UpdateUserAsync(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}

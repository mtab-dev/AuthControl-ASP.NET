using AuthControl.API.Abstractions;
using AuthControl.API.DTO.Request;
using AuthControl.API.DTO.Response;
using AuthControl.API.Entitites;
using AuthControl.API.Entitites.Enums;
using AuthControl.API.Utils;
using Microsoft.AspNet.Identity;

namespace AuthControl.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IJwtHelper _jwtHelper;

        public UserService(IUserRepository repository, IJwtHelper jwtHelper)
        {
            _repository = repository;
            _jwtHelper = jwtHelper;
        }

        public async Task<UserEntity> CreateUserAsync(CreateUserDTO user)
        {
            string username = GenerateUsername.Run(user.Name);
            var password = PasswordService.CreateHash(user.Password);   

            var newUser = new UserEntity
            {
                Id = Guid.NewGuid(),
                UserName = username,
                Name = user.Name,
                Email = user.Email,
                PasswordHash = password.Hash,
                PasswordSalt = password.Salt,
                BirthDate = DateTime.Parse(user.BirthDate),
                Role = UserRole.Client
            };

            return await _repository.CreateUser(newUser);
        }

        public async Task<LoginResponseDTO> Login(LoginDTO login)
        {
            var user = await _repository.Login(login.Username, login.Password);
            var token = _jwtHelper.GenerateToken(user);
            return new LoginResponseDTO
            {
                Message = "Login successful",
                Token = token,
                StatusCode = 200
            };
        }


        public Task<UserEntity> DeleteUserAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserEntity>> GetAllUsers()
        {
            return _repository.GetAllUsers();
        }

        public Task<UserEntity> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }


        public Task<UserEntity> UpdateUserAsync(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}

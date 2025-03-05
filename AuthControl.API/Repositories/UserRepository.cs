using AuthControl.API.Abstractions;
using AuthControl.API.Data;
using AuthControl.API.DTO;
using AuthControl.API.Entitites;
using AuthControl.API.Utils;
using Microsoft.EntityFrameworkCore;

namespace AuthControl.API.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<UserEntity> CreateUser(UserEntity user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public Task<UserEntity> DeleteUserAsync(string username)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserEntity>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public Task<UserEntity> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserEntity> Login(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);

            var isValidPassword = PasswordService.VerifyPassword(password, new PasswordServiceDTO
            {
                Hash = user.PasswordHash,
                Salt = user.PasswordSalt
            });

            user.PasswordHash = string.Empty;
            user.PasswordSalt = string.Empty;

            return user;
        }

        public Task<UserEntity> UpdateUserAsync(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}

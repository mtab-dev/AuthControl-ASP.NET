using AuthControl.API.Abstractions;
using AuthControl.API.Data;
using AuthControl.API.Entitites;

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

        public Task<UserEntity> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> UpdateUserAsync(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}

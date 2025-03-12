using AuthControl.API.Entitites.Enums;

namespace AuthControl.API.Entitites
{
    public class UserEntity
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string PasswordSalt { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public UserRole Role { get; set; } = UserRole.Client;
    }
}

using AuthControl.API.Entitites.Enums;

namespace AuthControl.API.Entitites
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime BirthDate { get; set; }
        public UserRole Role { get; set; }
    }
}

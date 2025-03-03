using AuthControl.API.Entitites;

namespace AuthControl.API.Abstractions
{
    public interface IJwtHelper
    {
        string GenerateToken(UserEntity user);
    }
}

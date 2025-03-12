using System.ComponentModel.DataAnnotations;

namespace AuthControl.API.DTO.Request
{
    public record CreateUserDTO
    {
        [Required]
        public string Name { get; init; }
        [Required]
        [EmailAddress]
        public string Email { get; init; }
        [Required]
        public string Password { get; init; }
        [Required]
        public string BirthDate { get; init; }

    }
}

namespace AuthControl.API.DTO.Application
{
    public record PasswordServiceDTO
    {
        public string Hash { get; set; }
        public string Salt { get; set; }
    }
}

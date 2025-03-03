namespace AuthControl.API.DTO
{
    public record PasswordServiceDTO
    {
        public string Hash { get; set; }
        public string Salt { get; set; }
    }
}

namespace AuthControl.API.DTO.Request
{
    public record LoginDTO
    {
        public string Username { get; init; }
        public string Password { get; init; }
    }
}

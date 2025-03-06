namespace AuthControl.API.DTO.Response
{
    public record LoginResponseDTO
    {
        public string Message { get; set; }
        public string Token { get; set; }
        public int StatusCode { get; set; }
    }
}

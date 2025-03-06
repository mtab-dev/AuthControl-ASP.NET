namespace AuthControl.API.DTO.Response
{
    public record StandardResponse
    {
        public string Message { get; set; }
        public int StatusCode {  get; set; }
    }
}

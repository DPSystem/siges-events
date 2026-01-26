namespace PruebaMudBlazor2.Client.DTOs
{
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ClientId { get; set; }
        public string Audience { get; set; }
    }
}
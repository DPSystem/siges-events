namespace PruebaMudBlazor2.Client.DTOs
{
    public class LoginResponse
    {
        public bool IsAuthSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string Token { get; set; }
    }
}
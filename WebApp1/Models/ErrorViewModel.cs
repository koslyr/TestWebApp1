namespace WebApp1.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public int ErrorId { get; set; }

        public string ErrorDescription { get; set; }
    }
}

namespace WebApplication1.Model
{
    public class UpdateContactRequest
    {
        public string? Name { get; set; }
        public string?Email { get; set; }
        public long PhoneNumber { get; set; }
        public string? Address { get; set; }
    }
}


namespace MedAdvisor.Models
{ 
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public byte[]? HashPassword { get; set; }
        public byte[]? Salt { get; set; }
    }
}


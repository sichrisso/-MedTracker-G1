namespace MedAdvisor.Models
{
    public class UserDto
    {
        public UserDto(string id, string password)
        {
            this.Email = id;
            this.Password = password;
        }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
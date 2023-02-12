namespace MedAdvisor.Api;

public class UserDto
{
    public UserDto(string id, string password)
    {
        this.Username = id;
        this.Password = password;
    }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

}
using Auth.Entities;

namespace Auth.Models;

public class AuthenticateResponse
{
    public AuthenticateResponse(User user, string accessToken)
    {
        AccessToken = accessToken;

        User = new User
        {
            Id = user.Id,
            Firstname = user.Firstname,
            Lastname = user.Lastname,
            Email = user.Email,
            Age = user.Age,
        };
    }
    public string AccessToken { get; set; }
    public User User { get; set; }
}

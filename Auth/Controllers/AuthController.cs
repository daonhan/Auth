using Auth.Models;
using Auth.Services;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers;

[ApiController]
[Route("/login")]
public class AuthController : Controller
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost]
    public IActionResult Post(AuthenticateRequest model)
    {
        var response = _authService.Authenticate(model);

        if (response == null)
            return BadRequest(new { message = "Username or password is incorrect" });

        return Ok(response);
    }
}

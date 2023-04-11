using Auth.Helper;
using Auth.Models;
using Auth.Services;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]    
    public class ItemsController : Controller
    {
        private readonly IAuthService _authService;

        public ItemsController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Item> items = new List<Item>
            {
              new Item{
                Id= "1",
                Name= "Just Chocolate",
                Icon= "just-chocolate",
                Price= 10,
                Description= "For the pure chocoholi"
              },
              new Item{
                Id= "2",
                Name= "Glazed Fudge",
                Icon= "glazed-fudge",
                Price= 20,
                Description= "Sticky perfection.",
              },
              new Item{
                Id= "3",
                Name= "Caramel Swirl",
                Icon= "caramel-swirl",
                Price= 28,
                Description= "Chocolate drizzled with caramel.",
              },
            };

            return Ok(items);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace T07.BoardGame.API.Controllers
{
    [Route("api/BoardGameAPI")]
    [ApiController]
    public class BoardGameAPIController : Controller
    {
        [HttpPost("register")]
        public IActionResult Index()
        {
            return View();
        }
        

    }
}

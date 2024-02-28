using Microsoft.AspNetCore.Mvc;

namespace Twiblog.Controllers
{
    public class PostController : Controller
    {
        public IActionResult CreatePost()
        {
            return View();
        }
    }
}

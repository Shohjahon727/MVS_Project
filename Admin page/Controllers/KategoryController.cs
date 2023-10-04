using Microsoft.AspNetCore.Mvc;

namespace Admin_page.Controllers
{
    public class KategoryController : Controller
    {
        private readonly ILogger<KategoryController> _logger;

        public KategoryController(ILogger<KategoryController> logger)
        {
            _logger = logger;
        }

        public IActionResult Category()
        {
            return View();
        }
        public IActionResult Genres()
        {
            return View();
        }

    }
}

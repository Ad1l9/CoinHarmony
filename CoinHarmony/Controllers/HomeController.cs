using Microsoft.AspNetCore.Mvc;

namespace CoinHarmony.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(bool theme = false)
        {
            return View(theme);
        }
    }
}

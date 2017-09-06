using Microsoft.AspNetCore.Mvc;

namespace Fiver.Asp.SignalR.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}

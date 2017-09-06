using Microsoft.AspNetCore.Mvc;

namespace Fiver.Asp.SignalR.Controllers
{
    public class PublisherController : Controller
    {
        public IActionResult Index() => View();
    }
}

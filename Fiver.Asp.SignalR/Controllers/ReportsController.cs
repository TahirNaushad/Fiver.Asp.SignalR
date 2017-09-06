using Microsoft.AspNetCore.Mvc;

namespace Fiver.Asp.SignalR.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Index() => View();
    }
}

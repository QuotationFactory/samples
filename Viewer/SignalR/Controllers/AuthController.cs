using Microsoft.AspNetCore.Mvc;

namespace Rhodium24.Viewer.SignalR.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Callback()
        {
            return View();
        }
    }
}
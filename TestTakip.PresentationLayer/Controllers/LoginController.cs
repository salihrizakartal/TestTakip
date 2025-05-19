using Microsoft.AspNetCore.Mvc;
using TestTakip.BusinessLayer.Abstract;

namespace TestTakip.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
     
        public IActionResult Login()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace library.Controller
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

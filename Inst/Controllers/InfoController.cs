using Microsoft.AspNetCore.Mvc;

namespace Inst.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

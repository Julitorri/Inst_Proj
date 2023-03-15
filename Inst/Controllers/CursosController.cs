using Inst.Data;
using Inst.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inst.Controllers
{
    public class CursosController : Controller
    {
        readonly private ApplicationDbContext _db;

        public CursosController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable <InstModels> cursos = _db.Inst;
            return View(cursos);
        }
    }
}

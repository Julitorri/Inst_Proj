using Inst.Data;
using Inst.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace Inst.Controllers
{
    public class AreaDoAlunoController : Controller
    {

        readonly private ApplicationDbContext _db;

        public AreaDoAlunoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
          
            IEnumerable<InstModels> cursos = _db.Inst;
            return View(cursos);
        }

        public IActionResult Registo()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Registo(InstModels obj)
        {
            _db.Inst.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

using Inst.Data;
using Inst.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;


namespace Inst.Controllers
{
    public class DadosCadastraisController : Controller
    {
        readonly private ApplicationDbContext _db;

        public DadosCadastraisController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<InstModels> cursos = _db.Inst;
            return View(cursos);
        }
    }
}

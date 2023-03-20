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
         // IEnumerable<InstModels> cursos = _db.Inst;
            return View();
        }

        public IActionResult Registo()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Registo(InstModels obj3)
        {
            _db.Inst.Add(obj3);
            _db.SaveChanges();
            return RedirectToAction("DadosCadastrais");
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(InstModels obj4)
        {
            var user = _db.Inst.SingleOrDefault(u => u.Email == obj4.Email && u.password == obj4.password);

            if (user != null)
            {
                HttpContext.Session.SetInt32("UserId", user.Id);
                return RedirectToAction("DadosCadastrais");
                // As credenciais são válidas, permita o acesso ao sistema.

                //TempData["MensagemSucesso"] = "Login efetuado com sucesso!";
            }
            else
            {
                // As credenciais não são válidas, exiba uma mensagem de erro.

                TempData["MensagemErro"] = "Credenciais inválidas. Tente novamente.";
                return RedirectToAction("Index");
            }



        }

    }
}

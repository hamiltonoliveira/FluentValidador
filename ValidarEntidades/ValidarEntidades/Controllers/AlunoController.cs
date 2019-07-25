using Microsoft.AspNetCore.Mvc;
using ValidarEntidades.Models;

namespace ValidarEntidades.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
          return View();
        }

        [HttpPost]
        public IActionResult Inserir(Aluno Aluno)
        {

            if (!ModelState.IsValid)
            {
                return View("Index", Aluno);
            }
              return RedirectToAction("Index");
      }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace EstoqueWeb.Presentation.Controllers
{
    public class EstoqueController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Consulta()
        {
            return View();
        }

        public IActionResult Relatorio()
        {
            return View();
        }
    }
}

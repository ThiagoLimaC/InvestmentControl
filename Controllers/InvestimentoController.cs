using Microsoft.AspNetCore.Mvc;

namespace InvestmentControl.Controllers
{
    public class InvestimentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult Adicionar(string nome, string tipo, decimal valor, DateTime data)
        {
            return View();
        }
    }
}

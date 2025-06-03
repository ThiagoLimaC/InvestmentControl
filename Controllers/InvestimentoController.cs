using InvestmentControl.Models;
using InvestmentControl.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public IActionResult Adicionar(InvestimentoViewModel model)
        {
            return View();
        }
    }
}

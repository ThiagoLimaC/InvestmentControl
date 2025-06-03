using InvestmentControl.Models;
using InvestmentControl.Repositories;
using InvestmentControl.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InvestmentControl.Controllers
{
    public class InvestimentoController : Controller
    {
        private readonly IInvestimentoRepository _investimentoRepository;

        public InvestimentoController(IInvestimentoRepository investimentoRepository)
        {
            _investimentoRepository = investimentoRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar(InvestimentoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _investimentoRepository.AddAsync(model);

            return RedirectToAction("Index", "Investimento");
        }
    }
}

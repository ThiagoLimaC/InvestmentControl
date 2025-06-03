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

        public async Task<IActionResult> Index()
        {
            var investimentos = await _investimentoRepository.GetAllAsync();
            return View(investimentos);
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

        [HttpGet]
        public async Task<IActionResult> Editar(int id)
        {
            var investimento = await _investimentoRepository.GetByIdAsync(id);

            return View(investimento);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(InvestimentoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _investimentoRepository.UpdateAsync(model);

            return RedirectToAction("Index", "Investimento");
        }

        [HttpGet]
        public async Task<IActionResult> Deletar(int id)
        {
            await _investimentoRepository.DeleteAsync(id);

            return RedirectToAction("Index", "Investimento");
        }
    }
}

using System.Diagnostics;
using InvestmentControl.Data;
using InvestmentControl.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InvestmentControl.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _investimentoRepository;

        public HomeController(AppDbContext investimentoRepository)
        {
            _investimentoRepository = investimentoRepository;
        }

        public IActionResult Index()
        {
            var dados = _investimentoRepository.Investimentos
                .GroupBy(i => i.Tipo)
                .Select(g => new
                {
                    Tipo = g.Key,
                    TotalInvestido = g.Sum(i => i.Valor)
                })
                .ToList();

            var ultimosCadastros = _investimentoRepository.Investimentos
                .OrderByDescending(i => i.InvestimentoId)
                .Take(5)
                .ToList();

            ViewBag.Ultimos = ultimosCadastros;
            ViewBag.Dados = dados;
            ViewBag.Tipos = dados.Select(d => d.Tipo).ToList();
            ViewBag.Valores = dados.Select(d => d.TotalInvestido).ToList();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}

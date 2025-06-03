using InvestmentControl.Data;
using InvestmentControl.Models;
using InvestmentControl.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace InvestmentControl.Repositories
{
    public class InvestimentoRepository : IInvestimentoRepository
    {
        private readonly AppDbContext _dbContext;

        public InvestimentoRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(InvestimentoViewModel investimento)
        {
            var novoInvestimento = new Investimento()
            {
                Nome = investimento.Nome,
                Tipo = investimento.Tipo,
                Valor = investimento.Valor,
                DataInvestimento = investimento.DataInvestimento
            };

            await _dbContext.Investimentos.AddAsync(novoInvestimento);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            Investimento investimento = await _dbContext.Investimentos.FindAsync(id);
            _dbContext.Investimentos.Remove(investimento);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Investimento>> GetAllAsync()
        {
            return await _dbContext.Investimentos.ToListAsync();
        }

        public async Task<Investimento> GetByIdAsync(int id)
        {
            return await _dbContext.Investimentos.FindAsync(id);
        }

        public async Task UpdateAsync(Investimento investimentoUpdated)
        {
            var investimento = await _dbContext.Investimentos.FindAsync(investimentoUpdated.InvestimentoId);
            investimento.Nome = investimentoUpdated.Nome;
            investimento.Tipo = investimentoUpdated.Tipo;
            investimento.Valor = investimentoUpdated.Valor;
            investimento.DataInvestimento = investimentoUpdated.DataInvestimento;
            _dbContext.Investimentos.Update(investimento);
            await _dbContext.SaveChangesAsync();
        }
    }
}

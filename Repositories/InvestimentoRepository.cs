using InvestmentControl.Data;
using InvestmentControl.Models;
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

        public async Task AddAsync(Investimento investimento)
        {
            await _dbContext.Investimentos.AddAsync(investimento);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            Investimento investimento = _dbContext.Investimentos.FindAsync(id);
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

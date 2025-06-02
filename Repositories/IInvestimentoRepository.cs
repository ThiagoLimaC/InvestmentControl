using InvestmentControl.Models;

namespace InvestmentControl.Repositories
{
    public interface IInvestimentoRepository
    {
        Task<Investimento> GetByIdAsync(int id);
        Task<List<Investimento>> GetAllAsync();
        Task AddAsync(Investimento investimento);
        Task UpdateAsync(Investimento investimento);
        Task DeleteAsync(int id);
    }
}

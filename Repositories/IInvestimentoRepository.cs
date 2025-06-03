using InvestmentControl.Models;
using InvestmentControl.ViewModels;

namespace InvestmentControl.Repositories
{
    public interface IInvestimentoRepository
    {
        Task<Investimento> GetByIdAsync(int id);
        Task<List<Investimento>> GetAllAsync();
        Task AddAsync(InvestimentoViewModel investimento);
        Task UpdateAsync(Investimento investimento);
        Task DeleteAsync(int id);
    }
}

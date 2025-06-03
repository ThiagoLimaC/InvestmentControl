namespace InvestmentControl.ViewModels
{
    public class InvestimentoViewModel
    {
        public int InvestimentoId { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataInvestimento { get; set; }
    }
}

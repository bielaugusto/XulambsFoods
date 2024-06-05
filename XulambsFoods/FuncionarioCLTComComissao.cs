namespace XulambsFoods
{
    public class FuncionarioCLTComComissao : FuncionarioCLT
    {
        public decimal ValorVendas { get; set; }
        public decimal TaxaComissao { get; set; } = 0.1m; // 10%

        public FuncionarioCLTComComissao(int id, string nome, decimal salarioBase, int horasTrabalhadas, decimal valorVendas)
            : base(id, nome, salarioBase, horasTrabalhadas)
        {
            ValorVendas = valorVendas;
        }

        public override decimal CalcularSalario()
        {
            return base.CalcularSalario() + (ValorVendas * TaxaComissao);
        }
    }
}
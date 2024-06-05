namespace XulambsFoods
{
    public class FuncionarioCLT : Funcionario
    {
        public decimal SalarioBase { get; set; }
        public int HorasTrabalhadas { get; set; }

        public FuncionarioCLT(int id, string nome, decimal salarioBase, int horasTrabalhadas)
            : base(id, nome)
        {
            SalarioBase = salarioBase;
            HorasTrabalhadas = horasTrabalhadas;
        }

        public override decimal CalcularSalario()
        {
            return SalarioBase;
        }
    }
}
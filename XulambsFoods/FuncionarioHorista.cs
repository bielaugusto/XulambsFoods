namespace XulambsFoods
{
    public class FuncionarioHorista : Funcionario
    {
        public decimal SalarioHora { get; set; }
        public int HorasTrabalhadas { get; set; }

        public FuncionarioHorista(int id, string nome, decimal salarioHora, int horasTrabalhadas)
            : base(id, nome)
        {
            SalarioHora = salarioHora;
            HorasTrabalhadas = horasTrabalhadas;
        }

        public override decimal CalcularSalario()
        {
            return SalarioHora * HorasTrabalhadas;
        }
    }

}
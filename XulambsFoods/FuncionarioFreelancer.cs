public class FuncionarioFreelancer : Funcionario
{
    public decimal ValorServico { get; set; }

    public FuncionarioFreelancer(int id, string nome, decimal valorServico) 
        : base(id, nome)
    {
        ValorServico = valorServico;
    }

    public override decimal CalcularSalario()
    {
        return ValorServico;
    }
}
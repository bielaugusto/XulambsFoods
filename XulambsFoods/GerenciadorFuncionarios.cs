public class GerenciadorFuncionarios
{
    private List<Funcionario> funcionarios = new List<Funcionario>();

    public void CadastrarFuncionario(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
    }

    public void ExibirRelatorioSalarios()
    {
        Console.WriteLine("Relatório de Salários dos Funcionários:");
        foreach (var funcionario in funcionarios)
        {
            Console.WriteLine($"ID: {funcionario.ID}, Nome: {funcionario.Nome}, Salário Final: {funcionario.CalcularSalario():C2}");
        }
    }
}
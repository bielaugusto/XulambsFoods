using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando um gerente de funcionários
            GerenciadorFuncionarios gerenciador = new GerenciadorFuncionarios();

            // Cadastrando funcionários
            gerenciador.CadastrarFuncionario(new FuncionarioCLT(1, "João", 2000, 200));
            gerenciador.CadastrarFuncionario(new FuncionarioCLTComComissao(2, "Maria", 1500, 200, 5000));
            gerenciador.CadastrarFuncionario(new FuncionarioHorista(3, "Pedro", 15, 80));
            gerenciador.CadastrarFuncionario(new FuncionarioFreelancer(4, "Ana", 500));

            // Exibindo relatório de salários
            gerenciador.ExibirRelatorioSalarios();
        }
    }
}

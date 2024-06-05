using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    public abstract class Funcionario{
    public int ID { get; set; }
    public string Nome { get; set; }

    public Funcionario(int id, string nome)
    {
        ID = id;
        Nome = nome;
    }

    public abstract decimal CalcularSalario();
}
}
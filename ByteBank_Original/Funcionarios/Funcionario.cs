using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Original.Funcionarios
{
    public abstract class Funcionario
    {      
        public static int TotalDeFUncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }       

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionário");           
            CPF = cpf;
            Salario = salario;
            TotalDeFUncionarios++;
        }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
  
    }
}

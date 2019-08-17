using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj15_revisao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome do Funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Informe o cargo do Funcionário: ");
            string cargo = (Console.ReadLine());

            Console.Write("Informe o salário do Funcionário: ");
            decimal salario = decimal.Parse(Console.ReadLine());

            Console.Write("Informe a Porcentagem de desconto: ");
            double desconto = double.Parse(Console.ReadLine());

            Funcionario func = new Funcionario(nome, cargo, salario, desconto);

            Console.WriteLine();
            Console.WriteLine(func);

            
        }
    }
}

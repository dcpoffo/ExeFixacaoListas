using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionario = new List<Funcionario>();

            Console.Write("Quantos funcionários serão registrados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Random random = new Random();

                Console.WriteLine($"Funcionário #{i+1}:");
                Console.Write("ID       : ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome     : ");
                string nome = Console.ReadLine();
                Console.Write("Salario  : ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //adiciona o funcionario atual na lista de funcionarios
                funcionario.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionários:");
            foreach (var obj in funcionario)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.Write("Entre com o ID do funcionário que terá aumento de salário: ");
            int IdPesquisa = int.Parse(Console.ReadLine());

            //cria um objeto do tipo Funcionario com os dados (id, nome, salario) da lista de funcionario, cujo ID seja = pesquisa
            Funcionario funcID = funcionario.Find(x => x.Id == IdPesquisa);
            if (funcID != null)
            {
                Console.Write("Entre com a % do aumento: ");
                double porcentagem = double.Parse(Console.ReadLine());
                funcID.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Este ID não existe!!!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionários atualizada:");
            foreach (var obj in funcionario)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();

        }
    }
}

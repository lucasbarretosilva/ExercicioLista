using System;
using System.Collections.Generic;

namespace ExercicioLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();

            Console.WriteLine("***********************CADASTRO DE FUNCIONÁRIOS**********************");
            Console.WriteLine();
            Console.WriteLine("Digite quantos funcionários deseja cadastrar: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário #"+i);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                list.Add(new Funcionario (nome, id, salario));
                Console.WriteLine("_______________________________________________");
            }
            Console.Write("Digite o ID do funcionário que terá um aumento salarial: ");
            int buscaId = int.Parse(Console.ReadLine());    

            Funcionario fun = list.Find(x => x.Id == buscaId);

            if (fun != null)
            {
                Console.Write("Digite a porcentagem: ");
                double porc = double.Parse(Console.ReadLine());
                fun.AumentarSalario(porc);


            }
            else
            {
                Console.WriteLine("Id inválido");
            }
            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários: ");
            foreach(Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }

           


        }
    }
}

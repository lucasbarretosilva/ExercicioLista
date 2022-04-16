using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista
{
    internal class Funcionario
    {
        public string Nome;

        public int Id { get; set; }
        public double Salario { get; private set; }

       

        public Funcionario(string nome, int id, double salario)
        {
            Nome = nome;
            Id = id;
            Salario = salario;
           
        }

        public void AumentarSalario(double porc)
        {
            double aumento = (porc * Salario) / 100;
            Salario = Salario + aumento;
        }
        public override string ToString()
        {
            return "ID: " + Id + "," +"Nome: " + Nome + ","+ "Salário: " + Salario;
        }
    }
}

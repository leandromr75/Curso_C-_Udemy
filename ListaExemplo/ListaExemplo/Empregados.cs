using System;
using System.Collections.Generic;
using System.Text;

namespace ListaExemplo
{
    class Empregados
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Empregados(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void Aumento(double porcentual)
        {
            Salario += (Salario * porcentual) / 100.00;
        }


        public override string ToString()
        {

            return "Id: " + Id 
                   + "\nNome: " + Nome
                   + "\nSalário: " + Salario;
        }
    }
}

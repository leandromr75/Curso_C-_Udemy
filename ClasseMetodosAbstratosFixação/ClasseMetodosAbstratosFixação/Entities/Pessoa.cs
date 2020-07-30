using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseMetodosAbstratosFixação.Entities
{
    abstract class Pessoa
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected Pessoa()
        {
        }

        protected Pessoa(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}

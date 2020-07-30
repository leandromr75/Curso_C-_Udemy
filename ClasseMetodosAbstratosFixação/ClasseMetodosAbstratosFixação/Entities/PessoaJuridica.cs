using System;
using System.Collections.Generic;
using System.Text;
using ClasseMetodosAbstratosFixação;
using ClasseMetodosAbstratosFixação.Entities;

namespace ClasseMetodosAbstratosFixação.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumberOfEmployees { get; set; }
        public PessoaJuridica(string name, double anualincome, int numberofEmplyees ) : base(name, anualincome)
        {
            NumberOfEmployees = numberofEmplyees;
        }
        public override double Tax()
        {
            double result = 0.0;
            if (NumberOfEmployees > 10)
            {
                result = AnualIncome * 0.14;
            }
            if (NumberOfEmployees <= 10)
            {
                result = AnualIncome * 0.16;
            }
            return result;
        }
    }
}

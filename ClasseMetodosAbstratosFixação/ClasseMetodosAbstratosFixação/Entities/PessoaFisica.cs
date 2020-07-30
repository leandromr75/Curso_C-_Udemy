using System;
using System.Collections.Generic;
using System.Text;
using ClasseMetodosAbstratosFixação.Entities;
using ClasseMetodosAbstratosFixação;

namespace ClasseMetodosAbstratosFixação.Entities
{
    class PessoaFisica : Pessoa
    {
        public double HealthExpendidures { get; set; }
        public PessoaFisica(string name, double anualincome, double healthExpendidures) : base(name, anualincome)
        {
            HealthExpendidures = healthExpendidures;
        }
        public override double Tax()
        {
            double result = 0.0;
            if (AnualIncome < 20000.0)
            {
                
                if (HealthExpendidures >= 25000.0)
                {
                    result = AnualIncome * 0.25 - HealthExpendidures * 0.5; 
                }
                else
                {
                    result = AnualIncome * 0.25;
                }
            }
            if (AnualIncome < 20000.0)
            {
                if (HealthExpendidures > 0.0)
                {
                    result = AnualIncome * 0.15 - HealthExpendidures * 0.50;
                }
                else
                {
                    result = AnualIncome * 0.15;
                }
            }
            return result;
            
        }
    }
}

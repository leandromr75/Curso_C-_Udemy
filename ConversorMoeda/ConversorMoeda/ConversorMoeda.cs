using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoeda
{
    class ConversorMoeda
    {
        public static double result = 0.0;

        public static double Calculo(double dollar, double qtde)
        {
            result = dollar * (qtde * 1.06);
            return result; 
        }
    }
}

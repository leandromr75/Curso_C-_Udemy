using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Banco
{
    class Conta
    {
        private int _conta;
        public string Nome { get; set; }
        private double _saldo;

        public Conta(int conta, string nome)
        {
            _conta = conta;
            Nome = nome;
            //_saldo = 0.0;
            Deposito(0.00);
        }
        public Conta(int conta, string nome, double saldo)
        {
            _conta = conta;
            Nome = nome;
            //_saldo = saldo;
            Deposito(saldo);
        }
        public void Deposito(double dep)
        {
            _saldo += dep;
        }
        public void Saque(double sac)
        {
            _saldo -= sac + 5.0;
        }
        public override string ToString()
        {
            return "Dados da conta:\nConta " + _conta + ", Titular: " +
                Nome + ", Saldo: $ " + _saldo.ToString(CultureInfo.InvariantCulture);
        }
    }
}

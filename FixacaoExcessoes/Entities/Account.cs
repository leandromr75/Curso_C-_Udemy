using System;
using FixacaoExcessoes.Entities.Exceptions;

namespace FixacaoExcessoes.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }


        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > Balance)
            {
                throw new DomainExceptions("Saldo Insuficiente"); 
            }

            if(amount > WithdrawLimit)
            {
                throw new DomainExceptions("Limite de saque excedido");
            }

            Balance -= amount;


        }
    }
}
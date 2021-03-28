using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Exceptions;

namespace ByteBank.Exceptions
{
    public class BalanceInsufficientException : FinancialOperationException
    {
        public double Balance { get; }
        public double Amount { get; }

        public BalanceInsufficientException()
        {
        }

        public BalanceInsufficientException(double balance, double withdrawValue) 
            : this($"Withdrawl attempt with insufficient balance\nBalance: {balance}\nWithdraw: {withdrawValue}")
        {
            Balance = balance;
            Amount = withdrawValue;
        }

        public BalanceInsufficientException(string message) : base(message)
        {

        }

        public BalanceInsufficientException(string message, Exception innerException) : base(message, innerException)
        {

        }



    }
}

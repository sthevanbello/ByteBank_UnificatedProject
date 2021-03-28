using ByteBank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities

{
    public class Account
    {
        public static double OperationTax { get; private set; }
        public Client Holder { get; set; }
        public static int CountAccount { get; private set; }
        public int _countWithdrawDenied { get; private set; }
        public int _countTransferDenied { get; private set; }

        private double _balance = 100;
        public int AccountNumber { get; }
        public int AgencyNumber { get; }

        public Account()
        {
        }

        public Account(Client holder, int agencyNumber, int accountNumber, double balance)
        {
            Holder = holder;
            AgencyNumber = agencyNumber;
            AccountNumber = accountNumber;
            Balance = balance;
            CountAccount++;
            OperationTax = 30 / CountAccount;

            if (agencyNumber <= 0)
            {
                throw new ArgumentException("Agency number must be greater than zero", nameof(agencyNumber));
            }
            if (accountNumber <= 0)
            {
                throw new ArgumentException("Account number must be greater than zero", nameof(accountNumber));
            }

        }
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _balance += value;
            }
        }


        public double GetBalance()
        {
            return Balance;
        }

        public void SetBalance(double value)
        {
            if (value < 0)
            {
                return;
            }
            _balance += value;
        }
        public void Withdraw(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid value for withdraw: ", nameof(value));
            }

            if (_balance < value)
            {
                _countWithdrawDenied++;
                throw new BalanceInsufficientException(_balance, value);
            }
            _balance -= value;
        }


        public void Deposit(double value)
        {
            _balance += value;
        }

        public void Transfer(double value, Account accDesnity)
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid value for transfer: ", nameof(value));
            }
            try
            {
                Withdraw(value);
                accDesnity.Deposit(value);
            }
            catch (BalanceInsufficientException ex)
            {
                _countTransferDenied++;
                throw new FinancialOperationException("Operation cannot be performed", ex);
            }

        }
    }
}

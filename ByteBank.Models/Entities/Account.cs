using ByteBank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities

{
    /// <summary>
    /// Define the characteristics of a ByteBank account
    /// </summary>

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

        /// <summary>
        /// Create an instance of Account with holder, agency number, account number and opening balance 
        /// </summary>
        /// <param name="holder"></param>
        /// <param name="agencyNumber">Value greater than zero for <see cref="AgencyNumber"/></param>
        /// <param name="accountNumber">Value greater than zero <see cref="AccountNumber"/></param>
        /// <param name="balance">Value greater than zero</param>
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
        /// <summary>
        /// Check the account balance
        /// </summary>
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

        /// <summary>
        /// check the balance and withdraw the amount <see cref="Balance"/>
        /// </summary>
        /// <exception cref="ArgumentException">Exception thrown when a negative value is entered in the <paramref name="value"/>.</exception>
        /// <exception cref="BalanceInsufficientException">Exception thrown when the value of <paramref name="value"/> is bigger than <see cref="Balance"/>.</exception>
        /// <param name="value">Withdrawal amount must be greater than zero and less than the <see cref="Balance"/></param>
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

        public override bool Equals(object obj)
        {
            Account other = obj as Account;

            if (!(obj is Account))
            {
                throw new Exception("Not is a object Account!");
            }

            return AccountNumber == other.AccountNumber;
        }
    }
}

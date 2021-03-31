using ByteBank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Agency
{
    class AccountList
    {
        // private HashSet<Account> _listAccount { get; set; } = new HashSet<Account>();
        private List<Account> _listAccount { get; set; } = new List<Account>();

        public AccountList()
        {

        }
        

        public void AddAccount(Account account)
        {
            _listAccount.Add(account);
        }

        public void RemveAccount(Account account)
        {
            _listAccount.Remove(account);
        }

        public List<Account> ReturnList()
        {
            return _listAccount;
        }

        
    }
}

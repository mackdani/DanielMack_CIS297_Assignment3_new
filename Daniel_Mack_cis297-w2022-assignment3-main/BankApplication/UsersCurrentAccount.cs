using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class UsersCurrentAccount : Account
    {
        public UsersCurrentAccount()
        {
            this.setInterestRate(0.15);
            this.setAccounttype("Current");
        }
        private void CancelInterest()
        {
            double balance = BalanceDisplay();
            double New_Balance = balance + (balance * getInterestRate());
        }
    }
}

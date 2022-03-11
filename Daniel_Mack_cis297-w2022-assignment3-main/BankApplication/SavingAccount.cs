using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class SavingAccount : Account
    {
        public SavingAccount()
        {
            this.setInterestRate(0.04);
            this.setAccounttype("Savings");
        }
    }
}

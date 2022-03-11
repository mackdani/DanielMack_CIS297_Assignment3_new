using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    abstract class Account
    {
        static int account;
        private int account_number;
        private double balance;
        private string accountType;
        private double NumberRate;
        private string AccountHolder;
        public Account()
        {
            account = account + 1;
            account_number = account;
        }
        public Account(string A)
        {
            account = account + 1;
            account_number = account;
            accountType = A;
        }
        public int getAccountNumber()
        {
            return this.account_number;
        }
        public double Deposit(double Money)
        {
            this.balance = this.balance + Money;
            return this.balance;
        }
        public double BalanceDisplay()
        {
            return this.balance;
        }
        private void setBalance(double Money)
        {
            this.balance = Money;
        }
        public double withdraw(double UserMoney)
        {
            if (this.balance > (UserMoney + 700))
            {
                this.balance = this.balance - UserMoney;
                Console.WriteLine("Withdraw:Success!!");
            }
            else
            {
                Console.WriteLine("Withdraw:Failed!! Try Again.");
            }
            return this.balance;
        }
        public string[] getInfo()
        {
            string[] Info = new string[5];
            Info[0] = this.account_number.ToString();
            Info[1] = this.accountType.ToString();
            Info[2] = this.balance.ToString();
            Info[3] = this.AccountHolder.ToString();
            Info[4] = this.AccountHolder.ToString();
            return Info;
        }
        public void setInterestRate(double Interest)
        {
            this.NumberRate = Interest;
        }
        protected double getInterestRate()
        {
            return this.NumberRate;
        }
        public void setNIC(string NIC)
        {
            this.AccountHolder = NIC;
        }
        public string getNIC(string NIC)
        {
            return this.AccountHolder;
        }
        protected void setAccounttype(string AcType)
        {
            this.accountType = AcType;
        }
        public void setDeposit(string MoneyDep)
        {
            this.AccountHolder = MoneyDep;
        }
        public string getDeposit(string Nic)
        {
            return this.AccountHolder;
        }
        public void setWithDraw(string WithDraw)
        {
            this.AccountHolder = WithDraw;
        }
        public string getWithDraw()
        {
            return this.AccountHolder;
        }
    }
}

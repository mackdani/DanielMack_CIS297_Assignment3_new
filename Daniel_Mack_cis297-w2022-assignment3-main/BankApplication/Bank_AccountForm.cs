using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class Bank_AccountForm : Form
    {
        SavingAccount New_A;
        UsersCurrentAccount Current_A;
        public Bank_AccountForm()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            New_A = new SavingAccount();
            New_A.setNIC(textNIC.Text);
            New_A.Deposit(double.Parse(textAmount.Text));

            string AccountNum = New_A.getInfo()[0];
            string AccountType = New_A.getInfo()[1];
            string Balance = New_A.getInfo()[2];
            string Nic = New_A.getInfo()[3];
            string Deposit = New_A.getInfo()[4];

            DetailsLabel.Text = AccountNum + " -- " + AccountType + " -- " + "NIC Number:" + Nic + " -- Balance$:" + Balance;

            DetailsLabel.Visible = true;
            WithdrawButton.Visible = true;
            DepositButton.Visible = true;
            textDeposit.Visible = true;
            DepositLabel.Visible = true;
            WithdrawLabel.Visible = true;
            textWithdraw.Visible = true;
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            double Amount = Double.Parse(textDeposit.Text);
            double Balance = New_A.Deposit(Amount);
            DepositLabel.Visible=true;
            DepositsMessage.Visible = true;
            DepositsMessage.Text = "$" + Balance.ToString() + "     " + Amount + " had been Deposited";

        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            double Amount = Double.Parse(textWithdraw.Text);
            double Balance = New_A.withdraw(Amount);
            WithdrawMessage.Visible = true;
            WithdrawLabel.Visible = true;
            WithdrawMessage.Text = "New Balance:$" + Balance.ToString() + "     $" + Amount + " had been withdrawed";
        }

        private void New_button_Click(object sender, EventArgs e)
        {
            textNIC.Text = "";
            textAmount.Text = "";
            textDeposit.Text = "";
            textWithdraw.Text = "";
            DetailsLabel.Text = "";
            WithdrawMessage.Text = "";
            DepositsMessage.Text = "";
            textDeposit.Visible = false;
            textWithdraw.Visible = false;
            DepositLabel.Visible = false;
            WithdrawLabel.Visible = false;
            WithdrawButton.Visible = false;
            DepositButton.Visible = false;
        }

        private void CurrentAccountLabel_CheckedChanged(object sender, EventArgs e)
        {
            Current_Account.Visible = true;
            CurrentAccountLabel.Visible = true;
            Saving_Account.Visible = false;
            CurrentAccountPanel.Visible = true;
        }

        private void SavingsLabel_CheckedChanged(object sender, EventArgs e)
        {
            SavingsLabel.Visible = true;
            Saving_Account.Visible = true;
            Savings_panel.Visible = true;
            CurrentAccountPanel.Visible = false;
        }

        private void NewButton2_Click(object sender, EventArgs e)
        {
            textNIC_NO.Text = "";
            textAmount2.Text = "";
            textDeposit2.Text = "";
            DetailsLabel2.Text = "";
            DepositMessage2.Text = "";
            textDeposit2.Visible = false;
            Depositlabel2.Visible = false;
            Depositbutton2.Visible = false;
        }

        private void CreateAccount2_Click(object sender, EventArgs e)
        {
            Current_A = new UsersCurrentAccount();
            Current_A.setNIC(textNIC_NO.Text);
            Current_A.Deposit(double.Parse(textAmount2.Text));

            string AccountNum = Current_A.getInfo()[0];
            string AccountType = Current_A.getInfo()[1];
            string Balance = Current_A.getInfo()[2];
            string Nic = Current_A.getInfo()[3];
            string Deposit = Current_A.getInfo()[4];

            DetailsLabel2.Text = AccountNum + " -- " + AccountType + " -- " + "NIC Number:" + Nic + " -- Balance:$" + Balance;

            DetailsLabel2.Visible = true;
            Depositbutton2.Visible = true;
            textDeposit2.Visible = true;
            Depositlabel2.Visible=true;
        }

        private void Depositbutton2_Click(object sender, EventArgs e)
        {
            double Amount = Double.Parse(textDeposit2.Text);
            double Balance = Current_A.Deposit(Amount);
            Depositlabel2.Visible = true;
            DepositMessage2.Visible = true;
            DepositMessage2.Text = "$" + Balance.ToString() + "     $" + Amount + " had been Deposited";
        }
    }
}

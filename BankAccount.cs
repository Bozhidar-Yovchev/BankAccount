using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        private string accountNumber;
        private string ownerName;
        private decimal accountBalance;

        public string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        public string OwnerName
        {
            get { return this.ownerName; }
            set { this.ownerName = value; }
        }
        public decimal AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        public BankAccount()
        {
            this.AccountNumber = "";
            this.OwnerName = "";
            this.AccountBalance = 0.0M;
        }
        public BankAccount(string accountNumber,string ownerName,decimal accountBalance)
        {
            this.AccountNumber = accountNumber;
            this.OwnerName = ownerName;
            this.AccountBalance = accountBalance;
        }

        public string MakeDeposit(decimal sum)
        {
            this.AccountBalance += sum;
           return $"Account balance: {AccountBalance}";
        }
        public string MakeWithdraw(decimal withdraw)
        {
            if (this.AccountBalance - withdraw <= 0)
            {
                return "insuffisant amount of money";
            }
            else
            {
                this.AccountBalance -= withdraw;
                return $"Withdrawed money: {withdraw}. You have in your bank account: {this.AccountBalance}";
            }  
        }

    }
}

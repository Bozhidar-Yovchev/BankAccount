using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] customer = Console.ReadLine().Split();
            string accountNumber = customer[0];
            string ownerName = customer[1] + " " + customer[2];
            decimal accountBalance = decimal.Parse(customer[3]);

            BankAccount account = new BankAccount(accountNumber, ownerName, accountBalance);
            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                string[] masiv = command.Split();
                decimal sum = decimal.Parse(masiv[1]);
                switch (masiv[0].ToLower())
                {
                    case "deposit":
                        Console.WriteLine(account.MakeDeposit(sum));
                        break;
                    case "withdraw":
                        Console.WriteLine(account.MakeWithdraw(sum));
                        break;
                    default:
                        Console.WriteLine("There is no such a command");
                        break;
                }
                command = Console.ReadLine().ToLower();
            }
            

        }
    }
}

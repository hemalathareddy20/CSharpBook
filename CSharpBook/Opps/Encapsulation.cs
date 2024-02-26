using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.Opps
{
    class BankAccount
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
    internal class Encapsulation
    {
        public void EncapSampleMethod()
        {
            // Using the BankAccount class
            BankAccount account = new BankAccount();
            Console.WriteLine("Enter the amount how much you want to deposit");
            string amount = Console.ReadLine();
            decimal depositAmount = decimal.Parse(amount);
            account.Deposit(depositAmount);
            Console.WriteLine($"Deposited Amount = {depositAmount}");

            Console.WriteLine("Enter the amount how much you want to withdraw");
             amount = Console.ReadLine();
            decimal withdrawAmount = decimal.Parse(amount);
            account.Withdraw(withdrawAmount);
            Console.WriteLine($"Withdraw Amount:{withdrawAmount}");

            decimal balance = account.GetBalance();
            Console.WriteLine("Current balance: " + balance);
        }

    }
}

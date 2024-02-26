using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpBook.Basics
{
    public class Porperties
    {
        // Private field
        private string model;

        // Property for accessing and modifying the model field
        public string Model
        {
            // Getter method
            get
            {
                // Here, we can add additional logic if needed
                return model;
            }
            // Setter method
            set
            {
                // Here, we can add validation or other logic before setting the value
                if (!string.IsNullOrEmpty(value))
                {
                    model = value;
                }
                else
                {
                    Console.WriteLine("Model cannot be null or empty");
                }
            }
        }
        public void PorpertiesSampleMethod()
        {
            BankAccount account = new BankAccount(1000);
            account.AccountNumber = "1234567890";//if we add alphabet it throws exception

            // Accessing properties and methods
            Console.WriteLine("Account Number: " + account.AccountNumber);
            Console.WriteLine("Initial Balance: " + account.Balance);

            account.Deposit(500);
            Console.WriteLine("Balance after deposit: " + account.Balance);

            account.Withdraw(300);
            Console.WriteLine("Balance after withdrawal: " + account.Balance);
        }

    }

    /// <summary>
    /// Properties example 2
    /// </summary>
    public class BankAccount
    {
        private string accountNumber;
        private decimal balance;

        // Constructor to initialize accountNumber and balance
        public BankAccount( decimal initialBalance)
        {
            this.balance = initialBalance;
        }

        // Property to get and set the account number
        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                { 
                    // Regular expression pattern to match only numeric characters
                    string pattern = @"^\d+$";

                    // Check if the input string matches the pattern
                    if (Regex.IsMatch(value.ToString(), pattern))
                    {
                        accountNumber = value;
                    }
                    else
                    {
                        throw new ArgumentException("Account number cannot have alphabets");
                    }
                }
                else
                {
                    throw new ArgumentException("Account number cannot be null or empty");
                }
            }
        }

        // Property to get the current balance
        public decimal Balance
        {
            get { return balance; }
        }

        // Method to deposit money into the account
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be greater than zero");
            }

            balance += amount;
        }

        // Method to withdraw money from the account
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero");
            }

            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds for withdrawal");
            }

            balance -= amount;
        }
    }
}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Entities
{
    internal class Account
    {
       
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Balance { get; set; }

        public Account(string name, string surname)
        {
            Id= Guid.NewGuid();
            Name = name;
            Surname = surname;
            Balance = 100000;
        }

        public void Withdraw(decimal amount)
        {
            if(Balance - amount >= 0)
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw Amount: {amount}");
            }
            else
            {
                Console.WriteLine("Not enough money");
            }
        }
    }
}

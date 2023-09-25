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
        //public decimal Balance { get; private set; }

        private decimal balance;//our data will be here
        public decimal Balance
        {
            //when the request came
            get { return balance; }
            set
            {
                if (Math.Abs(value - balance) <= 500)
                {
                    balance = value;
                    Console.WriteLine($"Current Balance : {balance}");
                }
            }
        }


        public Account(string name, string surname)
        {
            Id= Guid.NewGuid();
            Name = name;
            Surname = surname;
            balance = 2000;
        }

        //public void Withdraw(decimal amount)
        //{
        //    if(Balance - amount >= 0)
        //    {
        //        Balance -= amount;
        //        Console.WriteLine($"Withdraw Amount: {amount}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not enough money");
        //    }
        //}
    }
}

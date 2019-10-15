using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
     public class Person
    {
        public string accountNumber;
        public string customerName;
        public double balance;

       public void Deposit(double amount)
        {
            balance = balance + amount;
        }
        public void Withdraw(double amount)
        {
            balance = balance - amount;
        }
        
    }
}

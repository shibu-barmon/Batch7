using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)

        {
            string name;
            string Age;
            string Address;
            string Contact;
            Console.WriteLine("Please Enter Your Name");
            name = Console.ReadLine();

            Console.WriteLine("Please Enter Your Age");
            Age = Console.ReadLine();


            Console.WriteLine("Please Enter Your Address");
            Address = Console.ReadLine();

            Console.WriteLine("Please Enter Your Contact");
            Contact = Console.ReadLine();
            Console.WriteLine("Here is Your Information");

            Console.WriteLine("Name =" + name);
            Console.WriteLine("Age =" + Age);
            Console.WriteLine("Address = " + Address);
            Console.WriteLine("Contact =" + Contact);
            Console.ReadKey();
        }
    }
}



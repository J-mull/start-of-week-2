using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter you first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter you last name");
            string lastName = Console.ReadLine();
            Console.Write("Your full name is {0}",(firstName + " " +  lastName));

            Console.ReadLine();

        }
    }
}

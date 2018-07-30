using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Please enter two numbers\n Enter your first number then press enter, then enter your second number.");

            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your two numbers added together are {0}",number1+number2);
            Console.WriteLine("Your two numbers subtracted  are {0}", number1 - number2);
            Console.WriteLine("Your two numbers muiltiplied are {0}", number1 * number2);
            Console.WriteLine("Your two numbers divided are {0}", number1 / number2);



            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {

            try {
                Console.WriteLine("Enter First Number: ");
                double num = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("EnterSecond Number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("The answer is  ");

                Console.WriteLine(num / num2);
            }
            catch {
                Console.WriteLine("Error:one of the  Entered variable is not a number");
            }
           

            Console.ReadLine();
        }
    }
}

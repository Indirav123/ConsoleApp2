using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class calculator
    {

        static void Main(string[] args)
        {
            char op;
            double v1, v2;
            Console.WriteLine("Enter the operator(+,-,*,/)");
            op = Console.ReadLine()[0];
            Console.WriteLine("Enter the 2 number");
            v1 = Convert.ToDouble(Console.ReadLine());
            v2 = Convert.ToDouble(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", v1, v2, (v1 + v2));
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", v1, v2, (v1 - v2));
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", v1, v2, (v1 * v2));
                    break;
                case '/':
                    if (v2 == 0)
                        Console.WriteLine("divide by zero situation");
                    else
                        Console.WriteLine("{0}+{1}={2}", v1, v2, (v1 / v2));
                    break;
                default:
                    Console.WriteLine("{0} is an individual operator", op);
                    break;



            }
            Console.WriteLine("Press Any Key to exit the program");
            Console.ReadKey();
        }
    }
}

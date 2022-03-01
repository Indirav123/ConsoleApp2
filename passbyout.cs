using System;
using System.Linq;


namespace ConsoleApp2
{
    internal class passbyout
    {
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }
        static void Main(string[] args)
        {
            passbyout n = new passbyout();
            int a = 100;
            Console.WriteLine(a);
            n.getValue(out a);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
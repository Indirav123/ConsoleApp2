using System;
using System.Linq;

namespace ConsoleApp2
{
    internal class passbyreference
    {
        public void swap(ref int x,ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("After swap,value of x : {0}", x);
            Console.WriteLine("After swap,value of y : {0}", y);
        }
        static void Main(string[] args)
        {
            passbyreference n=new passbyreference();
            int a = 100;
            int b = 200;
            Console.WriteLine("Before swap,value of a : {0}", a);
            Console.WriteLine("Before swap,value of b : {0}", b);
            n.swap(ref a, ref b);
            Console.WriteLine("After swap,value of a : {0}", a);
            Console.WriteLine("after swap,value of b : {0}", b);
            Console.ReadLine();
        }
    }
}

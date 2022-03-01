using System;
using System.Linq;

namespace ConsoleApp2
{
    internal class passbyvalue
    {
        public void swap(int a,int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("after swappping, value of a: {0}", a);
            Console.WriteLine("after swapping,value of b: {0}", b);

        }
        static void Main(string[] args)
        {
            passbyvalue n= new passbyvalue();
            int x = 1;
            int y = 2;
            Console.WriteLine("Before swapping,values of x: {0}", x);
            Console.WriteLine("Before swapping values of y: {0}",y);
            n.swap(x, y);
            Console.WriteLine("After swapping values of x: {0}", x);
            Console.WriteLine("after swapping values of y: {0}", y);
            Console.ReadLine();
        }
    }
}

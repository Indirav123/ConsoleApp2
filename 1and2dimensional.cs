using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class onedimensionalarray
    {
        public static void Main()
        {
            string[] months;
            months = new string[] { "jan", "feb", "mar", "apr", "may" };
            foreach(string month in months)
                Console.WriteLine(month);
            string[] dotnet = { "c#", "ASP", "ADD" };
            for (int i = 0; i < dotnet.Length; i++)
            {
                Console.WriteLine(dotnet[i]);
            }
            foreach(string i in dotnet)
            {
                Console.WriteLine(i);
            }
            Array.Sort(dotnet);
            foreach(string i in dotnet)
            {
                Console.WriteLine(i);
            }
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());
            Console.WriteLine(myNumbers.Min());
            Console.WriteLine(myNumbers.Sum());
            Console.ReadLine();
        }
    }
}

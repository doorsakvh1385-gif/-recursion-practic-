using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("fibonachi " + n + ":");
            PF(0, 1, n);
            Console.ReadKey();
        }
      
        static void PF(int a, int b, int max)
        {
          
            if (a > max)
                return;

            Console.Write(a + " , ");
           
            PF(b, a + b, max);
        }
    }
}

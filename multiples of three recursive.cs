using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter one number ");
            int n = int.Parse(Console.ReadLine());
            PMO3(n - 1);
        }
        static void PMO3(int n) { if (n <= 0)
                return;
            if (n % 3 == 0)
                Console.WriteLine(n);
            PMO3(n - 1);
        }
        
        
           
    }
}

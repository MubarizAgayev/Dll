using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers
{
    internal class Calculator
    {
        int result = 0;
        int sum = 0;
        int multi = 0;
        int division = 0;
        public void calculation(int a,int b)
        {
            int result = a + b;
            Console.WriteLine(result);
            int sum = a - b;
            Console.WriteLine(sum);
            int division = a / b;
            Console.WriteLine(division);
            int multi = a * b;
            Console.WriteLine(multi);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, sum = 0;
            while (i<=5)
            {
                sum += i;
                i++;
            }
            {
                Console.WriteLine("The sum of these five numbers is " + sum);
                Console.ReadLine();
            }
        }
    }
}

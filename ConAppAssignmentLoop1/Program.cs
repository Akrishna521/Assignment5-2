using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignmentLoop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //***Natural numbers***
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //***Even Numbers
            //int i = 2;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i += 2;
            //}
             
            //***Odd numbers***
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i += 2;
            } while (i <= 10);

        }
    }
}

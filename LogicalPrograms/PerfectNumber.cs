using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {

        public static void perfectnumber()
        {

            Console.WriteLine("Enter the number you want to check perfect number or not");
            int N;
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(N);
            int sum = 0;


            for (int i = 1; i < N; i++)
            {
                if (N % i == 0)   //here checking the number is divisible by the iTh number or not
                {
                    sum += i;   // if yes the sum=sum+i

                }

            }
            Console.WriteLine(N);
            if (N == sum)    // here checking the number is equal to sum of the divisible number 
            {
                Console.WriteLine("the {0} is Perfect NUmber ", N);  // if yes the number is perfect number

            }
            else
            {
                Console.WriteLine("the {0} is not Perfect Number", N);  // if not the number is not perfect number 
            }
        }

    }
}

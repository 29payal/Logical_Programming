using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public static void primeNumber()
        {

            Console.WriteLine("Enter the number to check prime number or not");
            int num = Convert.ToInt32(Console.ReadLine()); //taking inout from user
            int flag = 0;

            for (int i = 2; i <= num / 2; i++)     // checking the number is prime or not by looping the half number 
            {
                if (num % i == 0)  //here if number is divided by ith number then it is not prime number 
                {
                    Console.WriteLine(" {0} is not a prime number", num);
                    flag = 1;    //here declear the flag =1;
                }

            }
            if (flag == 0)   //flag ==0 then  it is prime number
            {
                Console.WriteLine(" {0} is a prime number", num);

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public static void reverseNumber()
        {
            Console.WriteLine("Enter the number to reverse too that number");
            int Num = Convert.ToInt32(Console.ReadLine());
            int remain = 0;
            int rev = 0;
            Console.WriteLine("The main Number is :{0}", Num);


            while (Num != 0)   //here checking the number is not equal 0
            {
                remain = Num % 10;          //here divide the number by 10 to get Remainder
                rev = rev * 10 + remain;         //here adding the remainder in rev *10
                Num/= 10;              // after that number will divide by the 10 get the Quotient 

            }
            Console.WriteLine("The reverse Number is :{0}", rev);
        }
    }
}
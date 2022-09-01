using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonnacciSeries
    {
        public static void Fibonnacci()
        {
            Console.WriteLine("Enter the number you want to Fibonnacci series");
            int number = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;
            int result = 0;
            Console.WriteLine("The fibonnacci series: ");
            Console.WriteLine(a);
            Console.WriteLine(b);   
      
            for (int i = 0; i < number; i++)
            {
                result = a + b;
                Console.WriteLine("{0}" , result);  
                a = b;
                b = result; 

            }
            
        }
    }
}

﻿namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the option\n 1. Fibonnacci Series\t 2.Perfect NUmber ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FibonnacciSeries.Fibonnacci();
                    break;
                    case 2:
                    PerfectNumber.perfectnumber();
                    break;
                    default:
                    Console.WriteLine("Wrong Choice");
                    break;
            } 
        }
    }
}

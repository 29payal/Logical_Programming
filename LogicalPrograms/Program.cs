namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the option\n 1. Fibonnacci Series\t 2.Perfect NUmber\t 3.Prime Number\t 4.Reverse nUmber\t 5.Binary Conversion\t 6.Swap nibbles\t 7. Square Root\t 8.Day of Week\t 9.Monthly Payment\t  10. NOTES\t  11. Temperature Conversion\t 12. Coupon number\t 13. Stop__Watch ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FibonnacciSeries.Fibonnacci();
                    break;
                case 2:
                    PerfectNumber.perfectnumber();
                    break;
                case 3:
                    PrimeNumber.primeNumber();
                    break;
                case 4:
                    ReverseNumber.reverseNumber();
                    break ;
                case 5:
                    BinaryConversion.toBinary();
                    break;
                case 6:
                    SwapNibbles.swapNibbles();
                    break;
                case 7:
                    SquareRoot.squareRoot();
                    break;
                case 8:
                    DayofWeek.dayOfWeek();
                        break;
                case 9:
                    MonthlyPayment.monthlyPayment();
                    break;
                case 10:
                    NOTES.notesCounter();
                        break;
                case 11:
                    TemperatureConversion.temperature();
                    break;
                case 12 :
                    CouponNumber.GetCouponNumber();
                    break;
                case 13 :
                    StopWatch.stopwatch();
                    break;
                    default:
                    Console.WriteLine("Wrong Choice");
                    break;
            } 
        }
    }
}

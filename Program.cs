using System;

namespace Logical_Prgms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the options:");
            Console.WriteLine("1.CouponNumbers");
            Console.WriteLine("2.Day Of Week");
            Console.WriteLine("3.Temperatur Conversion");
            Console.WriteLine("4.Monthly Payment");
            Console.WriteLine("5.Square Root");
            Console.WriteLine("6.Decimal To Binary Conversion");
            Console.WriteLine("7.Binary");
            Console.WriteLine("8.SimulateStopwatch");
            Console.Write("Enter the Option : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CouponNumbers.Readinput();
                    break;
                case 2:
                    DayOfWeek.Readinput();
                    break;
                case 3:
                    TemperatureConversion.Readinput();
                    break;
                case 4:
                    MonthlyPayment.Readinput();
                    break;
                case 5:
                    SquareRoot.Readinput();
                    break;
                case 6:
                    ToBinary.Readinput();
                    break;
                case 7:
                    Binary.Readinput();
                    break;
                case 8:
                    SimulateStopwatch.Readinput();
                    break;
                default:
                    Console.WriteLine("Invalid options");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double double1 = GetValue("Enter Value1");
            double double2 = GetValue("Enter Value2");

            double result = 0;

            while (true)
            {
                Console.WriteLine("(A)dd (S)ubtract (M)ultiply (D)ivide: ");
                ConsoleKeyInfo info = Console.ReadKey();
                string operation = info.Key.ToString();

                switch (operation.ToUpper())
                {
                    case "A":
                        result = Add(double1, double2);
                        break;
                    case "S":
                        result = Subtract(double1, double2);
                        break;
                    case "M":
                        result = Muiltiply(double1, double2);
                        break;
                    case "D":
                        result = Add(double1, double2);
                        break;

                    default:
                        Console.WriteLine("Choose from supported Operations");
                        break;
                }
                Console.WriteLine("\nResult: " + result);
                Console.Read();
                break;
            }

        }
        private static double GetValue(string lable)
        {
            //the vaule returns
            double value;

            while (true)
            {
                Console.WriteLine(lable);
                string input = Console.ReadLine();
                if (Double.TryParse(input, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Value can't be parsed as a number");
                }
            }
        }
        private static double Add(double double1, double double2)
        {
            return double1 + double2;
        }
        private static double Subtract(double double1, double double2)
        {
            return double1 - double2;
        }
        private static double Muiltiply(double double1, double double2)
        {
            return double1 * double2;
        }
        private static double Divide(double double1, double double2)
        {
            if (double1 == 0 || double2 == 0)
            {
                return 0;
            }
            else
            {
                return double1 / double2;
            }
        }

    }
}

using ExtMethods;
using System;
using System.Reflection.Metadata;

namespace AppExtMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtensionClass obj = new ExtensionClass();
            int result = obj.MultiplicationNumber(20, 30);
            Console.WriteLine(result);
            Console.ReadLine();

            int Number = 20;
            Console.WriteLine(Number.CheckOddEven());
            Console.ReadLine();
        }
    }

    public static class NumberCheckOddEven
    {
        public static string CheckOddEven(this Int32 Number)
        {
            if (Number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
    }
    public static class ExtendClass
    {
        public static int MultiplicationNumber(this ExtensionClass multiplication, int Number1, int Number2)
        {
            return Number1 * Number2;
        }
    }
}

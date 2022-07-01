using System;

namespace CIAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(args[1]);
            int num2 = int.Parse(args[2]);

            int sum = Sum(num1, num2);
            decimal div = Divide(num1, num2);
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}

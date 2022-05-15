using System;

namespace TestMaximumNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n------------WELCOME TO GENERICS PROBLEMS TO THE TEST MAXIMUM NUMBER FROM THREE NUMBERS\n\n");
            //Console.WriteLine("Maximum Number From Three Integer Number\n");
            //Console.Write("Enter Num1 : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Num2 : ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Num3 : ");
            //int num3 = int.Parse(Console.ReadLine());
            //int resut = MaxIntegerNumber.MaximumIntegerNumber(num1, num2, num3);
            //Console.WriteLine(resut);

            Console.WriteLine("Maximum Number From Three Float Number\n");
            Console.Write("Enter Num1 : ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Num2 : ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Enter Num3 : ");
            double num3 = double.Parse(Console.ReadLine());
            double resut = MaxFloatNumber.MaximumFloatNumber(num1, num2, num3);
            Console.WriteLine(resut);
        }
    }
}

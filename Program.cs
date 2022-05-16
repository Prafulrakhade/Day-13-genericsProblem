using System;

namespace TestMaximumNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n------------WELCOME TO GENERICS PROBLEMS TO THE TEST MAXIMUM NUMBER FROM THREE NUMBERS\n\n");

            // its for Integer

            //Console.WriteLine("Maximum Number From Three Integer Number\n");
            //Console.Write("Enter Num1 : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Num2 : ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Num3 : ");
            //int num3 = int.Parse(Console.ReadLine());
            //int resut = MaxIntegerNumber.MaximumIntegerNumber(num1, num2, num3);
            //Console.WriteLine(resut);

            // its for Float

            //Console.WriteLine("Maximum Number From Three Float Number\n");
            //Console.Write("Enter Num1 : ");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter Num2 : ");
            //double num2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter Num3 : ");
            //double num3 = double.Parse(Console.ReadLine());
            //double resut = MaxFloatNumber.MaximumFloatNumber(num1, num2, num3);
            //Console.WriteLine(resut);

            // it is for string

            //Console.WriteLine("Maximum Number From Three String \n");
            ////Console.Write("Enter Num1 : ");
            ////string num1 = (Console.ReadLine());
            ////Console.Write("Enter Num2 : ");
            ////string num2 = (Console.ReadLine());
            ////Console.Write("Enter Num3 : ");
            ////string num3 = (Console.ReadLine());
            //string resut = MaxString.MaximumStringNumber("Praful","Mayur","Karan"); // we can write number also  in the string by user
            //Console.WriteLine(resut);


            ////it is for refactor 1

            //Console.WriteLine("Maximum Number From Three Integer Number\n");
            //Refactor1<int> max1 = new Refactor1<int>();
            //max1.MaxValue(13, 46, 87);
            //Console.WriteLine("Maximum Number From Three Float Number\n");
            //Refactor1<double> max2 = new Refactor1<double>();
            //max2.MaxValue(13.98, 46.78, 87.67);
            //Console.WriteLine("Maximum Number From Three String \n");
            //Refactor1<string> max3 = new Refactor1<string>();
            //max3.MaxValue("12", "4", "56");



            // its for refactor 2

            //Console.WriteLine("Maximum Number From Three Integer Number Using Generic Class And Method with IComparable\n");
            //RefactorGenericMax<int> refactorInt = new RefactorGenericMax<int>(12, 23, 45);
            //refactorInt.MaxMethod();
            //Console.WriteLine("Maximum Number From Three Float Number Using Generic Class And Method with IComparable\n");
            //RefactorGenericMax<double> refactorDouble = new RefactorGenericMax<double>(12.52, 23.56, 4.45);
            //refactorDouble.MaxMethod();
            //Console.WriteLine("Maximum Number From Three Float Number Using Generic Class And Method with IComparable\n");
            //RefactorGenericMax<string> refactorString = new RefactorGenericMax<string>("A","B","C");  //we can write number also in string
            //refactorString.MaxMethod();



            // its for refactor 4 

            //Console.WriteLine("Welcome to program ");
            //Console.WriteLine("Enter Length of Array");
            //int len = int.Parse(Console.ReadLine());
            //int[] arr = new int[len];
            //Console.WriteLine("Enter elements of array");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //MaxMethod.Max(arr);



            Console.WriteLine("Enter Length of Array");
            int len = int.Parse(Console.ReadLine());
            int[] arr = new int[len];
            Console.WriteLine("Enter elements of array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            MaxMethodUsingGenerics<int> gen = new MaxMethodUsingGenerics<int>(arr);
            gen.MaxValue();
            gen.MaxMethod();
            gen.MaxPrint();

        }
    }
}

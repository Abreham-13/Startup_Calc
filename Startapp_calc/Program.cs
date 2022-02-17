using System;


namespace MyNamespace
{
    class calculation
    {
        public static double Result;
        public static void Main(string[] args)
        {
            double num1, num2, opt;

            Console.Write("\n\n");
            Console.Write("A menu driven program for a simple calculator:\n");
            Console.Write("------------------------------------------------");
            Console.Write("\n\n");
            while (true)
            {
                Console.Write("enter the first number:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the second number:");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("---------------------OPERATIONS---------------------------");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("\t\t\t=>enter 1 for Addition");
                Console.WriteLine("\t\t\t=>enter 2 for substraction");
                Console.WriteLine("\t\t\t=>enter 3 for multiplication");
                Console.WriteLine("\t\t\t=>enter 4 for Division");
                Console.WriteLine("\t\t\t=>enter 0 for Quit");
                Console.WriteLine("------------------------------------------------");
                opt = Convert.ToInt32(Console.ReadLine());
                if (opt == 0)
                {
                    Environment.Exit(0);
                }
                Result = Calculation.DoOperation(num1, num2, Convert.ToInt32(opt));

                Console.WriteLine($"the Result of your calculation is {Result}");

            }


        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;

class Calculation
{
    public static double Result;
    public static double DoOperation(double num1, double num2, int opt)
    {
        switch (opt)
        {
            case (1):
                Result =num1 + num2;
                break;
            case (2):
                Result = num1 - num2;
                Console.Write($"the Substraction result is {num1 - num2}");
                break;
            case (3):
                Result = num1 * num2;
                Console.Write($"the Multiplicationresult is {num1 * num2}");
                break;
            case (4):
                if (num2 != 0)
                    {
                    Result = num1 / num2;
                }
                else
                {
                    while (num2 == 0)
                    {
                        Console.WriteLine("please Enter a non-zero divisor: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Result = num1 / num2;
                    }

                }
                break;

            default:

                break;
        }
        return Result;
        
    }
    

}

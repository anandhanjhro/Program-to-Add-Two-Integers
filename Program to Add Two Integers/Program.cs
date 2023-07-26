using System;
using System.Collections.Generic;
using System.Text;

namespace Program_to_Add_Two_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numb, numb2, sum;
            Console.WriteLine("Calculate the sum of two numbers");
            Console.Write("Input number1 ");
            numb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number2 ");
            numb2 = Convert.ToInt32(Console.ReadLine());
            sum = numb + numb2;
            Console.Write("Result " + sum);

            Console.ReadLine();
        }
    }
}

using System;
using MyCalc;

namespace HelloApp
{
    class HelloApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calc calc = new Calc();
            Console.WriteLine($"Addition is : {calc.Add(10, 50)}");
            Console.WriteLine($"Multiplication is : {calc.Multiply(10, 50)}");
            Console.ReadLine();
        }
    }
}

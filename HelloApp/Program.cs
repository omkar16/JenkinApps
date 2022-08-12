using System;
using MyCalc;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calc calc = new Calc();
            Console.WriteLine(calc.Add(10, 50));
        }
    }
}

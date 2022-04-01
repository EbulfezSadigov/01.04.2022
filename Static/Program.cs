using Static.Models;
using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum is "+Calculator.Sum(20,30)); 
            Console.WriteLine("Subtract is "+Calculator.Subtract(20,30)); 
            Console.WriteLine("Multiply is "+Calculator.Multiply(20,30)); 
            Console.WriteLine("Divide is "+Calculator.Divide(60,30));

            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Power is "+Calculator.Power(number)); 
        }
    }
}

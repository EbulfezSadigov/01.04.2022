using _31._03._2022.Models;
using System;

namespace _31._03._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(200,100,"dizel",40,"automat","thin");
            car.ShowInfo();
            car.LeftFuelAmount();
            Car car1 = new Car(30, 15);
            Console.WriteLine(car.AverageSpeed());
        }
    }
}

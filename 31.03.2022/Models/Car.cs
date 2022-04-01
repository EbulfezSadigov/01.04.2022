using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._03._2022.Models
{
    class Car:Vehicle,IEngine,ITransmission,IWheel
    {
        public int HorsePower { get; set ; }
        public int TankSize { get; set; }
        public string FuelType { get ; set ; }
        public int CurrentOil { get; set; }
        public string TransmissionKind { get; set ; }
        public string WheelThickness { get ; set; }

        public override int AverageSpeed()
        {
            if (DriveTime>0)
            {
            return DrivePath / DriveTime;

            }

            return 0;
        }
        public Car(int path,int time)
        {
            DrivePath = path;
            DriveTime = time;
        }
        public void LeftFuelAmount()
        {
            Console.WriteLine("Fuel amount left "+(CurrentOil=TankSize-CurrentOil));
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Horse power of car "+HorsePower);
            Console.WriteLine("Tank size of car "+TankSize);
            Console.WriteLine("Fuel type of car "+FuelType);
            Console.WriteLine("Current oil of car "+CurrentOil);
            Console.WriteLine("Transmission kind of car " + TransmissionKind);
            Console.WriteLine("Wheel thickness of car " + WheelThickness);
        }

        public Car(int horsepower,int tanksize,string fueltype,int currentoil,string transmissionkind,string wheelthickness )
        {
            HorsePower = horsepower;
            TankSize = tanksize;
            FuelType = fueltype;
            CurrentOil = currentoil;
            TransmissionKind = transmissionkind;
            WheelThickness = wheelthickness;
        }
    }
}

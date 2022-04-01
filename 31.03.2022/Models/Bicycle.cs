using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._03._2022.Models
{
    class Bicycle : Vehicle, IWheel
    {
        public string WheelThickness { get ; set ; }
        public Bicycle(string wheelthickness)
        {
            WheelThickness = wheelthickness;
        }
        public override int AverageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Wheel thickness is "+WheelThickness);
        }
    }
}

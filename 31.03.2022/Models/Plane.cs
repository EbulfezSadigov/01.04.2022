using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._03._2022.Models
{
    class Plane : Vehicle
    {
        public int WingLength { get; set; }
        public Plane(int winglength)
        {
            WingLength = winglength;
        }
        public override int AverageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Wing length is "+WingLength);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._03._2022.Models
{
    abstract class Vehicle
    {
        private int _driveTime;
        public int DrivePath { get; set; }
        public int DriveTime
        {
            get { return _driveTime; }
            set {
                if (value>0)
                {
                    _driveTime = value;
                }
            }
        }
        public abstract int AverageSpeed();
        public abstract void ShowInfo();


    }
}

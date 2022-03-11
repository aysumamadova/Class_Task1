using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_class.Model2
{
    class Vehicle
    {
        public int cycle;
        public int driveWay;
        public string color;
        public int passengerCount;
        public int driveTime;
        public Vehicle()
        {

        }
        public void GetInfo()
        {
            Console.WriteLine($"Cycle:{cycle} DriveWay:{driveWay} Color:{color} DriveTime:{driveTime} PassengerCount:{passengerCount}");
        }
    }
}

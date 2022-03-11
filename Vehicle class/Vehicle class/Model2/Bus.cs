using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_class.Model2
{
    class Bus:Vehicle
    {
        public double Motor;
        public double Speed;

        public Bus ()
        {

        }
        public Bus(int cycle)
        {
            this.cycle = cycle;
        }
        public Bus(int cycle, int driveWay) : this(cycle)
        {
            this.driveWay = driveWay;
        }
        public Bus(int cycle, int drieWay, string color) : this(cycle, drieWay)
        {
            this.color = color;
        }
        public Bus(int cycle, int drieWay, string color, int driveTime) : this(cycle, drieWay, color)
        {
            this.driveTime = driveTime;
        }
        public Bus(int cycle, int drieWay, string color, int driveTime, int passengerCount) : this(cycle, drieWay, color, driveTime)
        {
            this.passengerCount = passengerCount;
        }
        public Bus(int cycle, int drieWay, string color, int driveTime, int passengerCount, double Motor) : this(cycle, drieWay, color, driveTime, passengerCount)
        {
            this.Motor = Motor;
        }
        public Bus(int cycle, int drieWay, string color, int driveTime, int passengerCount, double Motor, double Speed) : this(cycle, drieWay, color, driveTime, passengerCount, Motor)
        {
            this.Speed = Speed;
        }
        public void GetMotor()
        {
            Console.WriteLine($"Bus motor:{Motor}");
        }

        public void GetSpeed()
        {
            Speed = driveWay / driveTime;
            Console.WriteLine($"Bus speed:{Speed}");
        }
    }
}

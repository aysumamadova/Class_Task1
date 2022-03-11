using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_class.Model2
{
    class Bicycle:Vehicle
    {
        public double Speed;
        public Bicycle()
        {

        }
        public Bicycle (int cycle)
        {
            this.cycle = cycle;
        }
        public Bicycle(int cycle, int driveWay):this(cycle)
        {
            this.driveWay = driveWay;
        }
        public Bicycle(int cycle,int drieWay,string color):this(cycle,drieWay)
        {
            this.color = color;
        }
        public Bicycle(int cycle, int drieWay, string color,int driveTime):this(cycle,drieWay,color)
        {
            this.driveTime = driveTime;
        }
        public Bicycle(int cycle, int drieWay, string color, int driveTime, int passengerCount):this(cycle,drieWay,color,driveTime)
        {
            this.passengerCount = passengerCount;
        }
        public Bicycle(int cycle, int drieWay, string color, int driveTime, int passengerCount, double Speed) : this(cycle, drieWay, color, driveTime, passengerCount)
        {
            this.Speed = Speed;
        }
        public void GetSpeed()
        {
            Speed = driveWay / driveTime;
            Console.WriteLine($"Bicycle speed:{Speed}");
        }
    }
}

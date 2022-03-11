using System;
using Vehicle_class.Model2;

namespace Vehicle_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle bi1 = new Bicycle(2,300,"yellow",10,2);
            Car car1 = new Car(4,500,"red",10,5,3.4);
            Bus bus1 = new Bus(4,1000,"black",100,20,4.5);
            
            Console.WriteLine(("----------------------BICYCLE-------------------"));
            bi1.GetInfo();
            bi1.GetSpeed();

            Console.WriteLine(("------------------------CAR---------------------"));
            car1.GetInfo();
            car1.GetMotor();
            car1.GetSpeed();

            Console.WriteLine(("------------------------BUS-----------------------"));
            bus1.GetInfo();
            bus1.GetMotor();
            bus1.GetSpeed();
        }
    }
}

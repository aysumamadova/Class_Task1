using System;
using class1.model;

namespace class1
{
    class Program
    {
        static void Main(string[] args)
        {
            student stu1 = new student("Aysu","Memmedova",19);
            teacher t1 = new teacher("t","a",20);
            stu1.GetInfo();
        }
    }
}

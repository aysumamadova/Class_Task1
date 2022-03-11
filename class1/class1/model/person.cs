using System;
using System.Collections.Generic;
using System.Text;

namespace class1.model
{
    class person:baba
    {
        public string name;
        public string surname;
        public int age;

        public void Fullname()
        {
            Console.WriteLine($"{name} {surname}");
        }
        
        public void GetInfo()
        {
            Console.WriteLine($"{name} {surname} {age}");
        }
    }
}

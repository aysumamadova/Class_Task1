using System;
using System.Collections.Generic;
using System.Text;

namespace class1.model
{
    class student:person
    {
        public int course;

        public student()
        {
            Console.WriteLine($"{course}");
        }
        public student(string name)
        {
            this.name = name;
        }
        public student(string name,string surname) : this(name)
        {
            this.surname = surname;
        }
        public student(string name, string surname,int age):this(name,surname)
        {
            this.age = age;
        }
       
       
    }
}

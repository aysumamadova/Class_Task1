using System;
using System.Collections.Generic;
using System.Text;

namespace class1.model
{
    class teacher:person
    {
        public int salary;
        public teacher()
        {

        }
        public teacher(string name)
        {
            this.name = name;
        }
        public teacher(string name, string surname) : this(name)
        {
            this.surname = surname;
        }
        public teacher(string name, string surname, int age) : this(name, surname)
        {
            this.age = age;
        }

    }
}

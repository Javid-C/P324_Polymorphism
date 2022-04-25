using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Polymorphism_Abstract
{
    class Student
    {
        public string Name = "Kamran";
        public string Surname;
        byte _point;
        public byte Point
        {
            get => _point;
            //get
            //{
            //    return _point;
            //}
        }
        public byte Age
        {
            set
            {

            }
        }

        private readonly string Password;

        public Student(string name, string surname,string pw="12345")
        {
            Name = name;
            Surname = surname;
            Password = pw;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
            //return "okay";
        }

        public void setPassword()
        {
            Age = 100;
            //Password = "9999";
        }
    }

}

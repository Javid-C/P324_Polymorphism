using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Polymorphism_Abstract
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Polymorphism_Abstract
{
    class Rabbit:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Rabbit makes sound");
        }
    }
}

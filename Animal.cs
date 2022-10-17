using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Lab6_
{//Base Class + properties.
    class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Gender { get; set; }
        public string Sound { get; set; }
        // Virtual method allow subclasses to override method.
        public virtual void MakeSound()
        {
            Console.WriteLine($"{ Name} says {Sound}");
        }
        // Ctor
        public Animal(string name, string type, string color, string gender, string sound)
        {
            Name = name;
            Type = type;
            Color = color;
            Gender = gender;
            Sound = sound;
        }


    }
}

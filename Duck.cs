using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Lab6_
{// Subclass
    class Duck : Animal
    {   // Aditional property.
        public string Wings { get; set; } = "Two.";
        //Overriding base class method.
        public override void MakeSound()
        {

            Console.WriteLine($"\n   ANIMAL  \n***************\n Name = {Name} \n Type = {Type} \n Color = {Color} \n Gender = {Gender} \n Sound = {Sound} \n Wings = {Wings} ");
        }
        public Duck(string name = "Duck", string type = "Bird", string color = "yellow", string gender = "female",
            string sound = "Quaack!!!Quuac!!k")
            : base(name, type, color, gender, sound)
        {
            this.Wings = Wings;
        }

        // Duck subclass      
        class BabyDuck : Duck
        {
            public string Status { get; set; }
            public void IMakeSound()
            {
                Console.WriteLine($"\n Hi, {Status} and i also sound {Sound}. ");
            }
            public BabyDuck(string sound = "Quaack!!!Quaack!!!!", string status = "I am a newborn") : base(sound, status)
            {
                this.Sound = sound;
                this.Status = Status;
            }


        }
    }
}

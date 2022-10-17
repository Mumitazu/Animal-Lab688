using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Lab6_
{
    //Subclass Cat
    class Cat : Animal
    {   //Additional property
        public string Claws { get; set; } = "Long";
        //Base class method override
        public override void MakeSound()
        {

            Console.WriteLine($"\n  Animal  \n *************** \n Name = {Name} \n Type = {Type} \n Color = {Color} \n Gender = {Gender} \n Sound = {Sound} \n Claws = {Claws} ");
        }
        //Ctor.
        public Cat(string name = "Lucy", string type = "Cat", string color = "Black", string gender = "Female",
            string sound = "Meoow!!Meoow!!!")
            : base(name, type, color, gender, sound)
        {
            this.Claws = Claws;
        }
    }
}

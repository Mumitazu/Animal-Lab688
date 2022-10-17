using System;

namespace Animal_Lab6_
{
    class Program
    {   //Mumtaz Mohamud [NET22]
        static void Main(string[] args)
        {
            //Calling method from the ctor.
            Duck Duck = new Duck();
            Duck.MakeSound();
            Cat cat = new Cat();
            cat.MakeSound();
            // Adding new animal.
            Animal kitten = new Cat()
            {
                Name = "Kith",
                Type = "Baby-cat",
                Color = "grey",
                Gender = "Male",
                Sound = "Meooo!!"

            };
            kitten.MakeSound();




        }

    }
}

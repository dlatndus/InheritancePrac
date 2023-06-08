using System;

namespace InheritancePrac
{
    internal class Dog : Animal
    {
        public int Color { get; set; }


        public void Bark()
        {
            Console.WriteLine("왈왈 짖습니다.");
        }

    }
}
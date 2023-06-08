using System;

namespace InheritancePrac
{
    internal class Dog
    {

        public int Age { get; set; }
        public int Color { get; set; }

        public Dog() { 
            this.Age = 0;
        }
        public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }
    }
}
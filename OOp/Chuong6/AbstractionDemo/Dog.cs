using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            System.Console.WriteLine($"Dogs eat rice and meat ");
        }
        public override string ToString()
        {
            return $"The name of dog is {Name}";
        }
    }
}
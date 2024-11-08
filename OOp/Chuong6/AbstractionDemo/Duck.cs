using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public class Duck : Animal
    {
        public override void Eat()
        {
            System.Console.WriteLine("Duck eat fish and shrimps");
        }
        public override string ToString()
        {
            return $"The name of duck is {Name}.";
        }
    }
}
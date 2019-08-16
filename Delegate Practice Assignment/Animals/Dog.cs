using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Practice_Assignment.Animals
{
    class Dog : IAnimal
    {
        public string MakeNoise()
        {
            return "bark";
        }
    }
}

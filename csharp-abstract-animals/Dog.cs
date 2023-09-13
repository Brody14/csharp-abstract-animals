using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }
       
        public override void Call()
        {
            Console.WriteLine("Fa il verso: Bau Bau");
        }

        public override void WhatYouEat()
        {
            Console.WriteLine("Mangia: la carne");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Dolphin : Animal
    {
        public Dolphin(string name) : base(name) { }
        public override void Call()
        {
            Console.WriteLine("Fa il verso:: Fischio");
        }

        public override void WhatYouEat()
        {
            Console.WriteLine("Mangia: pesce");
        }
    }
}

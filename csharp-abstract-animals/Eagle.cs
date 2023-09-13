using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Eagle : Animal
    {
        public Eagle(string name) : base(name) { }
        public override void Call()
        {
            Console.WriteLine("Fa il verso: Stridio");
        }

        public override void WhatYouEat()
        {
            Console.WriteLine("Mangia: piccoli mammiferi");
        }
    }
}

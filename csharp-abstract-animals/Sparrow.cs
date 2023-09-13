using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Sparrow : Animal, IFly
    {
        public Sparrow(string name) : base(name) { }
        public override void Call()
        {
            Console.WriteLine("Fa il verso: Cip Cip");
        }

        public override void WhatYouEat()
        {
            Console.WriteLine("Mangia: semi e frutta!");
        }

        public void Fly()
        {
            Console.WriteLine("Sto volando!");
        }
    }
}

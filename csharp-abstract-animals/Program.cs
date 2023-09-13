namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.
            List<Animal> animals = new List<Animal>();

            Eagle aquila = new("Aquila");
            Dog cane = new("Cane");
            Dolphin delfino = new("Delfino");
            Sparrow passerotto = new("Passerotto");

            animals.Add(aquila);
            animals.Add(cane);
            animals.Add(delfino);
            animals.Add(passerotto);


           foreach(Animal animal in animals)
            {
                Console.WriteLine($"L'animale {animal.GetName()}");
                animal.Call();
                animal.WhatYouEat();
                Console.WriteLine("E poi dorme...");
                animal.Sleep();
            }
        }
    }
}
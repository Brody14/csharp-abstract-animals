using System.Security.Cryptography.X509Certificates;

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



            /*Scrivere un programma avente 2 metodi :
            void FaiVolare(IVolante animale)
            void FaiNuotare(INuotante animale)
            Questi metodi prendono come parametro un animale che può o volare / nuotare e richiamano il corrispondente metodo 
            Vola() / Nuota().
            Scrivere un programma che istanzi animali che volano o nuotano e richiamare i metodi FaiVolare / FaiNuotare 
            passandoglieli come parametro l'animale corretto.*/

            static void LetItFly(IFly animal)
            {
                animal.Fly();
            }

            static void LetItSwim(ISwim animal)
            {
                animal.Swim();
            }

            LetItFly(passerotto);
            LetItFly(aquila);
            LetItSwim(delfino);
        }
    }
}
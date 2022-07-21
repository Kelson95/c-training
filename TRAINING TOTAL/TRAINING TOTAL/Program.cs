using System.Collections;
using System.Collections.Generic;

namespace TRAINING_TOTAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klase kota o metodzie make sound zwracajaca meow i wypiszz to
            //zrob liste kotow  , kot1,kot2,kot3 
            ////przed tym dodaj nowa metode make sound lecz jako parametr przedstawiac nazwe kota .
            ///quest posredni w metodzie make sound bez parametrow uzyj property name .
            // jedna liste kotow i psow i w petli wypisal rezultat metody run dla kazdego elementu tej listy 

            List<Cat> catlist = new List<Cat>();
            //curly bracket {}
            //angle bracket <>
            //square bracket[]
            catlist.Add(new Cat("Mruczek"));
            catlist.Add(new Cat("Buczek"));
            catlist.Add(new Cat("Kruczek"));
            ;
            Console.WriteLine(catlist.Count + "ilosc kotow");

            foreach (var item in catlist)
            {

                Console.WriteLine(item.makesound());
            }

            List<Dog> doglist = new List<Dog>();
            doglist.Add(new Dog("Burek"));////burek reksio skubi
            doglist.Add(new Dog("Reksio"));////burek reksio skubi
            doglist.Add(new Dog("Scooby"));////burek reksio skubi

            List<IAnimal> catanddog = new List<IAnimal>();
            catanddog.Add(new Cat("Mruczek"));
            catanddog.Add(new Cat("Buczek"));
            catanddog.Add(new Cat("Kruczek"));
            catanddog.Add(new Dog("Burek"));
            catanddog.Add(new Dog("Reksio"));
            catanddog.Add(new Dog("Scooby"));

            Console.WriteLine(doglist.Count + " ilosc psow");

            foreach (var item in doglist)
            {
                Console.WriteLine(item.makesound());
            }
            //zbudujmy interace

            foreach (var item in catlist)
            {
                Console.WriteLine(item.run());
            }


            foreach (var item in doglist)
            {
                Console.WriteLine(item.run());
            }
            //polimofrizm 64 and 70line
            //polimorfizm wykorzystuje sie porzez interfacey i klasy abstrakcyjne do klas .
            IAnimal animal;
            animal = new Cat("MagicCat");
            //wywolywanie metody
            animal.run();
            Console.WriteLine(animal.run());

            animal = new Dog("MagicDog");
            animal.run();
            Console.WriteLine(animal.run());



            foreach (var item in catanddog)
            {
                Console.WriteLine("LOOK    "+item.run());
            }



            Console.ReadKey();
        }


    }
}
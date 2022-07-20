using System.Collections.Generic;

namespace Lesson_25__Sorting_colection_list_compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Auto auto1 = new Auto("FIAT", 2013);
            Auto auto2 = new Auto("MERCEDES", 1989);
            Auto auto3 = new Auto("BMW", 1999);
            Auto auto4 = new Auto("FIAT", 2007);
            Auto auto5 = new Auto("SKODA", 2015);
            List<Auto> list = new List<Auto>();

            list.Add(auto1);
            list.Add(auto2);
            list.Add(auto3);
            list.Add(auto4);
            list.Add(auto5);

            list.Sort(new AutoComparer());
          //  list.Sort();

            

            foreach (var item in list)
            {
                Console.WriteLine(item.Year+" - "+item.Model);
            }
            Console.WriteLine("----------------------------");
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item.Year + " - " + item.Model);
            }

        }
    }
    //ctrl + . to generate interface after method IComparer I comparable etc.
    // Eguals zwraca jedna liczbe bool true ,false
    //Compare zwraca 3 liczby , 1 , 0 oraz -1 (dodatnia, 0 i ujemna)
    class AutoComparer : IComparer<Auto>//typ generyczny Auto
    {
        public int Compare(Auto? x, Auto? y)
        {
            {
                
                if (x.Year > y.Year)
                    return 1;
                else if (x.Year == y.Year)
                    return 0;
                else
                    return -1;
            }
        }
    }

    class Auto : IComparable
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public Auto(string Model, int Year)
        {
            this.Model = Model;
            this.Year = Year;

        }
        
     
        public int CompareTo(object? obj)
        {
            var arg = (Auto)obj;
            if (Year < arg.Year)
                return 1;
            else if (Year == arg.Year)
                return 0;
            else
                return -1;
        }
    }
}
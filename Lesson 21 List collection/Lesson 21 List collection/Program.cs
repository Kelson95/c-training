using System.Collections.Generic;

namespace Lesson_21_List_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

        //    List<int> list = new List<int>();
            List<Auto> list = new List<Auto>();
         //   List<Auto> list2 = new List<Auto>();
        //    list2.Add(new Auto("Fiat"));
          //  list2.AddRange(list);
          //  list2.RemoveAt(4);
            list.Add(new Auto("BMW  "));
            list.Add(new Auto("Mercedes"));
            list.Add(new Auto ("Ford"));
           // Console.WriteLine(list[]);
            foreach (Auto item in list)
            {
               
                Console.WriteLine(item.Name);
            }
            //list.Clear();

            Console.ReadKey();
          
        }
        class Auto
        {
            public string Name { get; set; }
            public Auto(string brand)
            {
            Name = brand;
            }
            public void TurnOnEngine()
            {

            }
            public override string ToString()
            {
                return Name;
            }
        }
    }
}
using System.Collections;

namespace Lesson_20_ArrayList_collections_part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //ctrl + . library help
            ArrayList list = new ArrayList(10);
            //[1],[2],[3]
            list.Add(6);
            list.Add("Bartek");
            list.Add(new Auto("BMW"));
        //    Console.WriteLine(list.Count);
            list.RemoveAt(1);

          //  Console.WriteLine(list[1]);// [1] pozition list is BMW
          //  Console.WriteLine(list.Count);
            list.Insert(0, "Ala");
            list.Reverse();
         //   list.Clear();
          //  Console.WriteLine(list.Count);
             Console.WriteLine(list[2].ToString());
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();


        }
        class Auto
        {
            //ctor + tab konstructor tip

            public string Name { get; set; }
            public Auto(string brand)
            {
                Name = brand;
            }
            //override spacja wybierz to string i generuje sie automatycznie , nice option.
            public override string ToString()
            {
                return Name;
            }

        }
    }
}
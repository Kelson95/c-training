namespace Lesson_22_COlection_DIctionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
            //dictionary.Add(5, "Ania");
            //dictionary.Add(2, "Bartek");
            //if(!dictionary.ContainsKey(3))
            //dictionary.Add(3, "Joe");
            //dictionary.Add(4, "Joe");
            //dictionary.Add(10, "Greg");

            dictionary2.Add("Ania", "Ania");
            dictionary2.Add("Bartek", "Bartek");
            if (!dictionary2.ContainsKey("Joe"))
                dictionary2.Add("Joe", "Joe");
          //  dictionary2.Add("Joe", "Joe");
            dictionary2.Add("Greg", "Greg");


            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} : {1}",item.Key ,item.Value );

            }
                Console.ReadKey();
        }
    }
}
namespace Lesson_11_Functions_part1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Add(2, 4, d: 2);
            Add(2, 4, " Imie");
            Add(2, 3);  
            Add(2, 4, 10);
            Console.ReadKey();
        }
        static void Add(int a, int b, string tekst)
        {
            int result = a + b;//+ c + d;
            Console.WriteLine("Wynik Dodawania: " + result + tekst);
        }
        static void Add(int a, int b, int c = 2, int d = 0)

        {
            int result = a + b + c + d;
            Console.WriteLine("Wynik dodawania: " + result);
        }


    }
}
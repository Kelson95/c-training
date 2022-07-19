namespace Lesson_12_Functions_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            
            Add(2, 4);
            Console.WriteLine(Add(2,4));

        }
        int a = 5;
        static string Add(int a, int b)
        {

            int result = a + b;
            if(result >= 10)
            {
                return "Wynik wiekszy od 10";
            }
            else
            {
                return "Wynik mniejszy od 10";
            }

            ;
        }

    }
}
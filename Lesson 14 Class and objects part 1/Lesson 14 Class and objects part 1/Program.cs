namespace Lesson_14_Class_and_objects_part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Czlowiek adi = new Czlowiek();
            Console.WriteLine(adi.imie);
            adi.imie = "Bartek";
            Console.WriteLine(adi.imie);
            Czlowiek adi2 = new Czlowiek();
            Console.WriteLine(adi2.imie);

            adi.PrzedstawSie();
            adi2.PrzedstawSie();
            Console.ReadKey();
        }

    }
   

}
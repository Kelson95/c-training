namespace Lesson_15_constuctors_class_and_objects_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Czlowiek adi = new Czlowiek("Marek " , "Kowalski");
            adi.WhoAreYou();
            Console.WriteLine(adi.surname);
            adi.name = "Bartek ";
            adi.surname = "Zielenski";
            adi.WhoAreYou();
            


            Console.ReadKey();

        }
    }
}
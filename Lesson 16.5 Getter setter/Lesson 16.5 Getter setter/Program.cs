namespace Lesson_16._5_Getter_setter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Czlowiek adi = new Czlowiek();
            adi.name = "Adrian";
            //  adi.age = -20;
            //  adi.setAge(25);
            adi.ageProperty = 20;
            adi.ageProperty = -20;
            adi.ageProperty = 25;



            Console.WriteLine($"Jestem {adi.name} lat {adi.ageProperty} ");
         //   Console.WriteLine(String.Format("Jestem {0} lat {1}", adi.name, adi.GetAge()));
            Console.ReadKey();
        }
    }
}
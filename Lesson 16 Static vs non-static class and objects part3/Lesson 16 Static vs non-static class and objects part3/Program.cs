namespace Lesson_16_Static_vs_non_static_class_and_objects_part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
          
            Console.WriteLine(CzlowiekStatic.liczbaLudnosci);
            CzlowiekStatic.liczbaLudnosci = 10000;
            Console.WriteLine(CzlowiekStatic.liczbaLudnosci);
            Math.Abs(-2);
            Math.Abs(- 5);



            Czlowiek czlowiek = new Czlowiek();
            Console.WriteLine(czlowiek.name);
            czlowiek.name = "Marek";
            Console.WriteLine(czlowiek.name);

            Czlowiek czlowiek2 = new Czlowiek();
            Console.WriteLine(czlowiek2.name);

            Console.WriteLine(Czlowiek.liczbaLudnosci);


            Console.ReadKey();
             
        }
    }
}
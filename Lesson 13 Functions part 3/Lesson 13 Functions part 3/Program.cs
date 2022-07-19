namespace Lesson_13_Functions_part_3
{
    internal class Program
    {
        // 3 sposoby wyslania argumentow 
        // podstawowy porzez cypy int
        //drugi referencja ref 
        //trzeci out 
        static void Main(string[] args)
        {

            //  int a ;
            int[] tab = new int[2];
            tab[0] = 5;
            tab[1] = 2;

            //   Console.WriteLine("Przed :" + a);
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Po :" + tab[0] + " , " + tab[1]);

            // Test(out a);
            Test(ref tab);
            Console.WriteLine("Po :" + tab[0] + " , " + tab[1]);
            Console.ReadKey();
        }

        //static void Test(ref int b)
        //{
        //    b += 5;
        //    Console.WriteLine(" W funcji :" + b);
        //}

        // static void Test(out int b)
        static void Test(ref int[] tab)
        {
            //  b = 5;
            //   b += 5;
            // tab[0] = 555;
            // tab[1] = 222;
            tab = new int[2];
            tab[0] = -5;
            tab[1] = -2;
            Console.WriteLine(" W funcji :" + tab[0] + " , " + tab[1]);
        }
    }
}
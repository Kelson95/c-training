namespace Lesson_31_Enum
{

    enum Seasons : sbyte// typ wyliczeniowy
    {
        Spring = 15, Summer = 25, Autumn = 15,Winter = -10 // convert to string itself
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //string Season = "Spring";
            //string Season2 = "Summer";

            Seasons Season = Seasons.Winter;
            Console.WriteLine(Seasons.Winter);
            Console.WriteLine((int)Season);
            Seasons Season2 = (Seasons)25;
            Console.WriteLine(Season2);

        }
    }
}
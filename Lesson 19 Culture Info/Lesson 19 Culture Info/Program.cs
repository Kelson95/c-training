using System.Globalization;
namespace Lesson_19_Culture_Info
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Hello, World!");
            var c = CultureInfo.GetCultures(CultureTypes.AllCultures);
            //foreach (var item in c)
            //{
            //    Console.Write(item.Name);
            //    Console.WriteLine(item.NumberFormat.NumberDecimalSeparator);
            //}
            Console.WriteLine(CultureInfo.CurrentCulture.Name);
            //     CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator = ":"; //only for read
            var newCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();// rzutowanie co to ?
            newCulture.NumberFormat.NumberDecimalSeparator = ":";
            newCulture.NumberFormat.NegativeSign = "MINUS ";
            CultureInfo.CurrentCulture = newCulture;

            int a = -5;
            float b = 3.14f;
            Console.WriteLine($"{a}\n{b}");

            Console.WriteLine(" Pierwsza liczba " + a+"\n" +" Druga liczba "+  b);

            Console.ReadKey();

        }
    }
}
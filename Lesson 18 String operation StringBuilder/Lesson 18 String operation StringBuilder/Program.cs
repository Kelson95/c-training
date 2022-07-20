using System.Diagnostics;
using System.Text;

namespace Lesson_18_String_operation_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //'ctrl' + '.' dodawanie biblioteki 



            Console.WriteLine("Hello, World!");
            Stopwatch stopwatch = new Stopwatch();
            int ile = 30000;
            stopwatch.Start();
            BuildString(ile);
            // Console.WriteLine(BuildString(ile));
            stopwatch.Stop();
            Console.WriteLine("Standard method build strings : {0} ms", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            BuildStringBuilder(ile);
            //  Console.WriteLine(BuildStringBuilder(ile));
            stopwatch.Stop();
            Console.WriteLine("Standard method build strings builder : {0}ms", stopwatch.ElapsedMilliseconds);


            Console.ReadKey();
        }
        /// <summary>
        /// Method building string 
        /// </summary>
        /// <param name="ile">Give lenght of loop</param>
        /// <returns>Returning ready text</returns>

        public static string BuildString(int ile)
        {
            string tekst = "";
            for (int i = 0; i < ile; i++)
            {
                tekst += i;
            }
            return tekst;
        }
        public static string BuildStringBuilder(int ile)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < ile; i++)
            {
                stringBuilder.Append(i);
            }
            return stringBuilder.ToString();
        }
    }
}
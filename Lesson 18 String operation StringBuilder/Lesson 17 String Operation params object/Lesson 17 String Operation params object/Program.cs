namespace Lesson_17_String_Operation_params_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(GenerateText("My name is #0 and and I'm #1 years old", "Adam", 22));
            

            Console.ReadKey();
        }
        //object obj = 1;
        //object ojb2 = "Tekst";
        public static string GenerateText( string text, params object[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                text = text.Replace("#" + i, args[i].ToString());
            }
        return text;
        }

    }
}
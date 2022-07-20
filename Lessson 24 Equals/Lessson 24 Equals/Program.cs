namespace Lessson_24_Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Auto auto1 = new Auto("FIAT ", 1999);
            Auto auto2 = new Auto("FIAT ", 1999);
            string a = "BMW";
            auto2.Model = "BMW";
            //    Console.WriteLine(auto1 == auto2); equal referencies only true auto1 == auto1
            Console.WriteLine(auto1.Equals(auto2));   // false equals niskie dziedziczenie ,definiowanie equals wedle potrzeby
            
            Console.ReadKey();
        }

    }
    class Auto
    {

        private string Model { get; set; }
        public int Year { get; set; } 
        public Auto(string Model, int Year)
        {
            this.Model = Model;
                this.Year = Year;       
        }
        public Auto (string Model)
        {
            this.Model = Model;
        }

        public bool Equals(Auto auto)
        {
            return auto.Model == this.Model && auto.Year == this.Year;


        }

    }
}
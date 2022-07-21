namespace Lesson_27_Inheritance_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Character p1 = new Character("Dwarf", 200);
            Mage m1 = new Mage("Elf", 150, 300);
            Console.WriteLine(p1.name +" "+ p1.HealthPoints);
            Console.WriteLine(m1.name + " "+ m1.HealthPoints + " " + m1.mana);
            Console.ReadKey();
        }
    }
    class Character
    {
        //ctor + tab tab  utworzeniekonstruktora .
        //public Character()
        //{

        //}
        public Character(string name, int HealthPoints)
        {
            this.name = name;
            this.HealthPoints = HealthPoints;
        }
        public string name;
        public int HealthPoints;

    }
    class Mage : Character
    {
        public Mage(string name,int HealthPoints, int mana) /*:base(name,HealthPoints)*/ :base("Elf" , 150)
            //base metoda by zdobyc zmienne dziedziczone po wypisaniu 
        {
            this.mana = mana;
        }
       public int mana;
    }
}
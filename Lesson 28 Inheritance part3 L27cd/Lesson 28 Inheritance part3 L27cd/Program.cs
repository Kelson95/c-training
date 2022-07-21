namespace Lesson_28_Inheritance_part3_L27cd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Mage m1 = new Mage("Elf", 150, 300);

            m1.Movement();
            Console.WriteLine(m1.name + " " + m1.HealthPoints + " " + m1.mana);

            Console.ReadKey();

        }
    }
    abstract class Character
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
        public abstract void Movement();
        //{
        //    Console.WriteLine("Character Movement");
        //}
        public string name;
        public int HealthPoints;

    }
    // po sealed nie mozna dziedziczyc
    sealed class Mage : Character
    {
        public Mage(string name, int HealthPoints, int mana) /*:base(name,HealthPoints)*/ : base("Elf", 150)
        //base metoda by zdobyc zmienne dziedziczone po wypisaniu 
        {
            this.mana = mana;
        }
        public int mana;

        public override void Movement()
        {
            Console.WriteLine("Mage Movement");
            // base(Movement()); zapytac aleksa  czemu w apbstractyjnej nie mozna .
        }
        //public override void Movement()
        //{

        //    Console.WriteLine("Mage Movement");
        // //   base.Movement();
        //}

    }
    //class SuperMage : Mage
    //{

    //}
}
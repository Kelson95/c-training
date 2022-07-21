namespace Lesson_29_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Character p1 = new Character("Elf", 200);
            IMagicAttack attack = (IMagicAttack)p1;
            attack.Attack(25);
            IPhysicalAttack attack2 = (IPhysicalAttack)p1;
            attack2.Attack(50);
            Console.ReadKey();
        }

        interface IMagicAttack
        {
            void Attack(int pkt); 
        }
        interface IPhysicalAttack
        {
            void Attack(int pkt);
        }

        class Character : IMagicAttack,IPhysicalAttack
        {
            public Character(string name, int HealthPoints)
            {
                this.name = name;
                this.HealthPoints = HealthPoints;
            }
            public string name;
            public int HealthPoints;

            void IMagicAttack.Attack(int pkt)
            {
                Console.WriteLine("Imagic attack");            }

            void IPhysicalAttack.Attack(int pkt)
            {
                Console.WriteLine("Iattack phycical");            }
        }
    }
}
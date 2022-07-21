namespace Lesson_26__inheritance_part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Earth earth = new Earth();
              earth.Atmosphere();
            earth.TimeOfDayAndNight();
            earth.RotatyMovement();
            
            

            //   CelestialBody celestialBody = new CelestialBody(); 
            // celestialBody.Name = "Sun";
            //Console.WriteLine(celestialBody.Name);

            // nie mozemy utworzyc nowego obiektu klasy jesli jest abstrakcyjna lub interfejsem



            Console.ReadKey();
        }

    }
   abstract class CelestialBody
    {
        public string Name { get; set; }

        public void RotatyMovement()
        {
            Console.WriteLine("Every Celestial Body have Rotary Movement");
        }
    }
    abstract class Planet : CelestialBody
    {
       public void TimeOfDayAndNight()
        {
            Console.WriteLine("Time of day and night");
        }
    }
    class Earth : Planet
    {
       public void Atmosphere()
        {
            Console.WriteLine("Earth Atmosphere ");

        }

    }
    class Mars : Planet
    {
        public void Atmosphere()
        {
            Console.WriteLine("Mars Atmosphere");

        }
    }
}
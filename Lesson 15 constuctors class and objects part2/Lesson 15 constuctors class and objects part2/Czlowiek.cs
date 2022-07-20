using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15_constuctors_class_and_objects_part2
{
    internal class Czlowiek
    {
        //public Czlowiek()
        //{

        //}
        //public Czlowiek(string nameConstructor)
        //{
        //    name = nameConstructor;
        //}
        public Czlowiek(string nameConstructor , string surnameConstructor)
        {
            name = nameConstructor;
            surname = surnameConstructor;

        }
        public string name = "Brak";
        public string surname = "Brak";

        public void WhoAreYou()
        {
            Console.WriteLine("My name is " + name + surname );
        }
        ~Czlowiek()
        {
            Console.WriteLine("Jestem destructorem");
            System.Diagnostics.Trace.WriteLine("Jestem destruktorem");
        }

    }
}

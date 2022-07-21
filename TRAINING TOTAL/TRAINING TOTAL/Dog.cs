using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINING_TOTAL
{
    internal class Dog :IAnimal
    {
        public string makesound()
        {
            return name+" goes whoow";
        }

        public string run()
        {
            return "Dog " + name + " run";
        }

        public string name { get; set; }
        public Dog(string d)
        {
            name = d;

        }

    }
}

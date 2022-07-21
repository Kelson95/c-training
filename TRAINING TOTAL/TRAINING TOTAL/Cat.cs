using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINING_TOTAL
{
    //klase kota o metodzie make sound zwracajaca meow i wypiszz to
    ////przed tym dodaj nowa metode make sound lecz jako parametr przedstawiac nazwe kota .
    ///quest posredni w metodzie make sound bez parametrow uzyj property name .
    internal class Cat : IAnimal
    {

        public string makesound()
        {

            return name+ " goes meow";
        }
        public string makesound(string c)
        {

            return c + " Goes Meow";
        }

        public string run()
        {
            return "Cat " + name + " run";
        }

        public Cat(string k)
        {
            name =  k;
        }
        public string name { get; set; }


    }

}
    


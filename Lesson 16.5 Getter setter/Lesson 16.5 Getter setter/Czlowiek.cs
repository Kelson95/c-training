using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16._5_Getter_setter
{
    internal class Czlowiek
    {
       public string name;
         private int age;

        // //prop tab tab
        // public int MyProperty { get; set; }
        //public int age { get; set; }

        // ////propfull tab tab//
     
        // private int myVar;
        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        //private int myVar;

        public int ageProperty
        {
            get { return age; }
            set
            { 
                if(value >= 0 && value <= 200)
                age = value;
                else
                {
                    age = 0;
                }
            }
        }


        //public int GetAge()
        // {
        //     return age;
        // }

        // public void setAge(int w)
        // {
        //     if(w >= 0 && w<)
        //     age = w;
        // }

    }
}

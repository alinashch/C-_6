using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entity
{
    public abstract class Car : Vehicle
    {
        public int maxspeed { get; set; }
        public string color { get; set; }

        public string name { get; set; }

        public string Start()
        {
            string s= name +" speed " + maxspeed;
            return s;
        }

        public string Stop()
        {
            string s = name + " stop ";
            return s;
        }



        public abstract bool freight();
        public abstract string information();
        
    }
}

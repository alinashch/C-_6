using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entity
{
    internal class SportCar :Car
    {
        public int wins { get; set; }
        public string city { get; set; }

        public override bool freight()
        {

            return false;
        }

        public override string information()
        {
            string s = "wins " + wins + " city " + city;
            return s;
        }
        public string addOneWin()
        {
            wins++;
            return "new num of win " + wins;
        }

        public string addLose()
        {
            wins--;
            return "new num of win " + wins;
        }
    }

    


}

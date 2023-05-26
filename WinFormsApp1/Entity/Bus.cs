using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entity
{
    internal class Bus : Car
    {

        public int capacity { get; set; }    
        public int ticketPrice { get; set; }

        public override bool freight()
        {

            return false;
        }

        public override string information()
        {
            string s = "capacity "+ capacity + " final Station "+ ticketPrice;
            return s;
        }

        public string correctPrice(int s)
        {
            ticketPrice = s;
            return "set price " + s; 
        }

        public int getsum()
        {
            return ticketPrice*capacity;
        }

    }
}

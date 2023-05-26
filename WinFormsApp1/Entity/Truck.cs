using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entity
{
    internal class Truck : Car
    {

        public string number { get; set; }

        public string date { get; set; }

        public override bool freight()
        {

            return true;
        }

        public override string information()
        {
            string s= number + " "+ date ;
            return s;
        }

        public string getCity()
        {
            string s ="city "+  number.Substring(number.Length -2);
            return s;
        }

        public string getYear()
        {
            string s ="year "+ date.Substring(date.Length -4);
            return s;
        }
    }
}

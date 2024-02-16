using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_ship_
{
    internal class Ship
    {
        public string serialnumber;
        public int degree;
        public float minute;
        public string direction;

        public Ship(string serialnumber)
        {
            this.serialnumber = serialnumber;
        }

            //this.degree = degree;
            //this.minute = minute;
            //this.direction = direction;
    }
}

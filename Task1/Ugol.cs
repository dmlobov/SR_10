using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Ugol
    {
       int gradus;
       int minute;
       int second;
        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                gradus = value % 360;
            }
        }
        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                Gradus += value / 60;
                minute = value % 60;
            }
        }
        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                Minute += value / 60;
                second = value % 60;
            }
        }
        public Ugol(int gradus, int minute, int second)
        {
            this.Gradus = gradus;
            this.Minute = minute;
            this.Second = second;
        }


        public double ToRadians()
        {
            return ((((double)second) / 3600 + ((double)minute) / 60 + gradus) / 180) * Math.PI;
        }
    }
}

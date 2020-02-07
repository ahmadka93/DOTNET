using System;
using System.Collections.Generic;
using System.Text;

namespace BusAr
{
    public class BusArrival
    {
        private Time time;
        private int busline, passenegers;
        public BusArrival(int busline,int hour,int second,int minute,int passenegers)
        {
            BusLine = busline;
            Passenger = passenegers;
     
        
        }
        public BusArrival(int busline,Time time,int passenegers)
        {
            BusLine = busline;
            Passenger = passenegers;
            this.time = time;
        }
        public BusArrival(BusArrival other):this(other.passenegers, other.time,other.busline)
        {

        }
        public int BusLine
        {
            get
            {
                return busline;
            }
            set
            {
                if (value == null || value < 0 && value > 90)
                    return;
                busline = value;
            }
        }
        public int Passenger
        {
            get
            {
                return passenegers;
            }
            set
            {
                if (value == null || value < 0 || value > 50)
                    return;
                passenegers = value;
            }
        }
        public string ToString()
        {
            return "BusLine{" + BusLine + "}" + "  Passenger{" + Passenger + "}"   +   time.ToString();
        }
        public bool Eqaul(BusArrival other)
        {
            if (other == null)
                return false;
            if (this == other)
                return true;
            return this.BusLine == other.BusLine && this.Passenger == other.Passenger && this.time.Equals(other.time);


        }
        public bool Before(BusArrival other)
        {
            return time.Before(other.time);
        }
        public bool Fuller(BusArrival other)
        {

            if (other.Passenger < 50)
                return false;
            return true;

        }



       
        public static BusArrival Pass10(BusArrival[] other)
        {
            int max = 0;
            for (int i = 0; i < other.Length; i++)
            {
                if (other[i].Passenger >= 10 && other[i].Before(other[i + 1]))
                {
                    max = i;
                }
            }
            return other[max];

        }

        public int ellapsedMinutes(BusArrival other)
        {
            return this.time.Difference(other.time) / 60;
        }
        public void Print()
        {
            
            {

            }
        }

    }
}

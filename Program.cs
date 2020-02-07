using System;

namespace BusAr
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time0 = new Time(1, 22, 22);
            Time time1 = new Time(4, 22, 22);
            Time time2 = new Time(6, 22, 22);
            Time time3 = new Time(6, 46, 22);
            Time time4 = new Time(5, 22, 22);
            BusArrival busArrival0 = new BusArrival(1, time0, 22);
            BusArrival busArrival1 = new BusArrival(1, time1, 22);
            BusArrival busArrival2 = new BusArrival(1, time0, 22);
            BusArrival busArrival3 = new BusArrival(3, time4, 50);
            BusArrival busArrivalfull = new BusArrival(12, time2, 50);

            Console.WriteLine(busArrival0.ToString());
            Console.WriteLine(busArrival1.ToString());
            Console.WriteLine(busArrival2.ToString());
            Console.WriteLine(busArrival3.ToString());
            Console.WriteLine(busArrivalfull.ToString());

            

            Console.WriteLine("Bus0 ==Bus2 "+busArrival0.Eqaul(busArrival2));
            Console.WriteLine("Bus0 ==Bus1 " + busArrival0.Eqaul(busArrival1));
            Console.WriteLine("----------Befor");
            Console.WriteLine("Bus0 >Bus1 " + busArrival0.Eqaul(busArrival1));
            Console.WriteLine("Bus1<bus4 " + busArrival0.Eqaul(busArrival2));



            Console.ReadLine();
        }
     
        

    }
}

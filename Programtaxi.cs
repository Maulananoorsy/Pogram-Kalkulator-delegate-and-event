using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            taxi taxi = new taxi();

            taxi.DriverName = "Joooonnnnoooo";
            taxi.OnDuty = true;
            taxi.Numpassanger = 10;

            taxi.info();
            taxi.Pickuppassanger();
            taxi.Dropoffpassanger();

            Console.ReadKey();


        }
    }
}

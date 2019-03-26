using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTaxi
{
    class taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int Numpassanger { get; set; }

        public void info()
        {
            Console.WriteLine("Nama pengemudi : {0} ", DriverName);
            Console.WriteLine("On Duty : {0} ", OnDuty);
            Console.WriteLine("Number Of Passanger : {0} ", Numpassanger);
        }
        public void Pickuppassanger()
        {
            if (OnDuty == true)
            {
                Console.WriteLine("{0} sedang Menjememput penumpang", DriverName);
            }
            else
            {
                Console.WriteLine("{0} Tidak sedang menjemput penumpang", DriverName);
            }
        }

        public void Dropoffpassanger()
        {
            if (OnDuty == true)
            {
                Console.WriteLine("{0} Selesai mengantar penumpang", DriverName);
            }
            else
            {
                Console.WriteLine("{0} Belum menerima penumpang", DriverName);

            }

        }
    }
}

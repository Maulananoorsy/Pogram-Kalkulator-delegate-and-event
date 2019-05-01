using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2272
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan krysatu = new Karyawan();

            krysatu.Nik = "123456";
            krysatu.Nama = "Andre";
            krysatu.GajiBulanan = 1000000;

            Karyawan krydua = new Karyawan();

            krydua.Nik = "654321";
            krydua.Nama = "Adi";
            krydua.GajiBulanan = 500000;

            Console.WriteLine("No. \tNIK/nama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", krysatu.Nik, krysatu.Nama, krysatu.GajiBulanan);
            Console.WriteLine("1. \t{0} {1}\t\t{2}", krydua.Nik, krydua.Nama, krydua.GajiBulanan);
            Console.WriteLine("\n\n");
            Console.WriteLine("Aseeekkkk kenaikan gaji 10% !!");
            Console.WriteLine("\n");
            Console.WriteLine("No. \tNIK/nama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", krysatu.Nik, krysatu.Nama, krysatu.GajiBulanan + (krysatu.GajiBulanan * 0.10));
            Console.WriteLine("1. \t{0} {1}\t\t{2}", krydua.Nik, krydua.Nama, krydua.GajiBulanan + (krysatu.GajiBulanan * 0.10));
            Console.ReadKey();
        }

    }
}

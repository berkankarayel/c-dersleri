using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Araba sınıfından bir nesne oluşturuyoruz
            Araba araba1 = new Araba();

            // Araba özelliklerini atıyoruz
            araba1.marka = "Toyota";
            araba1.model = "Corolla";
            araba1.yil = 2020;
            // Arabanın bilgilerini yazdırıyoruz
            araba1.BilgileriGoster();
            // Araba hareket ediyor
            araba1.HareketeGec();

        }
    }
}

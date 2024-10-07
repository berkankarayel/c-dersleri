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

            // ************** Parametresiz yapıcı metot**************

            // Parametresiz yapıcı metot ile nesne oluşturuluyor
            Araba araba2 = new Araba();
            araba2.BilgileriYazdir();  // Çıktı: Araba: Bilinmiyor Bilinmiyor, 2000


            // **********Yapıcı Metotlar**********
            // Yapıcı Metotların Özellikleri:

            //Sınıfın adı ile aynı isme sahip olmalıdır(örneğin, sınıfın adı Araba ise yapıcı metodun adı da Araba olmalıdır).
            //Geriye değer döndürmezler, bu yüzden void anahtar kelimesi kullanılmaz.
            //Parametreli veya parametresiz olabilirler.
            //Otomatik olarak çalıştırılırlar ve kullanıcı tarafından çağrılmazlar.



            // Parametreli yapıcı metot ile nesne oluşturuluyor
            Araba araba3 = new Araba("Toyota", "Corolla", 2022);
            araba3.BilgileriYazdir();  // Çıktı: Araba: Toyota Corolla, 2022

            Araba araba4 = new Araba("Ford", "Mustang", 2021);
            araba4.BilgileriYazdir();  // Çıktı: Araba: Ford Mustang, 2021

        }
    }
}

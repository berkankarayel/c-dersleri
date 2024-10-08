using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Yeni bir öğrenci oluşturuyoruz (yapıcı metot ile)
            Ogrenci ogrenci1 = new Ogrenci(12345, "Ahmet", "Yılmaz", 70, 80, 90, "XYZ Üniversitesi");

            bool devamEdiyor = true;

            while (devamEdiyor)
            {
                // Menü yazdır
                Console.WriteLine("\nÖğrenci Sistemi:");
                Console.WriteLine("1 - Öğrenci Bilgilerini Göster");
                Console.WriteLine("2 - Öğrenci Ortalamasını Göster");
                Console.WriteLine("3 - Öğrencinin Okulunu Öğren");
                Console.WriteLine("4 - Çıkış Yap");
                Console.Write("Seçiminizi yapın: ");

                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        ogrenci1.OgrenciBilgileriniGoster();
                        break;
                    case 2:
                        ogrenci1.OgrenciOrtalamaBul();
                        break;
                    case 3:
                        ogrenci1.OkulGetir();
                        break;
                    case 4:
                        Console.WriteLine("Çıkış yapılıyor...");
                        devamEdiyor = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen 1-4 arası bir seçim yapın.");
                        break;
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program


    {


        // Öğrenci bilgilerini tutacak değişkenler
        static string ogrenciAd;
        static string ogrenciSoyad;
        static int[] notlar = new int[3]; // 3 sınav notu için dizi

        static void Main(string[] args)
        {

            // 1)  Geriye Değer Döndürmeyen ve Parametre Almayan Metotlar
            /*eriye değer döndürmeyen metotlar, bir işlem yapar fakat herhangi bir sonuç döndürmez. 
             * Bu tür metotlar, void anahtar sözcüğü ile tanımlanır.
             * Parametre almayan metotlar ise, metot çalışırken dışarıdan herhangi bir veri almaz.
             * Bu tür metotlar, parantez içinde herhangi bir parametre tanımlamaz.
             */

            // Metodu çağırıyoruz
            SelamVer();
            Bilgilendirme();
            CizgiCiz();
            // Metodu çağırıp parametre gönderiyoruz
            Topla(5, 10); // 5 ve 10 sayıları parametre olarak gönderildi
            Bilgilendirme("Ali", 25);
            int sonuc1 = Topla1(5, 7);
            Console.WriteLine($"Toplam: {sonuc1}");
            // Metodu çağırıp sonucu kontrol ediyoruz

            bool sonuc = CiftMi(8);
            if (sonuc)
            {
                Console.WriteLine("Sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı tektir.");
            }


            // Ana menüyü ekrana yazdıran metot
            MenuYazdir();

            // Kullanıcı seçim yapıyor
            int secim = Convert.ToInt32(Console.ReadLine());

            // Seçime göre işlemler yapılıyor
            switch (secim)
            {
                case 1:
                    // Öğrenci bilgilerini alıyoruz
                    OgrenciBilgileriniAl();
                    break;
                case 2:
                    // Öğrenci notlarını alıyoruz
                    OgrenciNotlariniAl();
                    break;
                case 3:
                    // Not ortalamasını hesaplayıp sonucu yazdırıyoruz
                    double ortalama = NotOrtalamasiHesapla();
                    Console.WriteLine($"Öğrenci Not Ortalaması: {ortalama}");
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }





        }




        static void SelamVer()
        {
            Console.WriteLine("Merhaba! Bu metot geriye değer döndürmüyor ve parametre almıyor.");
        }

        // Bilgilendirme mesajı yazdıran metot
        static void Bilgilendirme()
        {
            Console.WriteLine("Bu bir bilgilendirme mesajıdır.");
        }

        // Çizgi çizen metot
        static void CizgiCiz()
        {
            Console.WriteLine("*************************");
        }
        static void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine($"Toplam: {toplam}");


        }

        // Birden fazla parametre alan, geriye değer döndürmeyen metot
        static void Bilgilendirme(string isim, int yas)
        {
            Console.WriteLine($"Merhaba, {isim}! {yas} yaşındasın.");
        }


        // Geriye int değeri döndüren metot
        static int Topla1(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam; // Sonucu geri döndürür
        }

        // Geriye bool döndüren metot
        //static bool CiftMi(int sayi)
        //{
        //    return sayi % 2 == 0; // Sayı çiftse true, değilse false döner
        //}




        // **************************Örnek ********************************

        //Parametre almayan ve geriye değer döndürmeyen bir metot ile ana menüyü ekrana yazdıralım.
        //Parametre alan, geriye değer döndürmeyen bir metot ile öğrencinin bilgilerini kullanıcıdan alalım.
        //Geriye değer döndüren bir metot ile öğrencinin not ortalamasını hesaplayalım ve sonucu geri döndürelim.



        static void MenuYazdir()
        {
            Console.WriteLine("Öğrenci Yönetim Sistemi");
            Console.WriteLine("1 - Öğrenci Bilgilerini Gir");
            Console.WriteLine("2 - Öğrenci Notlarını Gir");
            Console.WriteLine("3 - Not Ortalamasını Hesapla");
            Console.WriteLine("Seçiminizi yapın:");
        }
        static void OgrenciBilgileriniAl()
        {
            Console.Write("Öğrenci Adı: ");
            ogrenciAd = Console.ReadLine();
            Console.Write("Öğrenci Soyadı: ");
            ogrenciSoyad = Console.ReadLine();
            Console.WriteLine("Öğrenci bilgileri kaydedildi.");
        }
        // 2. Parametre alan ve geriye değer döndürmeyen metot: Öğrenci notlarını al
        static void OgrenciNotlariniAl()
        {
            for (int i = 0; i < notlar.Length; i++)
            {
                Console.Write($"{i + 1}. Sınav Notunu Girin: ");
                notlar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Notlar kaydedildi.");
        }

        static double NotOrtalamasiHesapla()
        {
            int toplam = 0;
            for (int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
            }
            double ortalama = toplam / 3.0; // 3 sınavın ortalaması
            return ortalama; // Ortalamayı geri döndür
        }





    }
}

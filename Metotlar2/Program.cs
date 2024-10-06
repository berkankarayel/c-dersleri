using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar2
{
    internal class Program
    {

        // öğrenci bilgilerini tutacak değişkenelr her taraftan erişecleği için burda tutulur 

        static string ogrenciAd;
        static string ogrenciSoyad;
        static int[] notlar = new int[3]; // 3 sınav notu için dizi

        static void Main(string[] args)
        {

            bool programDevamEdiyor = true;

            while (programDevamEdiyor)
            {
                // Ana menüyü ekrana yazdıran metot
                MenuYazdir();

                // Kullanıcı seçim yapıyor
                string giris = Console.ReadLine();
                int secim;

                // Girilen değerin sayıya çevrilebilir olup olmadığını kontrol ediyoruz
                if (int.TryParse(giris, out secim))
                {
                    switch (secim)
                    {
                        case 1:
                            // Kullanıcıdan öğrenci bilgilerini al
                            Console.Write("Öğrenci Adı: ");
                            string isim = Console.ReadLine(); // Kullanıcıdan isim al
                            Console.Write("Öğrenci Soyadı: ");
                            string soyisim = Console.ReadLine(); // Kullanıcıdan soyisim al

                            // Öğrenci bilgilerini alıyoruz
                            OgrenciBilgileriniAl(isim, soyisim);
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
                        case 4:
                            // Programdan çıkış yapılıyor
                            Console.WriteLine("Programdan çıkılıyor.");
                            programDevamEdiyor = false;
                            break;
                        default:
                            Console.WriteLine("Geçersiz seçim, lütfen 1 ile 4 arasında bir seçim yapın.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş, lütfen bir sayı girin.");
                }
            }


        }

        // 1.) Parametre almayan ve geriye değer döndürmeyen metot: Menü 
        static void MenuYazdir()
        {
            Console.WriteLine("\nÖğrenci Yönetim Sistemi");
            Console.WriteLine("1- Öğrenci Bilgilerini Gir ");
            Console.WriteLine("2- Öğrenci Notlarını Gir");
            Console.WriteLine("3 - Not Ortalamasını Hesapla");
            Console.WriteLine("4 - Çıkış");
            Console.WriteLine("Seçiminizi yapın:");
        }

        // 2. Parametre alan ve geriye değer döndürmeyen metot: Öğrenci bilgilerini al

        static void OgrenciBilgileriniAl(string isim,string soyisim)
        {
            ogrenciAd = isim;    // Parametre olarak alınan isim değeri, statik değişken ogrenciAd'a atanır
            ogrenciSoyad = soyisim; // Parametre olarak alınan soyisim değeri, statik değişken ogrenciSoyad'a atanır
            Console.WriteLine("Öğrenci bilgileri kaydedildi: {0} {1}", ogrenciAd, ogrenciSoyad);
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

        // 3. Geriye değer döndüren metot: Not ortalamasını hesapla
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


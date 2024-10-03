using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 5000; // Bakiye değişkeni döngü dışında tanımlanıyor

            while (true)
            {
                Console.WriteLine("ATM'ye hoş geldinizz");
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                Console.WriteLine("1. Bakiye görüntüleme");
                Console.WriteLine("2. Para çekme");
                Console.WriteLine("3. Para yatırma");
                Console.WriteLine("4. Çıkış");

                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Console.WriteLine("Şu anki bakiyeniz: " + bakiye);
                }
                else if (secim == "2")
                {
                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz:");
                    int cekilenMoney = Convert.ToInt32(Console.ReadLine());

                    if (cekilenMoney > bakiye)
                    {
                        Console.WriteLine("Bakiyeniz yetersiz.");
                    }
                    else
                    {
                        bakiye -= cekilenMoney; // Bakiye güncelleniyor
                        Console.WriteLine("Çekilen tutar: " + cekilenMoney);
                        Console.WriteLine("Kalan bakiye: " + bakiye);
                    }
                }
                else if (secim == "3")
                {
                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz:");
                    int yatirilacakMoney = Convert.ToInt32(Console.ReadLine());
                    bakiye += yatirilacakMoney; // Bakiye güncelleniyor
                    Console.WriteLine("Yatırılan para: " + yatirilacakMoney);
                    Console.WriteLine("Güncel bakiye: " + bakiye);
                }
                else if (secim == "4")
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    break; // Döngü sonlanıyor
                }

                // Her işlem sonrası devam etmek için 'c' tuşuna basılması isteniyor
                Console.WriteLine("İşleme devam etmek için 'c' tuşuna basın.");
                while (Console.ReadKey(true).KeyChar != 'c')
                {
                    Console.WriteLine("Yanlış tuş. Devam etmek için 'c' tuşuna basın.");
                }

                Console.WriteLine(); // Yeni satıra geçiş
            }



            // ************************Örnek2***********************


            Random random = new Random();
            int rastgeleSayi = random.Next(1, 100); // 1 ile 99 arasında rastgele sayı
            int altSinir = 1;
            int ustSinir = 99;
            int tahmin;
            int adimSayisi = 0;

            Console.WriteLine("1 ile 99 arasında bir sayı tahmin edin!");

            while (true)
            {
                tahmin = (altSinir + ustSinir) / 2; // Her seferinde aradaki orta değeri tahmin et
                adimSayisi++;

                Console.WriteLine("Tahmininiz: " + tahmin);

                if (tahmin < rastgeleSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı seçin.");
                    altSinir = tahmin + 1; // Alt sınırı güncelle
                }
                else if (tahmin > rastgeleSayi)
                {
                    Console.WriteLine("Daha küçük bir sayı seçin.");
                    ustSinir = tahmin - 1; // Üst sınırı güncelle
                }
                else
                {
                    Console.WriteLine("Tebrikler! Doğru tahmin.");
                    Console.WriteLine("Tahmin sayısı: " + adimSayisi);
                    break;
                }


                //************************ Örnek 3 *********************

                Console.WriteLine("Birinci sayıyı giriniz:");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz:");
double sayi2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: +, -, *, /");
char islem = Convert.ToChar(Console.ReadLine());

if (islem == '+') {
    Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
} else if (islem == '-') {
    Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
} else if (islem == '*') {
    Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
} else if (islem == '/') {
    if (sayi2 != 0) {
        Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
    } else {
        Console.WriteLine("Bir sayı sıfıra bölünemez.");
    }
} else {
    Console.WriteLine("Geçersiz işlem seçildi.");
}

            }

    }
}

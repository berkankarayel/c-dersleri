using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;

            // Aritmetik Operatörler
            int toplama = x + y;    // Toplama: 15
            int cikarma = x - y;    // Çıkarma: 5
            int carpma = x * y;     // Çarpma: 50
            int bolme = x / y;      // Bölme: 2
            int mod = x % y;        // Mod: 0 (10'un 5'e bölümünden kalan)

            // Karşılaştırma Operatörleri
            bool esitMi = x == y;   // Eşit mi? False
            bool buyukMu = x > y;   // x, y'den büyük mü? True

            // Mantıksal Operatörler
            bool mantikSonuc = (x > y) && (x != 0);  // x, y'den büyük VE x sıfır değil mi? True

            // Atama Operatörleri
            x += y;   // x = x + y -> x şimdi 15 oldu

            // Sonuçları ekrana yazdır
            Console.WriteLine("Toplama: " + toplama);
            Console.WriteLine("Çıkarma: " + cikarma);
            Console.WriteLine("Çarpma: " + carpma);
            Console.WriteLine("Bölme: " + bolme);
            Console.WriteLine("Mod: " + mod);
            Console.WriteLine("Eşit mi: " + esitMi);
            Console.WriteLine("Büyük mü: " + buyukMu);
            Console.WriteLine("Mantıksal Sonuç: " + mantikSonuc);
            Console.WriteLine("Atama sonrası x: " + x);




            // *********** OÜRENCİ BİLGİ SİSTEMİ **************


            // Kullanıcıdan bilgi alma
            Console.Write("Öğrencinin yaşını girin: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.Write("1. sınav notunu girin: ");
            int not1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sınav notunu girin: ");
            int not2 = Convert.ToInt32(Console.ReadLine());

            // Aritmetik Operatörler - Ortalama hesaplama
            int toplamNot = not1 + not2;
            double ortalama = toplamNot / 2.0;

            // Karşılaştırma Operatörleri - Başarı durumu
            bool basariliMi = ortalama >= 50;

            // Mantıksal Operatörler - Mezuniyet yaşı kontrolü
            bool mezunOlabilirMi = basariliMi && yas >= 18;

            // Atama Operatörü - Bonus ekleme
            int bonus = 5;
            toplamNot += bonus; // Bonus ekleniyor

            // Sonuçları ekrana yazdırma
            Console.WriteLine("\nSonuçlar:");
            Console.WriteLine("Yaş: " + yas);
            Console.WriteLine("Toplam Not (bonus dahil): " + toplamNot);
            Console.WriteLine("Ortalama: " + ortalama);
            Console.WriteLine("Başarılı mı? " + basariliMi);
            Console.WriteLine("Mezun olabilir mi? " + mezunOlabilirMi);



        }
    }
}

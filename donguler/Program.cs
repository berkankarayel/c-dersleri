using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for döngüsü, belirli bir koşul sağlandığı sürece tekrarlı işlemler yapmak için kullanılan temel bir döngü yapısıdır.
            // for döngüsü, genellikle bilinen bir sayı kadar tekrar eden işlemler için idealdir.

            for (başlangıç_değeri; koşul; artış)
            {
                // Tekrar edecek kodlar
            }

            // Örnek: 1'den 5'e kadar sayıları yazdırma

            for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(i);
                }

            // Örnek: 10'dan 1'e kadar geri sayım

            for (int i = 10; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }


                // Dizilerle for Döngüsü Kullanımı:

                string[] fruits = { "Elma", "Armut", "Muz", "Üzüm" };

                for (int i = 0; i < fruits.Length; i++)
                {
                    Console.WriteLine(fruits[i]);
                }    
            
                // İç İçe (Nested) for Döngüsü:

                for (int i = 1; i <= 3; i++)
                {
                    for (int j = 1; j <= 2; j++)
                    {
                        Console.WriteLine($"i: {i}, j: {j}");
                    }
                }


             //    Döngüyü Erken Bitirme (break):

                for (int i = 1; i <= 10; i++)
                    {
                        if (i == 5)
                        {
                            break; // i 5 olduğunda döngüden çıkılır
                        }
                        Console.WriteLine(i);
                    }
                

            // Döngünün O Anki Adımını Atla (continue):

            for (int i = 1; i <= 5; i++)
                {
                    if (i == 3)
                    {
                        continue; // i 3 olduğunda bu adım atlanır
                    }
                    Console.WriteLine(i);
                }



     // Örnek: Öğrencilerin Notlarını Hesaplama ve İstatistikleri Görüntüleme



         // Öğrenci sayısını belirleme
        int[] notlar = { 85, 78, 92, 60, 70, 88, 55, 95, 100, 45 };

        // Toplam notları saklamak için değişken
        int toplam = 0;

        // En yüksek ve en düşük notları belirlemek için başlangıç değerleri
        int enYuksekNot = notlar[0];
        int enDusukNot = notlar[0];

        // Barajı geçme durumu için kaç öğrenci geçtiğini tutacak sayaç
        int barajiGecenOgrenciSayisi = 0;
        int baraj = 60;  // Baraj notu

        // For döngüsüyle her bir öğrencinin notunu işleme
        for (int i = 0; i < notlar.Length; i++)
        {
            int not = notlar[i];

            // Toplam notu hesapla
            toplam += not;

            // En yüksek notu bul
            if (not > enYuksekNot)
            {
                enYuksekNot = not;
            }

            // En düşük notu bul
            if (not < enDusukNot)
            {
                enDusukNot = not;
            }

            // Barajı geçen öğrenci sayısını bul
            if (not >= baraj)
            {
                barajiGecenOgrenciSayisi++;
            }

            // Eğer bir öğrenci 100 aldıysa döngüyü erken bitir
            if (not == 100)
            {
                Console.WriteLine("100 alan öğrenci bulundu! Döngüden çıkılıyor...");
                break;  // Döngüden çık
            }

            // Eğer bir öğrenci 45 aldıysa bu öğrenciyi atla
            if (not == 45)
            {
                Console.WriteLine("45 alan öğrenci atlandı.");
                continue;  // Döngünün geri kalanını atlayıp bir sonraki adıma geç
            }

            // Notu ekrana yazdır
            Console.WriteLine($"Öğrenci {i + 1}: Notu = {not}");
        }

        // Ortalama hesaplama
        double ortalama = (double)toplam / notlar.Length;

        // Sonuçları ekrana yazdırma
        Console.WriteLine("\nNot İstatistikleri:");
        Console.WriteLine($"Ortalama Not: {ortalama:F2}");
        Console.WriteLine($"En Yüksek Not: {enYuksekNot}");
        Console.WriteLine($"En Düşük Not: {enDusukNot}");
        Console.WriteLine($"Barajı Geçen Öğrenci Sayısı: {barajiGecenOgrenciSayisi}");
            











































            


            
    }
}

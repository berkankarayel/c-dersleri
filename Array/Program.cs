using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Dizilerin Gemel Yapısı : tip[] diziAdi = new tip[diziBoyutu];

            //  Bir Tamsayı Dizisi Tanımlama ve Değer Atama

            int[] sayilar = new int[5]; // 5 elemanlı bir tamsayı dizisi tanımladık

            // Dizi elemanlarına tek tek değer atayalım
            sayilar[0] = 10;
            sayilar[1] = 20;
            sayilar[2] = 30;
            sayilar[3] = 40;
            sayilar[4] = 500;


            // 2. Diziyi Tanımlarken Değer Atama
            int[] sayilar1 = { 10, 20, 30, 40, 50 }; // 5 elemanlı dizi ve her elemanına doğrudan değer atandı


            // 3. Dizideki Değerleri Yazdırma
            int[] sayilar2 = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < sayilar2.Length; i++) // sayilar.Length dizinin uzunluğunu verir
            {
                Console.WriteLine($"sayilar[{i}] = {sayilar2[i]}");
            }



            // Örnek 2: String Dizisi Tanımlama, Değer Atama ve Yazdırma

            string[] isimler = new string[3]; // 3 elemanlı string dizisi tanımlandı

            // Elemanlara değer atama
            isimler[0] = "Ali";
            isimler[1] = "Ayşe";
            isimler[2] = "Mehmet";

            // Elemanları yazdırma
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }


            //  Örnek 3: Dizi Elemanlarının Toplamını Bulma

            int[] sayilar4 = { 5, 10, 15, 20, 25 };
            int toplam = 0;

            for (int i = 0; i < sayilar4.Length; i++)
            {
                toplam += sayilar4[i]; // her elemanı toplam değişkenine ekle
            }

            Console.WriteLine($"Dizideki sayıların toplamı: {toplam}");


            // 4. Foreach Döngüsü ile Dizi Yazdırma

            int[] sayilar5 = { 10, 20, 30, 40, 50 };

            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }

            // Örnek: Kullanıcıdan Dizi Elemanlarını Alma ve Yazdırma

            // Kullanıcıdan dizi boyutunu alalım 
            Console.WriteLine("Kaç elemanlı dizi boyutu isityorsunuz");
            int diziBouyutu = Convert.ToInt32(Console.ReadLine());

            int[] Olusturalan_Dizi = new int[diziBouyutu];

            for (int i = 0; i < diziBouyutu; i++)
            {
                Console.Write($"{i + 1}.elemanı girin");
                Olusturalan_Dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Dizinin elemanları ekrana yazıdırlaım 
            Console.WriteLine("Dizinin elamanları ");
            for (int i = 0; i < diziBouyutu; i++)
            {
                Console.WriteLine($"Olusturalan_Dizi[{i}]={Olusturalan_Dizi[i]}");
            }


            // Örnek: Dizide Kullanıcının Girdiği Sayıyı Arama

            // Sabit bir dizi tanımlayalım
            int[] sayilar = { 10, 12, 23, 34, 45, 56, 67, 78, 89 };

            // Kullanıcının doğru sayıyı bulana kadar döngüye girmesi için sonsuz bir döngü oluşturuyoruz
            bool bulundu = false; // Sayının bulunup bulunmadığını takip etmek için

            while (!bulundu) // Sayı bulunmadıkça döngü devam edecek
            {
                // Kullanıcıdan bir sayı alalım
                Console.Write("Aramak istediğiniz sayıyı girin: ");
                int arananSayi = Convert.ToInt32(Console.ReadLine());

                // Dizide sayının olup olmadığını kontrol edelim
                for (int i = 0; i < sayilar.Length; i++)
                {
                    if (sayilar[i] == arananSayi)
                    {
                        bulundu = true; // Sayı bulundu
                        break; // Sayıyı bulduğumuz için döngüden çıkıyoruz
                    }
                }

                // Sonucu ekrana yazdıralım
                if (bulundu)
                {
                    Console.WriteLine($"Tebrikler! Girilen sayı ({arananSayi}) dizide mevcut.");
                }
                else
                {
                    Console.WriteLine($"Girilen sayı ({arananSayi}) dizide mevcut değil. Lütfen tekrar deneyin.");
                }
            }
        }
        }
}

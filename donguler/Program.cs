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


            // . 1'den 10'a Kadar Sayıları Yazdırma

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                
            }


            // . 0'dan 9'a Kadar Çift Sayıları Yazdırma

            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }


            // 3. Bir Dizi Elemanlarını Yazdırma


            int[] sayilar = { 3, 5, 7, 9, 11 };

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }


            // 4.Faktöriyel Hesaplama


            int sayi = 5;
            int faktoriyel = 1;

            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }

            Console.WriteLine($"{sayi}! = {faktoriyel}");


            //  5.Bir Sayının Asal Olup Olmadığını Kontrol Etme

            int sayi = 29;
            bool asal = true;

            for (int i = 2; i <= sayi / 2; i++)
            {
                if (sayi % i == 0)
                {
                    asal = false;
                    break;
                }
            }

            if (asal && sayi > 1)
            {
                Console.WriteLine($"{sayi} asal bir sayıdır.");
            }
            else
            {
                Console.WriteLine($"{sayi} asal bir sayı değildir.");
            }


            // 6.Yıldız Deseni Çizme

            int satir = 5;

            for (int i = 1; i <= satir; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            // 7.Dizideki En Büyük ve En Küçük Sayıyı Bulma


            int[] sayilar1 = { 15, 28, 6, 33, 22 };
            int enKucuk = sayilar1[0];
            int enBuyuk = sayilar1[0];

            for (int i = 1; i < sayilar1.Length; i++)
            {
                if (sayilar1[i] < enKucuk)
                {
                    enKucuk = sayilar[i];
                }

                if (sayilar[i] > enBuyuk)
                {
                    enBuyuk = sayilar1[i];
                }
            }

            Console.WriteLine($"En küçük sayı: {enKucuk}");
            Console.WriteLine($"En büyük sayı: {enBuyuk}");















        }

    }
}

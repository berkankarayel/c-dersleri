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





            
    }
}

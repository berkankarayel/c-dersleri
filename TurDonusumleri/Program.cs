using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             . Otomatik Dönüşüm (Implicit Conversion)
                Bu tür dönüşüm, verinin kaybı olmadan daha küçük bir veri türünden daha büyük bir veri türüne dönüşümü ifade eder. Örneğin, int türü bir değeri double türüne otomatik olarak dönüştürebilirsin.

             */

            int sayi1 = 10;
            double ondalikSayi = sayi; // Otomatik dönüşüm
            Console.WriteLine(ondalikSayi); // Çıktı: 10.0


            /* 2.Manuel Dönüşüm(Explicit Conversion)
            Bu tür dönüşüm, daha büyük bir veri türünden daha küçük bir veri türüne dönüşümde kullanılır. 
            Bu durumda, veri kaybı riski olduğundan dönüşüm işlemini açıkça belirtmelisin.

             */

            double ondalikSayi1 = 9.75;
            int tamSayi = (int)ondalikSayi1; // Manuel dönüşüm
            Console.WriteLine(tamSayi); // Çıktı: 9 (ondalık kısım kaybolur)



            /*
             
            3. Convert Sınıfı ile Dönüşüm
            C#'ta Convert sınıfını kullanarak da tür dönüşümü yapabilirsin. Bu yöntem, farklı türler arasında güvenli dönüşüm sağlar.
             */
            string metin = "123";
            int sayi = Convert.ToInt32(metin); // String'den int'e dönüşüm
            Console.WriteLine(sayi); // Çıktı: 123


            string hataliMetin = "abc";
            try
            {
                int sayi2 = Convert.ToInt32(hataliMetin); // Bu hata verecektir
            }
            catch (FormatException)
            {
                Console.WriteLine("Dönüşüm hatası: Geçersiz format."); // Hata mesajı
            }


            Console.Write("Bir tam sayı girin: ");
            string kullaniciGirdisi = Console.ReadLine();

            // String'den int'e dönüşüm
            try
            {
                int tamSayi3 = Convert.ToInt32(kullaniciGirdisi);
                Console.WriteLine("Girilen tam sayı: " + tamSayi3);

                // Tam sayıdan double'a dönüşüm
                double ondalikSayi4 = tamSayi;
                Console.WriteLine("Ondalık sayı: " + ondalikSayi4);
            }
            catch (FormatException)
            {
                Console.WriteLine("Dönüşüm hatası: Geçersiz format.");
            }


        }
    }
}

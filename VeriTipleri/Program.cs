using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;

            byte b = 25;

            byte c = 244;  //0 -255

            byte maxDeger = byte.MaxValue;
            byte minDeger = byte.MinValue;



            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);



            //  short değişkeni -32768 ile 32767 arasında değer depolayabilmektedir.

            short birinciDegisken = -50;

            short ikinciDegisken = 25550;

            short ucuncuDegisken = 32000000;

            short MaxDeger = short.MaxValue;

            short MinDeger = short.MinValue;

            Console.WriteLine(MaxDeger);
            Console.WriteLine(MinDeger);


            // object" veri tipi, C# dilindeki en temel veri tipidir ve tüm diğer veri tiplerinin türetildiği temel sınıftır.
            // Yani C#’ta herhangi bir veri türü, object olarak saklanabilir. Bir nevi "her şeyi kapsayan" bir veri türüdür.

            object num = 42;           // int türü object olarak tutuluyor
            object text = "Merhaba";    // string türü object olarak tutuluyor
            object dec = 4.5m;          // decimal türü object olarak tutuluyor

            Console.WriteLine(num);
            Console.WriteLine(text);
            Console.WriteLine(dec);


            // 1) Esneklik : 
            // object veri tipi, herhangi bir veri türünü tutabilir.Bu,
            // kodunuzu daha esnek hale getirir.Özellikle bilinmeyen türdeki verileri
            // depolamanız gerektiğinde veya heterojen veri koleksiyonlarıyla çalıştığınızda faydalıdır.

            object[] mixedArray = new object[3];
            mixedArray[0] = 123;          // int
            mixedArray[1] = "Hello";      // string
            mixedArray[2] = 45.6;         // double

            // Bu örnekte farklı türde verileri tek bir dizi içerisinde saklıyoruz, çünkü object her türlü veri tipini kabul eder.



            // bool Veri Tipinin Özellikleri:
            //Değerler: Sadece iki değer vardır: true ve false.
            //Varsayılan Değer: Bir değişken tanımlandığında varsayılan olarak false değerini alır.
            //Boyut: Bellekte 1 bayt(8 bit) yer kaplar.

            //  Kullanım Alanları:
            // Koşul ifadeleri(if, else, while, vb.) ile kullanılır.
            //Mantıksal karşılaştırmalar yapmak ve sonuçları kontrol etmek için gereklidir.



            bool isRaining = true;  // Yağmur yağıyor mu? Doğru.
            bool isSunny = false;   // Hava güneşli mi? Yanlış.

            if (isRaining)
            {
                Console.WriteLine("Şemsiyeni al.");
            }
            else
            {
                Console.WriteLine("Dışarı çıkabilirsin..");
            }

            // Karşılaştırma operatörleri ile kullanım
            int age = 25;
            bool isAdult = age >= 18;  // 18 yaşından büyük mü?

            Console.WriteLine("Yetişkin mi? " + isAdult);




            /* String veri tipi : 
            1-) String veri tipi, karakter dizilerini saklamak için kullanılır.
            2) Bir string, tırnak işaretleri (" ") arasında tanımlanır ve herhangi bir sayıda karakter içerebilir.
            3-) string referans tipi bir değişkendir, yani bellekte bir nesne olarak saklanır.
            4) C#'ta string immutable'dır, yani oluşturulduktan sonra değiştirilemez.
            Bir string üzerinde yapılan değişiklikler aslında yeni bir string oluşturur.
            */

            string mesaj = "Merhaba Dünya!";
            string ad = "Ali";
            string selam = "Merhaba, " + ad + "!"; // Merhaba, Ali!


            //  STRİNG METOTLARI 

            // Length: String'in uzunluğunu verir.
            string mesaj = "Merhaba Dünya";
            int uzunluk = mesaj.Length; // 13

            string mesaj = "Merhaba Dünya";
            string parca = mesaj.Substring(0, 7); // Merhaba

            bool iceriyorMu = mesaj.Contains("Dünya"); // true


            /* Char Veri Tipi Özellikleri:
            Depoladığı Veri: Sadece bir karakter (harf, rakam, sembol).
            Boyut: 2 byte (Unicode karakterleri destekler).
            Tanımlama: Tek tırnaklar (' ') arasında bir karakterle kullanılır */

            char harf = 'A';
            char karakter = 'A';
            int kod = (int)karakter; // 65 (ASCII kodu)

            // IsDigit: Karakterin bir rakam olup olmadığını kontrol eder.
            char karakter = '5';
            bool rakamMi = char.IsDigit(karakter); // true

            //IsLetter: Karakterin bir harf olup olmadığını kontrol eder.
            char karakter = 'A';
            bool harfMi = char.IsLetter(karakter); // true
            //ToUpper / ToLower: Karakteri büyük ya da küçük harfe dönüştürür.
            char kucukHarf = 'a';
            char buyukHarf = char.ToUpper(kucukHarf); // 'A'






            /*
             float ve double Karşılaştırması:
                    Depolama Alanı ve Hassasiyet:

                    float: 4 byte (32 bit) yer kaplar. Yaklaşık 7 basamak hassasiyet sağlar.
                    double: 8 byte (64 bit) yer kaplar. Yaklaşık 15-16 basamak hassasiyet sağlar.
                    Kullanım Alanları:

                    float: Bellek tasarrufu gerektiğinde, düşük hassasiyetle çalışılacak durumlarda tercih edilir.
                    double: Daha fazla kesinlik ve doğruluk gerektiğinde tercih edilir.
                    Tanımlama Farkı:

                    float: Sayının sonuna f eklenmelidir. Aksi halde C# varsayılan olarak double kabul eder.
                    double: Sonuna bir şey eklemeye gerek yoktur; C# varsayılan olarak double kabul eder.
             
             */



            // float Örneği:
            float sayi1 = 3.14159f; // Sonuna 'f' eklenir
            Console.WriteLine(sayi1); // Çıktı: 3.14159
            // double Örneği:
            double sayi2 = 3.141592653589793;
            Console.WriteLine(sayi2); // Çıktı: 3.141592653589793

            float floatSayi = 12345.67890123456789f;
            double doubleSayi = 12345.67890123456789;

            Console.WriteLine(floatSayi);  // Çıktı: 12345.679 (hassasiyet kaybı)
            Console.WriteLine(doubleSayi); // Çıktı: 12345.678901234567 (daha yüksek hassasiyet)

            /*
             
             int veri tipi, C#'ta tam sayıları (ondalıklı olmayan sayıları) saklamak için kullanılır. 
             Negatif ve pozitif tam sayılarla çalışır.
             Ondalıklı Sayıları Desteklemez: Sadece tam sayılarla çalışır, ondalıklı bir sayı kullanmak istiyorsan float veya double
             tercih etmelisin.

             */

            int sayi = 42;
            int negatifSayi = -100;
            int sayi1 = 10;
            int sayi2 = 20;
            int toplam = sayi1 + sayi2; // 30





            // **********************ÖRNEK********************

            // String veri tipi - Öğrencinin adı
            string isim = "Ali Can";

            // Char veri tipi - Öğrencinin cinsiyeti
            char cinsiyet = 'E'; // E: Erkek, K: Kadın

            // Int veri tipi - Öğrencinin yaşı
            int yas = 20;

            // Float veri tipi - Öğrencinin not ortalaması
            float notOrtalamasi = 85.75f;

            // Double veri tipi - Daha hassas bir ortalama değeri
            double dogruNotOrtalamasi = 85.756789;

            // Bool veri tipi - Öğrenci mezun mu?
            bool mezunMu = false;

            // Char veri tipi - Öğrencinin sınıf derecesi
            char sinifDerecesi = 'A'; // A: Çok iyi, B: İyi, C: Orta, D: Geçer

            // Ekrana yazdırma işlemleri
            Console.WriteLine("Öğrenci Bilgileri");
            Console.WriteLine("------------------");
            Console.WriteLine("İsim: " + isim);
            Console.WriteLine("Cinsiyet: " + cinsiyet);
            Console.WriteLine("Yaş: " + yas);
            Console.WriteLine("Not Ortalaması (float): " + notOrtalamasi);
            Console.WriteLine("Doğru Not Ortalaması (double): " + dogruNotOrtalamasi);
            Console.WriteLine("Mezun mu? " + mezunMu);
            Console.WriteLine("Sınıf Derecesi: " + sinifDerecesi);


















        }
    }
}

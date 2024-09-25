using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace c_dersleri
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

            short ucuncuDegisken = 32000;

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
                Console.WriteLine("Dışarı çıkabilirsin.");
            }

            // Karşılaştırma operatörleri ile kullanım
            int age = 25;
            bool isAdult = age >= 18;  // 18 yaşından büyük mü?

            Console.WriteLine("Yetişkin mi? " + isAdult);


        }
    }
    }


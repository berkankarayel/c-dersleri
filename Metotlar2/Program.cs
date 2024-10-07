using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar2
{
    internal class Program
    {

     
        static void Main(string[] args)
        {

           // 1. Metot Overloading (Metot Aşırı Yükleme): 
            
            // Metot aşırı yükleme (overloading), aynı isimde fakat farklı parametre listelerine sahip metotlar tanımlamayı sağlar.
            // Yani, bir metot ismi, parametre sayısı veya türüne göre farklı görevler yapabilir.
            // Örnek:
        Console.WriteLine(Topla(3, 5));          // int parametreler
        Console.WriteLine(Topla(3.2, 4.8));      // double parametreler


        // 2. Default (Varsayılan) Parametreler
        // Bir metot çağırıldığında bazı parametreleri vermek zorunda olmayabilirsiniz.
        // Bunun için varsayılan parametreler kullanılır. Bir parametreye değer verilmezse, varsayılan değer kullanılır.

        Yazdir("Merhaba");               // Tek parametre ile
        Yazdir("Merhaba", 5);            // İki parametre ile

// ref Anahtar Kelimesi
// ref, bir değişkenin referans yoluyla bir metoda geçirilmesini sağlar. Yani, metot içinde bu değişken üzerinde yapılan değişiklikler, o değişkenin çağrıldığı yerin dışında da geçerli olur. Ancak, ref kullanılan bir değişkenin, metoda gönderilmeden önce mutlaka bir değer atanmış olması gerekir.

/*Özetle:
Metoda girmeden önce değişkene değer atanmış olmalıdır.
Metot, değişkenin orijinal değerini değiştirebilir.*/
            
        int sayi = 5;
        Console.WriteLine("Metot çağrılmadan önce: " + sayi);  // Çıktı: 5
        
        // sayi değişkenini ref ile metoda gönderiyoruz
        DegeriIkiKatinaCikar(ref sayi);
        
        Console.WriteLine("Metot çağrıldıktan sonra: " + sayi); // Çıktı: 10



 /*
     out Anahtar Kelimesi
out, bir değişkenin de referans yoluyla bir metoda gönderilmesini sağlar.
Ancak ref'ten farklı olarak, out kullanırken metoda girmeden önce değişkene bir değer atanmış olması gerekmez.
Metot içinde bu değişkene bir değer atanması zorunludur. Yani out parametresi, metot içinde mutlaka bir değer alır.
            */           

        int carpimSonucu; // Değişkene önceden bir değer atamıyoruz
        Console.WriteLine("Metot çağrılmadan önce: " + carpimSonucu); // HATA verir! Değer atanmamış

        // out ile carpimSonucu değişkenini metoda gönderiyoruz
        Carpim(5, 4, out carpimSonucu);

        Console.WriteLine("Metot çağrıldıktan sonra: " + carpimSonucu); // Çıktı: 20



            /*
            ref ve out Farkları:
            ref: Değişkene önceden değer atanmış olmalı. Yani, metoda gönderilmeden önce zaten bir değeri olmalı.
            out: Değişkene önceden değer atanmış olması gerekmez. Metot içinde mutlaka bir değer atanmalıdır.
            */



            // 4. Recursive Methods (Özyinelemeli Metotlar)
           //  Bir metot kendini çağırıyorsa buna recursive (özyinelemeli) metot denir.
            // Genellikle tekrarlı işlemleri gerçekleştirmek için kullanılır (örneğin, bir sayının faktöriyelini hesaplama).

             Console.WriteLine(Faktoriyel(5)); // Çıktı: 120


            // 5. Expression-bodied Members
            // Kısa ve tek satırlık metotlar yazarken expression-bodied üyeler kullanılabilir.
            // Bu, özellikle get/set metotlarında veya küçük hesaplamalar için faydalıdır.

            Console.WriteLine(KareAl(5)); // Çıktı: 25
            static int KareAl(int sayi) => sayi * sayi;

            
        }      
    static int Topla(int a, int b)
    {
        return a + b;
    }

    static double Topla(double a, double b)
    {
        return a + b;
    }

    static void Yazdir(string mesaj, int tekrar = 1)
    {
        for (int i = 0; i < tekrar; i++)
        {
            Console.WriteLine(mesaj);
        }
    }
    static void DegeriIkiKatinaCikar(ref int sayi)
    {
        sayi = sayi * 2; // sayi değişkenini iki katına çıkarıyoruz
    }
       
 static void Carpim(int a, int b, out int sonuc)
    {
        sonuc = a * b; // out parametresine bir değer atamak zorundayız
    }

        static int Faktoriyel(int sayi)
    {
        if (sayi <= 1)
            return 1;
        else
            return sayi * Faktoriyel(sayi - 1);
    }
       
       
       


    }
}


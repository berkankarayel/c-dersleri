using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi");
            Console.WriteLine("Birinci sayıyı girin:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı girin:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İşlem seçin: +, -, *, /");
            char islem = Convert.ToChar(Console.ReadLine());

            switch (islem)
            {
                case '+':
                    Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
                    Console.ReadLine();
                    break;
                case '-':
                    Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
                    Console.ReadLine();
                    break;
                case '*':
                    Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
                    Console.ReadLine();
                    break;
                case '/':
                    // Bölme işlemi için ikinci sayının sıfır olmadığını kontrol ediyoruz.
                    if (sayi2 != 0)
                    {
                        Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Bir sayı sıfıra bölünemez!");
                        Console.ReadLine();
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem seçtiniz.");
                    Console.ReadLine();
                    break;

            }
            }
    }
}

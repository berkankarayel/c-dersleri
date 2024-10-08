using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekUygulama
{
    internal class Ogrenci
    {

        // Öğrencinin bilgilerini tutacak private değişkenler

        private int ogrenciNo;
        private string isim;
        private string soyisim;
        private double vize1;
        private double vize2;
        private double final;
        private string okulIsmi;


        // Yapıcı metot (Constructor)


        public Ogrenci(int ogrenciNo, string isim, string soyisim, double vize1, double vize2, double final, string okulIsmi)
        {
            this.ogrenciNo = ogrenciNo;
            this.isim = isim;
            this.soyisim = soyisim;
            this.vize1 = vize1;
            this.vize2 = vize2;
            this.final = final;
            this.okulIsmi = okulIsmi;
        }

        // 1. Öğrenci bilgilerini gösteren metot
        public void OgrenciBilgileriniGoster()
        {
            Console.WriteLine($"\nÖğrenci No: {ogrenciNo}");
            Console.WriteLine($"İsim: {isim}");
            Console.WriteLine($"Soyisim: {soyisim}");
            Console.WriteLine($"Vize1: {vize1}");
            Console.WriteLine($"Vize2: {vize2}");
            Console.WriteLine($"Final: {final}");
        }

        public void OgrenciOrtalamaBul()
        {
            double ortalama = (vize1 * 0.3) + (vize2 * 0.3) + (final * 0.4);
            Console.WriteLine($"\nÖğrencinin not ortalaması: {ortalama:F2}");
        }

        // 3. Öğrencinin okulunu getiren metot
        public void OkulGetir()
        {
            Console.WriteLine($"\nÖğrencinin okulu: {okulIsmi}");
        }


    }
}

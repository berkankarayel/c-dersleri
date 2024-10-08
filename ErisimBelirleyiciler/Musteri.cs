using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyiciler
{
    public class Musteri
    {
        public string isim;
        public string soyisim;
        public int maasDegeri;
        public string cinsiyet;
        private int yas;

        public Musteri()
        {
            Console.WriteLine("Müşteri sınıfın yapıcı metotu çalıştı ");
        }

        public void musteriBilgileriGöster()
        {
            Console.WriteLine("İsmi :" +isim);
            Console.WriteLine("Soyisim : " +soyisim);
            Console.WriteLine("Maaş Değeri " +maasDegeri);
            Console.WriteLine("cinsiyet :" +cinsiyet);
            Console.WriteLine("Yaş değeri :" +yas);
        }


        private void isimSoyisimYazdir(string musteriisim,string musterisoyisim)
        {
            Console.WriteLine("Müşterinin ismi : " +musteriisim+"musterisoyisim :"+musterisoyisim);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    public class Araba
    {
        // Arabanın özellikleri (Fields)
        public string marka;
        public string model;
        public int yil;


        // Arabanın bilgilerini gösteren metot

        public void BilgileriGoster()
        {

            Console.WriteLine(string.Format("Araba : {0} {1} {2}", marka, model, yil));


        }

        // Araba hareket etmeye başlar
        public void HareketeGec()
        {
            Console.WriteLine($"{marka} {model} harekete geçti!");
            Console.ReadLine();
        }

        // Parametresiz yapıcı metot
        public Araba()
        {
            marka = "Bilinmiyor";
            model = "Bilinmiyor";
            yil = 2000;
        }
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Araba: {marka} {model}, {yil}");
        }

        //2. Parametreli Yapıcı Metot:
        //Parametreli yapıcı metot, nesne oluşturulurken dışarıdan veri alarak bu verileri kullanabilir.
        //Böylece, nesnenin başlangıç durumunu dinamik olarak belirleyebilirsiniz.

        public Araba(string marka, string model, int yil)
        {
            this.marka = marka;
            this.model = model;
            this.yil = yil;
        }


    }


    
}

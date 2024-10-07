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
    }


    
}

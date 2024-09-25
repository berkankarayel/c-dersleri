using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONGULER
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
        }
    }
}

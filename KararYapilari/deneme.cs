using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 5000; // Bakiye değişkeni döngü dışında tanımlanıyor

            while (true)
            {
                Console.WriteLine("ATM'ye hoş geldinizz");
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                Console.WriteLine("1. Bakiye görüntüleme");
                Console.WriteLine("2. Para çekme");
                Console.WriteLine("3. Para yatırmaa");
                Console.WriteLine("4. Çıkış");

                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Console.WriteLine("Şu anki bakiyeniz: " + bakiye);
                }
                else if (secim == "2")
                {
                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz:");
                    int cekilenMoney = Convert.ToInt32(Console.ReadLine());

                    if (cekilenMoney > bakiye)
                    {
                        Console.WriteLine("Bakiyeniz yetersiz.");
                    }
                    else
                    {
                        bakiye -= cekilenMoney; // Bakiye güncelleniyor
                        Console.WriteLine("Çekilen tutar: " + cekilenMoney);
                        Console.WriteLine("Kalan bakiye: " + bakiye);
                    }
                }
                else if (secim == "3")
                {
                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz:");
                    int yatirilacakMoney = Convert.ToInt32(Console.ReadLine());
                    bakiye += yatirilacakMoney; // Bakiye güncelleniyor
                    Console.WriteLine("Yatırılan para: " + yatirilacakMoney);
                    Console.WriteLine("Güncel bakiye: " + bakiye);
                }
                else if (secim == "4")
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    break; // Döngü sonlanıyor
                }

                // Her işlem sonrası devam etmek için 'c' tuşuna basılması isteniyor
                Console.WriteLine("İşleme devam etmek için 'c' tuşuna basın.");
                while (Console.ReadKey(true).KeyChar != 'c')
                {
                    Console.WriteLine("Yanlış tuş. Devam etmek için 'c' tuşuna basın.");
                }

                Console.WriteLine(); // Yeni satıra geçiş
            }



            // ************************Örnek2***********************


            


                //************************ Örnek 3 *********************

                

            }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._20_CokBoyutluDiziler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi Boyutunu Giriniz:");
            int boyut = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[boyut];

            var r = new Random();//rastgele  sayı üretmek için

            for (int i = 0; i < sayilar.Length; i++)
                sayilar[i] = r.Next(1, 10);//min 1 maks 10 üretir.

            foreach (int s in sayilar)//koleksiyonlar üzerinde dolaşmak içindir.
                //var örtülü değişken anlamına gelir. sayıların tipi ne ise ise değişken o olur.
            {

            }
            Console.ReadKey();
        }
    }
}

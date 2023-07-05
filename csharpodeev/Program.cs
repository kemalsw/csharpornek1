using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpodeev
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 25;

            string sayi = sayi1.ToString();

            int sayi2 = 24;

            string sayii = sayi2.ToString();

            Console.WriteLine(sayii+sayi);
            



            string rakam = "25";
            string rakam1 = "24";
            int degistir = Convert.ToInt32(rakam);
            int degistir1 = Convert.ToInt32(rakam1);
            int toplam = degistir + degistir1;
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}

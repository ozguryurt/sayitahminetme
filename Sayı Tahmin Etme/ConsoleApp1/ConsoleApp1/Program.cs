using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[+] 0 ile 100 arasında bir sayı tahmin etme oyunu.");

            Random rand = new Random();
            int randomSayi = rand.Next(1, 100);

            for(int i = 0; i<1 ; )
            {
                int girilenSayi = Convert.ToInt32(Console.ReadLine());

                if(randomSayi < girilenSayi)
                {
                    Console.WriteLine("[+] Girilen sayı rastgele sayıdan daha büyük.");
                }
                else if (randomSayi > girilenSayi)
                {
                    Console.WriteLine("[+] Girilen sayı rastgele sayıdan daha küçük.");
                }
                else if (randomSayi == girilenSayi)
                {
                    Console.WriteLine("[+] Girilen sayı rastgele sayıya eşit, sayıyı buldunuz. Sayı: " + randomSayi);
                    i++;
                }
            }

        }
    }
}

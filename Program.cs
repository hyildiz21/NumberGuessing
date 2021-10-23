using System;

namespace random_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- SAYI TAHMİN OYUNU -----");
            Console.WriteLine();

            int altsinir, ustsinir;
            Console.Write("Alt sınırı girin: ");
            altsinir = Convert.ToInt16(Console.ReadLine());
            Console.Write("Üst sınırı girin: ");
            ustsinir = Convert.ToInt16(Console.ReadLine());
            int tahmin,holdNumber;
            int tahminNo = 1;
            Random rn = new Random();
            holdNumber = rn.Next(altsinir, ustsinir);
           
            Console.WriteLine("------------------------------");

            Console.Write("1.Tahmininiz: ");
            tahmin = Convert.ToInt16(Console.ReadLine());

            while (tahmin != holdNumber)
            {
               
                if (tahmin < holdNumber)
                {
                    Console.WriteLine("Benim sayım daha büyük");
                }
                else
                {
                    Console.WriteLine("Benim sayım daha küçük");
                }
                tahminNo++;
                Console.Write(tahminNo + ".Tahmininiz: ");
                tahmin = Convert.ToInt16(Console.ReadLine());


            }
            Console.WriteLine("Tebrikler, bildiniz.");
            Console.WriteLine(tahminNo + " tane tahminde bulundunuz ve benim tuttuğum sayı " + holdNumber + " idi.");
            

            Console.Read();
        }
    }
}

using System.Data.SqlTypes;

namespace ödev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int tekrar = 1;
            Console.WriteLine("bir sayı giriniz.");

            while (true)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi > 0)
                {
                    toplam += sayi;

                    while (true)
                    {
                        int sayi2 = Convert.ToInt32(Console.ReadLine());

                        if (sayi2 > 0)
                        {
                            toplam += sayi2;
                            tekrar++;
                        }
                        else if (sayi2 < 0)
                        {
                            Console.WriteLine("pozitif bir sayı giriniz.");
                        }
                        else
                        {
                            double ortalama = 0;
                            ortalama = (double)toplam / tekrar;
                            Console.WriteLine("toplam:" + toplam + "ortalama:" + ortalama);
                            break;
                        }
                    }
                    break;
                }
                else if (sayi < 0)
                {
                    Console.WriteLine("pozitif bir sayı giriniz.");
                }
                else
                {
                    Console.WriteLine("pozitif bir sayı giriniz.");
                }
            }
        }
    }
}

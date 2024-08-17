namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0;
            int sayi2 = 0;
            
            Console.WriteLine("İki sayı giriniz.");

            while (true)
            {
                Console.Write("Birinci sayıyı girin: ");
                try
                {
                    sayi1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçersiz giriş. Geçerli bir sayı girin.");
                }
            }
            while (true)
            {
                Console.Write("İkinci sayıyı girin: ");
                try
                {
                    sayi2 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçersiz giriş. Geçerli bir sayı girin.");
                }
            }

            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);
        }

    }
}


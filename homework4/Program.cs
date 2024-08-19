namespace homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int aralik = r.Next(10, 21);

            int[] elemansayisi = new int[aralik];

            for (int i = 0; i < aralik; i++)
            {
                while (true)
                {
                    int sayilar = r.Next(0, 101);

                    int j;

                    for (j = 0; j < i; j++)
                    {
                        if (elemansayisi[j] == sayilar)
                        {
                            break;
                        }
                    }

                    if (j == i)
                    {
                        elemansayisi[i] = sayilar;
                        break;
                    }
                }

            }
            int enkucuk = elemansayisi[0];
            int enbuyuk = elemansayisi[0];

            foreach (int i in elemansayisi)
            {
                if (i < enkucuk)
                {
                    enkucuk = i;
                }
                if (i > enbuyuk)
                {
                    enbuyuk = i;
                }
            }

            foreach (int s in elemansayisi)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("en küçük sayı:" + enkucuk);
            Console.WriteLine("en büyük sayı:" + enbuyuk);
            Console.WriteLine("toplam eleman sayısı:" + aralik);
        }
    }
}

namespace homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int aralik = r.Next(10, 21);

            int[] elemansayis = new int[aralik];

            for (int i = 0; i < aralik; i++)
            {
                while (true)
                {
                    int sayilar = r.Next(0, 101);

                    int j;

                    for (j = 0; j < i; j++)
                    {
                        if (elemansayis[j] == sayilar)
                        {
                            break;
                        }
                    }

                    if (j == i)
                    {
                        elemansayis[i] = sayilar;
                        break;
                    }
                }

            }
            int enkucuk = elemansayis[0];
            int enbuyuk = elemansayis[0];

            foreach (int i in elemansayis)
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

            foreach (int s in elemansayis)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("en küçük sayı:" + enkucuk);
            Console.WriteLine("en büyük sayı:" + enbuyuk);
            Console.WriteLine("toplam eleman sayısı:" + aralik);
        }
    }
}

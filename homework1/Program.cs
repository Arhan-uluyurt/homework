namespace homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("üç sayı giriniz.");

            int sayi1 = Convert.ToInt32(Console.ReadLine());
                
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 == sayi2 && sayi2 == sayi3)
            {
                Console.WriteLine(sayi1 + "=" + sayi2 + "=" + sayi3);
            }

            else if (sayi1 >= sayi2 && sayi1 >= sayi3)
            {
                if (sayi1 == sayi2)
                {
                    Console.WriteLine(sayi1 + "=" + sayi2 + ">" + sayi3);
                }
                else if (sayi2 > sayi3)
                {
                    Console.WriteLine(sayi1 + ">" + sayi2 + ">" + sayi3);
                }
                else if (sayi2 == sayi3)
                {
                    Console.WriteLine(sayi1 + ">" + sayi2 + "=" + sayi3);
                }
                else if (sayi1 == sayi3)
                {
                    Console.WriteLine(sayi1 + "=" + sayi3 + ">" + sayi2);
                }
                else
                {
                    Console.WriteLine(sayi1 + ">" + sayi3 + ">" + sayi2);
                }
            }

            else if (sayi2 >= sayi1 && sayi2 >= sayi3)
            {
                if (sayi2 == sayi1)
                {
                    Console.WriteLine(sayi2 + "=" + sayi1 + ">" + sayi3);
                }
                else if (sayi1 > sayi3)
                {
                    Console.WriteLine(sayi2 + ">" + sayi1 + ">" + sayi3);
                }               
                else if (sayi1 == sayi3)
                {
                    Console.WriteLine(sayi2 + ">" + sayi1 + "=" + sayi3);
                }
                else if (sayi2 == sayi3)
                {
                    Console.WriteLine(sayi2 + "=" + sayi3 + ">" + sayi1);
                }
                else
                {
                    Console.WriteLine(sayi2 + ">" + sayi3 + ">" + sayi1);
                }
            }

            else if (sayi3 >= sayi1 && sayi3 >= sayi2)
            {
                if (sayi1 > sayi2)
                {
                    Console.WriteLine(sayi3 + ">" + sayi1 + ">" + sayi2);
                }
                else if (sayi1 == sayi2)
                {
                    Console.WriteLine(sayi3 + ">" + sayi1 + "=" + sayi2);
                }
                else if (sayi3 == sayi2)
                {
                    Console.WriteLine(sayi3 + "=" + sayi2 + ">" + sayi1);
                }
                else
                {
                    Console.WriteLine(sayi3 + ">" + sayi2 + ">" + sayi1);
                }
            }

            else
            {
                Console.WriteLine("geçerli bir sayı giriniz.");
            }
        }
    }
}

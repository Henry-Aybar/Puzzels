using System;

namespace Puzzels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            int[] array = Puzzels.RandomArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
            Puzzels.CoinToss();
            Puzzels.TossMultipleCoins(100);
            Console.WriteLine(Puzzels.Names());
        }
    }
}

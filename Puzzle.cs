using System;
using System.Collections.Generic;

namespace Puzzels
{
    class Puzzels
    {
        public static int[] RandomArray()
        {
            Random rand = new Random();
            int[] Arr = new int[10];

            for(int i = 0; i<Arr.Length; i++)
            {
                Arr[i] = rand.Next(5,25);
            }

            return Arr;
        }

        public static double CoinToss()
        {
            Random rand = new Random();

            int Coin = rand.Next(2);
            if(Coin == 1)
            {
                Console.WriteLine("You tossed your Coin in the air it it whent so high up you lost sight of it.you suddenly her it whirring back down to earth it struck the ground with its definitive answer... it is HEADS!! (hope you won)");

                return 1;
            }
            else
            {
                Console.WriteLine("You tossed your Coin in the air it it whent so high up you lost sight of it. You suddenly her it whirring back down to earth it struck the ground with its definitive answer... it is TAILS!! (hope you didnt Loose)");

                return 2;
            }
        }

        public static double TossMultipleCoins(int num)
        {
            double HeadsCount = 0;
            double TailsCount = 0;
            
            for(int i = 1; i < num; i++)
            {
                CoinToss();
                if(CoinToss() == 1)
                {
                    HeadsCount++;
                }
                else
                {
                    TailsCount++;
                }
            }
            // if(TailsCount < HeadsCount)
            // {
            //     double HeadsUpRatio = HeadsCount/num;
            //     return HeadsUpRatio;
            //     Console.WriteLine(HeadsUpRatio);
            // }
            // else
            // {
            //     double TailsUpRatio = TailsCount/num;
            //     return TailsUpRatio;
            // }

            double HeadsUpRatio = HeadsCount/num;
            Console.WriteLine(HeadsUpRatio);
            return HeadsUpRatio;
            
        }

        // Build a function Names that returns a list of strings.  In this function:
            //Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            // Shuffle the list and print the values in the new order
            //Return a list that only includes names longer than 5 characters
        public static List<string> Names()
        {
            List<string> names = new List<string>()
            {
                "Todd", "Tiffany", "Charlie", "Geneva", "Sydney"
            };
            
            Random rand = new Random();

            for(int i = 0; i < names.Count; i++)
            {
                int nameGroup = rand.Next(i);
            }

            for(int i = 0; i < names.Count; i++)
            {
                if (names[i].Length < 5)
                {
                    names.RemoveAt(i);
                }
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
 
            return names;
        }
    }
}
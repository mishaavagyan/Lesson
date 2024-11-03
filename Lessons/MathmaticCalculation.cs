using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    public static class MathmaticCalculation
    {
        

        public static void EvenOdd(int min, int max)
        {
           
            int maxNumber = max;
            int minNumber = min;
            int maxOdd = 0;
            int minEven = 0;
            if (min > max)
            {
                maxNumber = min;
                minNumber = max;
            }


            for (int i = minNumber; i <= maxNumber; i++)
            {
                if (i % 2 == 0)
                {
                    if (minEven == 0)
                    {
                        minEven = i;
                    }
                    else if (i < minEven)
                    {
                        minEven = i;
                    }
                }
                if (i % 2 != 0 && i > maxOdd)
                {
                    maxOdd = i;
                }
            }


            Console.WriteLine("minEven: {0} ", minEven);
            Console.WriteLine($"maxodd {maxOdd}");
        }
    }

    public class Tv
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string TvImageUrl { get; set; } = "https://aaaa.com";

        private int channelNumber;

        public void ChangeChannel()
        {
            Console.WriteLine($"{Name} {Model}'s next Channel is: {++channelNumber}");
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
    public static class KokoBananas
    {
        public static int MinEatingSpeed(int[] piles, int h)
        {
            int minSpeed = 1;

            int maxSpeed = piles.Max();

            while (minSpeed < maxSpeed)
            {
                int mid = minSpeed + (maxSpeed - minSpeed) / 2;

                if (CanEatInTime(piles, h, mid))
                {
                    maxSpeed = mid;
                }
                else
                {
                    minSpeed = mid + 1;
                }
            }

            return minSpeed;
        }

        public static bool CanEatInTime(int[] piles, int h, int speed)
        {
            int hours = 0;
            for (int i = 0; i < piles.Length; i++)
            {
                hours += (int)Math.Ceiling((double)piles[i] / speed);
            }

            return hours <= h;
        }
    }
}

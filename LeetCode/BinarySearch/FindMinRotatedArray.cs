using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
    public static class FindMinRotatedArray
    {
        public static int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int lowest = nums.Max();

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                //check if half is sorted
                if (nums[mid] > nums[right])
                {
                   
                    left = mid + 1;
                }
                else
                {

                    right = mid;
                }

            }
            return lowest;
        }
    }
}

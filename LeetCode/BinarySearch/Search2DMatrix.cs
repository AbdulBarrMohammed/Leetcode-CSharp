using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.Search2DMatrix
{
    public static class Search2DMatrix
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                int left = 0;
                int right = matrix[i].Length - 1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (matrix[i][mid] < target)
                    {
                        left = mid + 1;
                    }
                    else if (matrix[i][mid] > target)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        return true;
                    }

                }
            }
            return false;
        }
    }
}

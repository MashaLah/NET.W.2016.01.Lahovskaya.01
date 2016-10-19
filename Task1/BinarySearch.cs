using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class BinarySearch
    {
        public static int Search(int x, int[] array)
        {
            if (array != null)
            {
                int low = 0, high = array.Length;
                while (low < high)
                {
                    int mid = low + (high - low) / 2;
                    if (x == array[mid])
                    {
                        return mid;
                    }
                    else if (x < array[mid])
                    {
                        high = mid;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
            }
            return -1;
        }
    }
}

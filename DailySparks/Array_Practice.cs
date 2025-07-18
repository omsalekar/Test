using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailySparks
{
    public class Array_Practice
    {

        public void RemoveDuplicates()
        {
            int[] arr = { 1, 2, 2, 2, 3, 4, 5, 5, 4, 5, 4, 5, 6 };

            int k = 0;

            HashSet<int> seen = new HashSet<int>();

            for (int i=0; i < arr.Length;i++)
            {
                if (!seen.Contains(arr[i]))
                { 
                    seen.Add(arr[i]);
                    arr[k++] = arr[i];
                }

            }
            for(int j=0; j < k; j++)
            {
                Console.WriteLine(arr[j]);
            }
        }

    }
}

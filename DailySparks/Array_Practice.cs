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


        public int singleNumber()
        {
            int [] arr = { 4, 1, 2, 1, 2 };
            
            List<int> duplicate = new List<int>();
            int result = 0;

            for(int i = 0; i < arr.Length; i++)
            {
               for(int j=i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        duplicate.Add(arr[i]);
                       
                    }
                }

               
            }
            for(int k = 0; k < arr.Length; k++)
            {
                if (!duplicate.Contains(arr[k]))
                {
                    result = arr[k];
                }
            }
            Console.WriteLine(result);
            return result;

        }

      

    }
}

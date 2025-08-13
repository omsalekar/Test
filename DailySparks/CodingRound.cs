using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailySparks
{
    public class CodingRound
    {
        public void ReverseString()
        {

            string sentence = " This is a  test on sunday ";
            string sent = sentence.ToLower();
            string[] word = sent.Split(' ');
            string reve = "";

            
                for (int j = word.Length-1; j >= 0; j--)
                {
                    reve += word[j] + " ";

                   
                }
            Console.WriteLine(reve);
          

        }

        public void SecondHigest()
        {
            int[] arr = { 82, 45, 67, 12, 90, 34, 90, 80 };

            int first = int.MinValue;
            int second = int.MinValue;

            foreach (int num in arr)
            {
                if (num > first)
                {
                    second = first;
                    first = num;
                }
                else if (num > second && num < first)
                {
                    second = num;
                }
            }

            Console.WriteLine(second);
        }

    

        public void anagram()
        {
          
                string str1 = "silt";
                string str2 = "listen";
                char[] arr1 = str1.ToCharArray();
                char[] arr2 = str2.ToCharArray();
                Array.Sort(arr1);
                Array.Sort(arr2);
                bool isAnagram = arr1.SequenceEqual(arr2);
                Console.WriteLine(isAnagram ? "The strings are anagrams." : "The strings are not anagrams.");

                
        }

        public void Fibonacci()
        {
            int n = 10;
            int a = 0;

            for (int i =0; i < n; i++)
            {
                if (i > 2)
                {
                    a = a + i;
                }
                Console.WriteLine(i);
            }
        }

       

    }
}

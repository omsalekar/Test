using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace DailySparks
{ 

    public class Kata
    {
        public static bool IsPangram(string str)
        {
            
            var letters = str.ToLower().Where(char.IsLetter);

            var uniqueLetters = new HashSet<char>(letters);

            return uniqueLetters.Count == 26;
        }

        public static string AlphabetPosition(string text)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in text.ToLower())
            {
                if (char.IsLetter(c))
                {
                    int position = c - 'a' + 1;
                    result.Append(position + " ");
                }
            }

            return result.ToString().TrimEnd();
        }


        public static int DigPow(int n, int p)
        {
            
            var digits = n.ToString().Select(c => int.Parse(c.ToString()));

          
            long sum = 0;
            int power = p;

            foreach (int digit in digits)
            {
                sum += (long)Math.Pow(digit, power);
                power++;
            }

           
            return sum % n == 0 ? (int)(sum / n) : -1;
        }

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> sequence)
        {
            List<T> result = new List<T>();
            T previous = default;
            bool isFirst = true;

            foreach (T item in sequence)
            {
                if (isFirst || !EqualityComparer<T>.Default.Equals(item, previous))
                {
                    result.Add(item);
                    previous = item;
                    isFirst = false;
                }
            }

            return result;
        }


        public static int GetVowelCount(string str)
        {

            string vowels = "aeiou";

            
            return str.Count(c => vowels.Contains(c));

         


        }
    }

}




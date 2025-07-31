using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailySparks
{
    public class math_based
    {
        public void Divisible_By_Eight()
        {
            int[] nums = {16, 24, 32, 40, 48, 56, 64, 72, 80, 88, 96 };
       
            int count = 0;
            foreach (int n in nums)
            {
                if (n >= 10 && n <= 99)
                {
                    
                    int ones = n % 10;
                    int tence = n / 10;

                    int product = ones * tence;

                    if (n % 8 == 0 && product % 8 == 0)
                    {
                        count++;
                    }
                   

                }
            }
            Console.WriteLine(count);










        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailySparks
{
    public class Number
    {
       

        public void TwoSum()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine("Indexs is" + i + " " + j);
                    }

                }
            }


        }

        public void Palindrome()
        {
            int x = -212;
            if (x < 0)
            {
                Console.WriteLine("False");
            };

            int original = x;
            int reverse = 0;
            while (x > 0)
            {
                int digit = x % 10;
                reverse = reverse * 10 + digit;
                x = x / 10;
            }
            if (original == reverse)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }

        public void RomanToInt()
        {
            string input = Console.ReadLine();
            int sum = 0;

            Dictionary<char, int> romanNumberDictonary = new()
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 }

            };
            for (int i = 0; i < input.Length; i++)
            {
                char CurrentRomanNumber = input[i];
                romanNumberDictonary.TryGetValue(CurrentRomanNumber, out int num);

                if (i + 1 < input.Length && romanNumberDictonary[input[i + 1]] > romanNumberDictonary[CurrentRomanNumber])
                {
                    sum -= num;
                }
                else
                {
                    sum += num;
                }
            }
            Console.WriteLine(sum);



        }
        public void NumberToRoman(int num)
        {
            string Romanresult = "";

            Dictionary<string, int> romanNumberDictionary = new()
        {
            {"I",1},
            {"IV",4},
            {"V",5},
            {"IX",9},
            {"X",10},
            {"XL",40},
            {"L",50},
            {"XC",90},
            {"C",100},
            {"CD",400},
            {"D",500},
            {"CM",900},
            {"M",1000}
        };

            foreach (var item in romanNumberDictionary.Reverse())
            {
                if (num <= 0) break;
                while (num >= item.Value)
                {
                    Romanresult += item.Key;
                    num -= item.Value;
                }
            }
            Console.WriteLine(Romanresult);

        }

        public int[] PlusOne(int[] nums)
        {


            int index = nums.Length;

            for (int i = nums.Length - 1; i >= 0; i--)
            {

                if (nums[i] < 9)
                {
                    nums[i]++;
                    Console.WriteLine(nums[i]);
                    return nums;
                }
                nums[i] = 0;



            }
            int[] result = new int[index + 1];
            result[0] = 1;
            return result;



        }
    }
}

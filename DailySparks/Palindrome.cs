using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailySparks
{
    public class Palindrome
    {
        public void palindrome()
        {
            Console.WriteLine("Enter Your Input : ");
            string Input = Console.ReadLine().ToLower();
          
            string Reverse = "";

            for (int i = Input.Length-1; i >= 0; i--)
            {
                Reverse += Input[i];
            }
            if(Reverse == Input)
            {
                Console.WriteLine("Input is Palindrome");
            }
            else
            {
                Console.WriteLine("Input is not Palindrome");
            }
        }
       


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailySparks
{
    public class string_practice
    {
      

        public int StrStr(string haystack, string needle)
        {
            int index = 0;
            bool ismatch;

            if (haystack == null || !haystack.Contains(needle) || needle.Length > haystack.Length)
            {
                return -1;
            }

           
                        if (haystack.Contains(needle))
                        {
                            
                          
                            return haystack.IndexOf(needle);

                           
                             
                        }
                 return index;
        }

    }
}

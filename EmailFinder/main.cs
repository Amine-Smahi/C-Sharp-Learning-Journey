/*
               " sharing is caring "
               any suggestion or idea is welcomed
                  -  Amine Smahi  -
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample text
            string text = "For general inquiries contact mohammed.amine.smahi@gmail.com For partnerships and other offers contact contact@example.com.";
            
            // regular expression for matching email addresses
            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex re = new Regex(pattern);
            
            if (text != null)
            {
                // get all matches
                MatchCollection matches = re.Matches(text);
                if (matches.Count > 0)
                {
                    for (int i = 0; i < matches.Count; i++)
                    {
                        System.Console.WriteLine(matches[i]);
                    }
                }
            }
        }
    }
}
 

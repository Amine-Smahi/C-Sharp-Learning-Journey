using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Generate a Pyramid using * symbols */
namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 8; //number of rows
            
            int count = 1;
            for (int lines = num; lines >= 1; lines--)
            {
                for (int spaces = lines; spaces >= 0; spaces--)
                {
                    Console.Write(" ");
                }
                for (int star = 1; star <= count; star++)
                {
                    Console.Write("* ");
                }
                count++;
                Console.WriteLine();
            }
        }
    }
}
 

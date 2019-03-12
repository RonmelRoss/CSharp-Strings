using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 10495;

            Console.WriteLine(binCounter(input));
            Console.ReadLine();
        }
        static string binCounter(int n)
        {
            string binary = Convert.ToString(n, 2); //Convert decimal input to binary
            char[] binArray = binary.ToCharArray(); //Convert string to character array
            int binLength = binary.Length;  //Return length of string
            int i, j, k;
            i = j = k = 0;

            while (i < binLength)
            {
                int x = Convert.ToInt32(binArray[i].ToString()); 
                if (x == 1)
                {
                    j += 1;
                    if (j > k){ k = j; }
                }
                else
                {
                    j = 0;
                }
                i++;
            }

            return k.ToString();
        }
    }
}

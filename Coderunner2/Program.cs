/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : arrays
 * 
 * ############################# */

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderunner_1
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstThirdAndLast();
        }
        static void FirstThirdAndLast()
        {
            string[] values = new string[6];
            Console.WriteLine("Inputting data to the array");
            Console.WriteLine("===========================");
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("Please enter a value: ");
                values[i] = Console.ReadLine();
            }
            Console.WriteLine(" ");
            Console.WriteLine("Outputting first, third and last elements");
            Console.WriteLine("=========================================");
            for (int i = 0; i < values.Length; i++)
            {
                if ((i == 0) || (i == 2) || (i == 5))
                {
                    Console.WriteLine(values[i]);
                }
            }
        }
    }
}
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

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            playerAges(12, 4, 5, 47, 18, 19);
        }
        static void playerAges(int a, int b, int c, int d, int e, int f)
        {
            int[] playerAges = new int[6];
            playerAges[0] = a;
            playerAges[1] = b;
            playerAges[2] = c;
            playerAges[3] = d;
            playerAges[4] = e;
            playerAges[5] = f;
            for (int i = 0; i < playerAges.Length; i++)
            {
                Console.WriteLine("Position {0}: {1}", i, playerAges[i]);
            }
        }
    }
}
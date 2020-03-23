/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : string manipulation
 * 
 * ############################# */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling_iii_
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyboard = "qwertyuiopasdfghjklzxcvbnm";
            Number(keyboard);
        }
        static void Number(string keyboard)
        {
            int total = 0;
            char certain = 'x';
            char other = 'y';
            for (int i = 0; i < keyboard.Length; i++)
            {
                if (keyboard[i] == certain || keyboard[i] == other)
                {
                    total = total + 1;
                }
            }
            Console.WriteLine(total);
        }
    }
}

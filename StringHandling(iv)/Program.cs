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

namespace StringHandling_iv_
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
            for (int i = 0; i < keyboard.Length; i++)
            {
                Console.Write(keyboard[i]);

            }
        }
    }
}

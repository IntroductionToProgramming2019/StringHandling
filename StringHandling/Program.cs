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

namespace StringHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Johnathon";
            Pass(name);
        }
        static void Pass(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}

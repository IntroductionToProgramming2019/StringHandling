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

namespace StringHandling_ii_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "123456";
            Pass(name);
        }
        static void Pass(string name)
        {
            for (int i = 2; i < name.Length; i = i + 3)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}

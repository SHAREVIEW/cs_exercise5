using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //replace
            
            Console.WriteLine("Please enter a string:");
            string myString = Console.ReadLine();
            myString = myString.Replace("yes", "no");
            Console.WriteLine("replaced string:{0}", myString );
            Console.ReadKey();
        }
    }
}

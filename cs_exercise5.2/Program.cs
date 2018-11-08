using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_exercise5._2
{
    class Program
    {
        static void Main(string[] args)  //split 
        {
            Console.WriteLine("Enter a string:");
            string myString= Console.ReadLine();
            string[] myWords = myString.Split(' ');
            Console.WriteLine("split with double quotes:");
            foreach (string element in myWords)
            {
                
                Console.WriteLine("\"{0}\"", element );
                
            }
            Console.ReadKey();


        }
    }
}

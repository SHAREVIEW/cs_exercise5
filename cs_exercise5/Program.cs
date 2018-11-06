using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_exercise5
{
    class Program
    {
        static void Main(string[] args)

        {
            //接受用户输入的字符串，将其中的字符与输入相反的顺序输出
            Console.WriteLine("Enter a string:");
            string myString = Console.ReadLine();
            string reversedString = "";
            for (int index = myString.Length - 1; index >= 0; index--)
            {
                reversedString += myString[index];
            }
            Console.WriteLine("Reversed: {0}", reversedString);
            Console.ReadKey();
        }
    }
}

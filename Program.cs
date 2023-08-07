using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {           

             void printViaRecursion(string[] names, int index)
            {
                if (index < names.Length)
                {
                    Console.WriteLine(names[index]);
                    printViaRecursion(names, index + 1);
                }
            }

             void runApp()
            {
                string[] students = { "Alice", "Bob", "Charlie", "David", "Eve" };
                Console.WriteLine("Names of Students:");

                
                printViaRecursion(students, 0);
            }
            Console.ReadKey();
        }
    }

}
   

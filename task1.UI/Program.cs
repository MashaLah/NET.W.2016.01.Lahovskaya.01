using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 8, 12, 13, 45, 64, 77, 78, 88, 325 };
            foreach (int a in array) Console.Write("{0} ", a);
            Console.WriteLine();
            Console.Write("Enter x: ");
            int x = Int32.Parse(Console.ReadLine());
            int result = BinarySearch.Search(x, array);
            if (result >= 0)
            {
                Console.WriteLine("Index = {0}", result);
            }
            else
            {
                Console.WriteLine("Not found");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypesandValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); //a: 10, b: 11

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1; //array2 references the same memory location of array1
            array2[0] = 0;      // so the changes are visible through the other variable.
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0])); //array1[0]: 0 , array2[0]: 0
        }
    }
}

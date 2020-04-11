using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge2Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<int> { 1, 2, 3 };
            var b = new List<int> { 2, 5, 5 };

            var c = mergeArrays(a, b);
            foreach (var i in c)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }

        public static List<int> mergeArrays(List<int> a, List<int> b) {
            var c = new List<int>();

            var na = a.Count();
            var nb = b.Count();

            var i = 0;
            var j = 0;

            // foreach loop would not be good for this 

            while (i < na && j < nb) {
                if (a[i] < b[j])
                    c.Add(a[i++]);
                else
                    c.Add(b[j++]);
            }

            // if anything left
            while (i < na)
                c.Add(a[i++]);

            while (j < nb)
                c.Add(b[j++]);

            return c;
        }
    }
}

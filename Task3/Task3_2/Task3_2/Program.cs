using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> l = new CustomList<int>();
            l.Add(0);
            l.Add(1);
            l.Add(3);

            CustomList<int> l2 = new CustomList<int>(10);
            l2.Add(5);
            l2.Add(7);
            l2.Add(9);
            l2.Add(6);
            l2.Add(8);
            l2.Add(2);
            l.AddRange(l2);

            foreach(int item in l)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"{l2.Contains(9)} {l2.Contains(4)}");

            int[] arr = new int[20];
            l.CopyTo(arr, 3);

            Console.WriteLine($"{l.IndexOf(5)} {l.IndexOf(4)}");

            l2.Insert(4, 3);
            l.Insert(4, 4);

            l.Remove(4);
            Console.ReadKey();
        }
    }
}

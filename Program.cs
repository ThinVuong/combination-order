using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;


namespace ConsoleApp2
{
    internal class Program
    {
        
            static List<List<int>> comb;
            static bool[] used;
        static void Main()
            {
                int[] arr = { 10, 50, 3, 1, 2 };
                used = new bool[arr.Length];
                for(int i=0;i<used.Length;i++)
            {
                used[i] = false;
            }
                comb = new List<List<int>>();
                List<int> c = new List<int>();
                GetComb(arr, 0, c);
                foreach (var item in comb)
                {
                    foreach (var x in item)
                    {
                        Console.Write(x + ",");
                    }
                    Console.WriteLine("");
                }
                Console.ReadKey();
            }
            static void GetComb(int[] arr, int colindex, List<int> c)
            {

                if (colindex >= arr.Length)
                {
                    comb.Add(new List<int>(c));
                    return;
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        c.Add(arr[i]);
                        GetComb(arr, colindex + 1, c);
                        c.RemoveAt(c.Count - 1);
                        used[i] = false;
                    }
                }
            }
    }
}

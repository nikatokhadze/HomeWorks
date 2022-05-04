using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace homework4
{
    class Program
    {


        static void Main(string[] args)
        {
            #region task 1

            int array;

            Console.WriteLine("enteri array size: ");
            array = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("write number");
            int[] arr = new int[array];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("even: ");
            for (int i = 0; i < array; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");

                }
            }
            Console.WriteLine();
            Console.Write("odd: ");
            for (int i = 0; i < array; i++)
            {
                if (arr[i] % 2! == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            #endregion

            #region task 2
            int num;

            Console.WriteLine("enteri array size: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("write number");
            int[] arr1 = new int[num];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            var duplicates = arr1.GroupBy(a => a)
                .Where(b => b.Count() > 1)
                .Select(c => new { item = c.Key, count = c.Count(), sum = c.Sum() })
                .ToList();
            Console.WriteLine(String.Join("\n", duplicates));

            #endregion

            #region task 3

            var babys = new List<int>();
            babys.Add(1);
            babys.Add(2);
            babys.Add(3);
            babys.Add(4);
            babys.Add(5);
            babys.Add(6);
            babys.Add(7);
            babys.Add(8);
            babys.Add(9);
            babys.Add(10);

            Console.Write("top must be displayed : ");
            int m = Convert.ToInt32(Console.ReadLine());

            babys.Reverse();

            Console.Write($"The top {m} are: \n");
            foreach (int candy in babys.Take(m))
            {
                Console.WriteLine(candy);
            }
            Console.ReadLine();

            #endregion
        }
    }

}

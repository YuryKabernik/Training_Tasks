﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    static class SorterClass
    {
        /// <summary>
        /// Returns an array sorted with the help of for() loop.
        /// </summary>
        /// <param name="arr">Array for sorting</param>
        static public int[] SortAsFor(int[] arr)
        {
            //int buf;
            int[] buffer = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    buffer[i] = arr[i - 1];
                    buffer[i - 1] = arr[i];
                }
            }
            return buffer;
        }
        /// <summary>
        /// Returns an array sorted with the help of while() loop.
        /// </summary>
        /// <param name="arr">Array for sorting</param>
        /// <returns></returns>
        static public int[] SortAsEnumerator(int[] arr)
        {
            IEnumerator enumerator = arr.GetEnumerator();
            int current;

            int[] buffer = new int[arr.Length];
            int i = 1;
            while (enumerator.MoveNext())
            {
                current = (int)enumerator.Current;
                if (i % 2 != 0)
                {
                    buffer[i] = arr[i - 1];
                    buffer[i - 1] = arr[i];
                }
                i++;
            }
            return buffer;
        }
        /// <summary>
        /// Returns an array sorted with the help of recursion loop.
        /// </summary>
        /// <param name="arr">Array for sorting.</param>
        /// <returns>Soting result.</returns>
        static public int[] SortAsEnumerator2(int[] arr)
        {
            IEnumerator enumerator = arr.GetEnumerator();
            int[] buffer = new int[arr.Length];

            Loop(enumerator, ref arr, ref buffer);

            return buffer;
        }
        /// <summary>
        /// Recursion loop.
        /// </summary>
        /// <param name="enumerator">Enumerator of sorted array.</param>
        /// <param name="arr">Array for sorting.</param>
        /// <param name="buffer">Buffer array.</param>
        /// <param name="i">Optional parametr.(index)</param>
        static private void Loop(IEnumerator enumerator, ref int[] arr, ref int[] buffer, int i = 0)
        {
            if (enumerator.MoveNext())
            {
                int current = (int)enumerator.Current;
                if (i % 2 != 0)
                {
                    buffer[i] = arr[i - 1];
                    buffer[i - 1] = arr[i];
                }
                i++;
                Loop(enumerator, ref arr, ref buffer, i);
            }
        }
    }
}

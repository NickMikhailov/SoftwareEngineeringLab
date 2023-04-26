using System;
using System.Security.Cryptography.X509Certificates;

namespace Practice
{
    internal class Sort
    {
        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void Bubble(int[] input, bool descending = false)
        {

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length-1; j++)
                {
                    if (descending ? input[j] < input[j+1]: input[j] > input[j + 1])
                    {
                        swap(ref input[j], ref input[j+1]);
                    }
                }
            }
        }
        public static void Insert(int[] input, bool descending = false)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (descending ? input[i] < input[j]: input[i] > input[j])
                    {
                        swap(ref input[i], ref input[j]);
                    }
                }
            }
        }
        public static void Coctail(int[] input, bool descending = false)
        {
            int left = 0;
            int right = input.Length-1;
            int count = 0;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (descending ? input[i] < input[i+1] : input[i] > input[i+1])
                    {
                        swap(ref input[i], ref input[i+1]);
                    }
                }
            }
        }
    }
}

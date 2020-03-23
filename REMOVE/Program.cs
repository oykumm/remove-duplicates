/*Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.*/
using System;

namespace REMOVE
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 3, 4, 4, 4, 5, 5 };
            int n = arr.Length;

            n = RemoveDup(arr, n);

            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
        static int RemoveDup(int[] arr, int n)
        {

               if (n == 0 || n == 1)
                return n;

            int[] temp = new int[n];

            int j = 0;

            for (int i = 0; i < n - 1; i++)

                if (arr[i] != arr[i + 1])
                    temp[j++] = arr[i];

         
            temp[j++] = arr[n - 1];

          
            for (int i = 0; i < j; i++)
                arr[i] = temp[i];

            return j;
        }
        public class Solution
        {
            public int RemoveDuplicates(int[] arr)
            {

                int count = 1;

                int[] temp = new int[arr.Length];

                int j = 0;

                for (int i = 0; i < arr.Length - 1; i++)

                    if (arr[i] != arr[i + 1])
                    {
                        temp[j++] = arr[i];
                        count++;
                    }



                temp[j++] = arr[arr.Length - 1];


                for (int i = 0; i < j; i++)
                    arr[i] = temp[i];

                return count;
            }

        }

    }
}

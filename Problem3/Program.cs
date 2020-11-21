using System;

namespace KadaneAlgorithm
{
    class Program
    {

        static void KadaneAlg(int[] array)
        {
            int index_start = 0, index_end = 0;
            int max_sum = int.MinValue; 
            int current_sum = 0; 
            int indeks_start_max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                current_sum = current_sum + array[i]; //sum of indexes

                if (max_sum < current_sum)
                {
                    //max sum equals the sum in this index
                    //begins the new subarray
                    index_end = i;
                    indeks_start_max = index_start;
                    max_sum = current_sum;
                }
                  

                if (current_sum < 0)
                {
                    index_start = i + 1;
                    current_sum = 0;
                }
                    

            }

            Console.Write("The start index is " + indeks_start_max + ", the end index is " 
                + index_end + " and the sum is " + max_sum + "\n");

            Console.ReadKey();

        }


        static void Main(string[] args)
        {
            int[] a = { 12, -34, 40, 6, -10, 56, 12, -1, -15, 10, 4 };

            int[] b = { -2, -3, 4, -1, -2, 1, 5, -3 };

            KadaneAlg(a);
            //Kadane_alg(b);

        }
    }
}

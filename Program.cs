using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int _tmp;
            _tmp = b;
            b = a;
            a = _tmp;
        }
        static int Partition(int[] A, int min, int max)
        {
            int pivot = A[max];
            int i = min;
            for (int j = min; j <= max - 1; j++)
            {
                if (A[j] <= pivot)
                {
                    Swap(ref A[i], ref A[j]);
                    i++;            
                }
            }
            Swap(ref A[i], ref A[max]);
            return i;
        }
        static void Sort(int[] A, int min, int max)
        {
            if (min >= max) return;
            int pivot = Partition(A, min, max);
            Sort(A, min, pivot - 1);
            Sort(A, pivot + 1, max);
        }
        static void Main(string[] args)
        {
            int[] A = {10,80,30,90,40,50,70}; 
            Sort(A, 0, 6);
            for (int i = 0; i < 7; i++) Console.Write($"{A[i]} ");
            Console.ReadKey();
        }
    }
}

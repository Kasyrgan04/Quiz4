﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4
{
    internal class Quick
    {  
        static int Partition(int[] arr, int low, int high)
        {

           
            int pivot = arr[high];


            int i = low - 1;


            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }


            Swap(arr, i + 1, high);
            return i + 1;
        }


        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }


        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {


                int pi = Partition(arr, low, high);


                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

    }

}


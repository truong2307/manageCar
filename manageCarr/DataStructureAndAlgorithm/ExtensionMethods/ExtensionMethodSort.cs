﻿using System;

namespace manageCarr.ExtensionMethods
{
    public static class ExtensionMethodSort
    {

        // func để chia thành 2 mảng, 1 mảng lớn và 1 mảng nhỏ hơn pivot
        private static int Partition<T>(T[] arr, int left, int right) where T : IComparable
        {
            T pivot = arr[left];
            while (true)
            {
                // if arr[left] < pivot
                while (arr[left].CompareTo(pivot) < 0)
                {
                    left++;
                }
                // if arr[right] > pivot
                while (arr[right].CompareTo(pivot) > 0)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left].CompareTo(arr[right]) == 0) return right;

                    T temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        //Quick sort
        public static void QuickSort<T>(this T[] arr, int left, int right) where T : IComparable
        {
            if (left < right)
            {

                int pivot = Partition(arr, left, right);

                //quick sort mảng nhỏ hơn pivot
                if (pivot > 1)
                {
                    QuickSort<T>(arr, left, pivot - 1);
                }

                // quick sort mảng lớn hơn pivot
                if (pivot + 1 < right)
                {
                    QuickSort<T>(arr, pivot + 1, right);
                }
            }
        }

        //Interchange Sort
        public static void InterchangeSort<T>(this T[] arr) where T : IComparable
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                    {
                        T temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        //Bubble sort
        public static void BubbleSort<T>(this T[] arr) where T : IComparable
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j].CompareTo(arr[j - 1]) < 0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
        }

        //Selection sort
        public static void SelectionSort<T>(this T[] arr) where T : IComparable
        {
            int minIndex = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[minIndex].CompareTo(arr[j]) > 0)
                    {
                        minIndex = j;
                    }
                }
                T temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }

        //Merge sort
        private static void Merge<T>(T[] arr, int left, int middle, int right) where T : IComparable
        {
            int indexLeft, indexRight, indexResult = left;
            // lenght of array left
            int lengthLeft = middle - left + 1;
            // lenght of array right
            int lengthRight = right - middle;
            // create array contain value left
            T[] leftArray = new T[lengthLeft];
            // create array contain value right
            T[] rightArray = new T[lengthRight];

            //import value by indexleft to array left from arr
            for (indexLeft = 0; indexLeft < lengthLeft; indexLeft++)
            {
                leftArray[indexLeft] = arr[left + indexLeft];
            }
            //import value by indexright to array right from arr
            for (indexRight = 0; indexRight < lengthRight; indexRight++)
            {
                rightArray[indexRight] = arr[middle + indexRight + 1];
            }

            // compare value at indexleft and indexright 
            indexLeft = 0; indexRight = 0;
            while (indexLeft < lengthLeft && indexRight < lengthRight)
            {
                //if value at indexleft <= value at indexright 
                if (leftArray[indexLeft].CompareTo(rightArray[indexRight]) <= 0)
                {
                    arr[indexResult] = leftArray[indexLeft];
                    indexLeft++;
                }
                else
                {
                    arr[indexResult] = rightArray[indexRight];
                    indexRight++;
                }
                indexResult++;
            }
            //if in arrayright has not value then add value from arrayleft to arr by indexresult
            while (indexLeft < lengthLeft)
            {
                arr[indexResult++] = leftArray[indexLeft++];
                //indexResult++;
                //indexLeft++;
            }
            //if in arrayleft has not value then add value from arrayright to arr by indexresult
            while (indexRight < lengthRight)
            {
                arr[indexResult] = rightArray[indexRight];
                indexResult++;
                indexRight++;
            }
        }

        //divide arr until it has 1 value
        public static void MergSort<T>(this T[] arr, int left, int right) where T : IComparable
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                MergSort(arr, left, middle);
                MergSort(arr, middle + 1, right);
                Merge(arr, left, middle, right);
            }
        }

        //Insertion sort
        public static void InsertionSort<T>(this T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                T temp = array[i];
                int pos = i - 1;
                while (pos >= 0 && array[pos].CompareTo(temp) > 0)
                {
                    array[pos + 1] = array[pos];
                    pos--;
                }
                array[pos + 1] = temp;
            }
        }



    }
}
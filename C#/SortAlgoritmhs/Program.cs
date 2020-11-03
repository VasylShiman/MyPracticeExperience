using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace SortAlgoritmhs
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = { 8, 6, 5, 4, 3, 2, 7, 1, };
      // BubbleSort(arr);
      // InsertSort(arr);
      List<int> myList = new List<int> { 5, 4, 1, 2, 8, 7, 6, 3 };
      // var sortList = mergeSort(myList).ToArray();
      // foreach (int it in sortList)
      // {
      //   Console.WriteLine(it);
      // }
      // System.Console.WriteLine(sortList[3]);

      var newArrQSort = QuickSort(arr);
      foreach (int item in newArrQSort)
      {
        Console.WriteLine(item);
      }

      static List<int> mergeSort(List<int> list)
      {
        if (list.Count <= 1) return list;

        List<int> result;
        List<int> left = new List<int>();
        List<int> right = new List<int>();

        int midPoint = list.Count / 2;

        left.AddRange(list.GetRange(0, midPoint));
        right.AddRange(list.GetRange(midPoint, list.Count - midPoint));

        left = mergeSort(left);

        right = mergeSort(right);

        result = merge(left, right);
        return result;
      }


      int[] QuickSort(int[] arr)
      {

        QuickSortNow(arr, 0, arr.Length - 1);
        void QuickSortNow(int[] iInput, int start, int end)
        {
          if (start < end)
          {
            int pivot = Partition(iInput, start, end);
            QuickSortNow(iInput, start, pivot - 1);
            QuickSortNow(iInput, pivot + 1, end);
          }
        }

        static int Partition(int[] iInput, int start, int end)
        {
          int pivot = iInput[end];
          int pIndex = start;

          for (int i = start; i < end; i++)
          {
            if (iInput[i] <= pivot)
            {

              Swap(ref iInput[i], ref iInput[pIndex]);
              pIndex++;
            }
          }


          Swap(ref iInput[pIndex], ref iInput[end]);
          return pIndex;
        }
        return arr;
      }








      #region Bublesort
      static void BubbleSort(int[] a)
      {
        int loopCount = 0;
        int swapCount = 0;
        bool doBreak = true;
        for (int i = 0; i < a.Length - 1; ++i)
        {
          doBreak = true;
          for (int j = 0; j < a.Length - 1; ++j)
          {
            if (a[j] > a[j + 1])
            {
              Swap(ref a[j], ref a[j + 1]);
              swapCount++;
              doBreak = false;
            }
            loopCount++;

          }
          if (doBreak) { break; /*early escape*/ }
        }
        Console.WriteLine($"{loopCount} + {swapCount}");
      }
      #endregion
      #region Insertsort
      static void InsertSort(int[] a)
      {
        int loopSwapCount = 0;
        for (int i = 1; i < a.Length; i++)
        {

          var temp = a[i];
          var j = i;
          while (j > 0 && temp < a[j - 1])
          {
            a[j] = a[j - 1];
            j--;
            loopSwapCount++;
          }
          a[j] = temp;
        }
        Console.WriteLine("swapCount " + loopSwapCount);
      }
      #endregion
      #region Functions
      static void Swap(ref int x, ref int y)
      {
        int temp = x;
        x = y;
        y = temp;
      }


    }
    //This method will be responsible for combining our two sorted arrays into one giant array
    static List<int> merge(List<int> left, List<int> right)
    {
      List<int> result = new List<int>();

      int indexlenght = left.Count + right.Count;
      int indexLeft = 0;
      int indexRight = 0;
      for (int i = 0; i < indexlenght; i++)
      {
        //if both arrays have elements  
        if (indexLeft < left.Count && indexRight < right.Count)
        {
          if (left[indexLeft] <= right[indexRight])
          {
            result.Add(left[indexLeft]);
            indexLeft++;
          }
          else
          {
            result.Add(right[indexRight]);
            indexRight++;
          }
        }
        else if (indexLeft < left.Count)
        {
          result.Add(left[indexLeft]);
          indexLeft++;
        }
        else if (indexRight < right.Count)
        {
          result.Add(right[indexRight]);
          indexRight++;
        }

      }
      return result;
    }




    #endregion
  }
}

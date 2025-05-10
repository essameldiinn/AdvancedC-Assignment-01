namespace Ass_01
{
    using System;

    #region Part 01
    //class OptimizedBubbleSort
    //{
    //    public static void BubbleSort(int[] arr)
    //    {
    //        int n = arr.Length;
    //        bool swapped;

    //        for (int i = 0; i < n - 1; i++)
    //        {
    //            swapped = false;

    //            for (int j = 0; j < n - 1 - i; j++)
    //            {
    //                if (arr[j] > arr[j + 1])
    //                {
    //                    // Swap
    //                    int temp = arr[j];
    //                    arr[j] = arr[j + 1];
    //                    arr[j + 1] = temp;

    //                    swapped = true;
    //                }
    //            }
    //            // No swaps means the array is sorted
    //            if (!swapped)
    //                break;
    //        }
    //    }
    //    public static void PrintArray(int[] arr)
    //    {
    //        foreach (var item in arr)
    //            Console.Write(item + " ");
    //        Console.WriteLine();
    //    }
    //}


    // int[] numbers = { 5, 1, 4, 2, 8 };
    //Console.WriteLine("Before sorting:");
    //OptimizedBubbleSort.PrintArray(numbers);

    //OptimizedBubbleSort.BubbleSort(numbers);

    //Console.WriteLine("After sorting:");
    //OptimizedBubbleSort.PrintArray(numbers); 
    #endregion

    #region Paart 02
    //    public class Range<T> where T : IComparable<T>
    //    {
    //        public T Min { get; private set; }
    //        public T Max { get; private set; }

    //        public Range(T min, T max)
    //        {
    //            if (min.CompareTo(max) > 0)
    //                throw new ArgumentException("Minimum should be less than or equal to Maximum.");

    //            Min = min;
    //            Max = max;
    //        }

    //        public bool IsInRange(T value)
    //        {
    //            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
    //        }

    //        public dynamic Length()
    //        {
    //            // Assumes T supports subtraction, like numeric types
    //            return (dynamic)Max - (dynamic)Min;
    //        }

    //        public override string ToString()
    //        {
    //            return $"Range: {Min} to {Max}";
    //        }
    //    }


    //var intRange = new Range<int>(10, 20);
    //Console.WriteLine(intRange);                         // Output: Range: 10 to 20
    //Console.WriteLine(intRange.IsInRange(15));           // True
    //Console.WriteLine($"Length: {intRange.Length()}");   // 10

    //var doubleRange = new Range<double>(1.5, 3.5);
    //Console.WriteLine(doubleRange.IsInRange(2.1));       // True
    //Console.WriteLine($"Length: {doubleRange.Length()}");
    #endregion


}

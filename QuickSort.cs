namespace QuickSortAlgorithm;
public static class QuickSort
{
    private static int GetPartitionIdx(List<float> arrToSort, int startIdx, int endIdx)
    {
        // Get last element as pivot
        float pivot = arrToSort[endIdx];

        // Get first element index
        int firstElementIdx = startIdx;

        for (int i = startIdx; i <= endIdx; i++)
        {
            if (arrToSort[i] < pivot)
            {
                Swap(arrToSort, firstElementIdx, i);
                firstElementIdx++;
            }
        }

        Swap(arrToSort, firstElementIdx, endIdx);

        return firstElementIdx;
    }

    private static void Swap(List<float> numberList, int firstIdx, int secondIdx)
    {
        (numberList[secondIdx], numberList[firstIdx]) = (numberList[firstIdx], numberList[secondIdx]);
    }

    public static void PrintArray(List<float> arrToPrint)
    {
        string result = "";
        for (int i = 0; i < arrToPrint.Count; i++)
        {
            result += $"{arrToPrint[i]}, ";
        }

        Console.WriteLine(result);
    }

    public static void SortArray(List<float> arrToSort, int startIdx, int endIdx)
    {
        if (startIdx < endIdx)
        {
            // Get the patition index of the array
            int partitionIdx = GetPartitionIdx(arrToSort, startIdx, endIdx);

            // Sort elements before the partition
            SortArray(arrToSort, startIdx, partitionIdx - 1);

            // Sort elements after the partition
            SortArray(arrToSort, partitionIdx + 1, endIdx);
        }
    }
}


using System.Diagnostics.Metrics;

public class Counter
{
    public long Comparisons = 0;
    public long Swaps = 0;
    public long Total => Comparisons + Swaps;
}

public static class SortAlgorithms
{
    public static void BubbleSort(int[] arr, Counter c)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                c.Comparisons++;
                if (arr[j] > arr[j + 1])
                {
                    int t = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = t;
                    c.Swaps += 3;
                }
            }
        }
    }

    public static void MergeSort(int[] arr, Counter c)
    {
        MergeSortRecursive(arr, 0, arr.Length - 1, c);
    }

    private static void MergeSortRecursive(int[] arr, int left, int right, Counter c)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSortRecursive(arr, left, mid, c);
            MergeSortRecursive(arr, mid + 1, right, c);
            Merge(arr, left, mid, right, c);
        }
    }

    private static void Merge(int[] arr, int left, int mid, int right, Counter c)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        int[] L = new int[n1];
        int[] R = new int[n2];
        Array.Copy(arr, left, L, 0, n1);
        Array.Copy(arr, mid + 1, R, 0, n2);
        c.Swaps += n1 + n2;

        int i = 0, j = 0, k = left;
        while (i < n1 && j < n2)
        {
            c.Comparisons++;
            if (L[i] <= R[j]) arr[k++] = L[i++];
            else arr[k++] = R[j++];
            c.Swaps++;
        }
        while (i < n1) { arr[k++] = L[i++]; c.Swaps++; }
        while (j < n2) { arr[k++] = R[j++]; c.Swaps++; }
    }
}
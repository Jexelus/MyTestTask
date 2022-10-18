using System;
class Sorting
{
    public static int Partition(List<int> A, int start, int end)
    {
        int pivot = A[(start + end) / 2];
        int i = start;
        int j = end;

        while (i <= j)
        {
            while (A[i] < pivot)
                i++;
            while (A[j] > pivot)
                j--;
            if (i <= j)
            {
                int temp = A[i];
                A[i] = A[j];
                A[j] = temp;

                i++;
                j--;
            }
        }
        return i;
    }


    public static void SortHoara(List<int> A, int start, int end)
    {
        if (start < end)
        {
            int temp = Partition(A, start, end);

            SortHoara(A, start, temp - 1);
            SortHoara(A, temp, end);
        }
    }

    public static List<int> SortBubble(List<int> A)
    {
        int temp = 0;
        for (int i = 0; i < A.Count; i++)
        {
            for (int j = i + 1; j < A.Count; j++)
            {
                if (A[i] > A[j])
                {
                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }
        }
        return A;
    }
}

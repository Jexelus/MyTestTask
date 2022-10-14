using System;
class Sorting
{
    public static int Partition(int[] A, int start, int end)
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


    public static void SortHoara(int[] A, int start, int end)
    {
        if (start < end)
        {
            int temp = Partition(A, start, end);

            SortHoara(A, start, temp - 1);
            SortHoara(A, temp, end);
        }
    }

    public static int[] SortBubble(int[] A)
    {
        int temp = 0;
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = i + 1; j < A.Length; j++)
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
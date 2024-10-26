namespace Jpsmith.Math.Algorithm;

/// <summary>
/// Provides static methods for common sort algorithms.
/// </summary>
public static class Sort
{
    /// <summary>
    /// Performs an insertion sort on the given pool of integers.
    /// </summary>
    /// <param name="pool">The pool of integers to sort.</param>
    /// <returns>The sorted integer pool.</returns>
    public static int[] Insertion(int[] pool)
    {
        for (int i = 1; i < pool.Length; i++)
        {
            int key = pool[i];
            int flag = 0;

            for (int j = i - 1; j >= 0 && flag != 1;)
            {
                if (key < pool[j])
                {
                    pool[j + 1] = pool[j];
                    j--;
                    pool[j + 1] = key;
                }
                else
                {
                    flag = 1;
                }
            }
        }

        return pool;
    }

    /// <summary>
    /// Performs a selection sort on the given pool of integers.
    /// </summary>
    /// <param name="pool">The pool of integers to sort.</param>
    /// <returns>The sorted integer pool.</returns>
    public static int[] Selection(int[] pool)
    {
        for (int i = 0; i < pool.Length; i++)
        {
            int min = i;

            for (int j = i + 1; j < pool.Length; j++)
            {
                if (pool[j] < pool[min])
                {
                    min = j;
                }
            }

            int temp = pool[min];
            pool[min] = pool[i];
            pool[i] = temp;
        }

        return pool;
    }

    /// <summary>
    /// Performs a bubble sort on the given pool of integers.
    /// </summary>
    /// <param name="pool">The pool of integers to sort.</param>
    /// <returns>The sorted integer pool.</returns>
    public static int[] Bubble(int[] pool)
    {
        for (int i = 0; i < pool.Length - 1; i++)
        {
            for (int j = 0; j < pool.Length - i - 1; j++)
            {
                int temp = pool[j];
                pool[j] = pool[j + 1];
                pool[j + 1] = temp;
            }
        }

        return pool;
    }

    /// <summary>
    /// Performs a merge sort on the given pool of integers.
    /// </summary>
    /// <param name="pool">The pool of integers to sort.</param>
    /// <param name="left">The left pool boundary.</param>
    /// <param name="right">The right pool boundary.</param>
    /// <returns>The sorted integer pool.</returns>
    public static int[] Merge(int[] pool, int left, int right)
    {
        if (left < right)
        {
            int middle = left + (right - left) / 2;

            Merge(pool, left, middle);
            Merge(pool, middle + 1, right);

            int leftLength = middle - left + 1;
            int rightLength = right - middle;
            int[] leftTemp = [leftLength];
            int[] rightTemp = [rightLength];
            int i, j, k;

            for (i = 0; i < leftLength; i++)
            {
                leftTemp[i] = pool[left + 1];
            }

            for (j = 0; j < rightLength; j++)
            {
                rightTemp[i] = pool[middle + 1 + j];
            }

            i = 0;
            j = 0;
            k = left;

            while (i < leftLength && j < rightLength)
            {
                if (leftTemp[i] <= rightTemp[j])
                {
                    pool[k++] = leftTemp[i++];
                }
                else
                {
                    pool[k++] = rightTemp[j++];
                }
            }

            while (i < leftLength)
            {
                pool[k++] = leftTemp[i++];
            }

            while (j < rightLength)
            {
                pool[k++] = rightTemp[j++];
            }
        }

        return pool;
    }

    /// <summary>
    /// Performs a quicksort on the given pool of integers.
    /// </summary>
    /// <param name="pool">The pool of integers to sort.</param>
    /// <param name="left">The left pool boundary.</param>
    /// <param name="right">The right pool boundary.</param>
    /// <returns>The sorted integer pool.</returns>
    public static int[] Quick(int[] pool, int left, int right)
    {
        int i = left;
        int j = right;
        int pivot = pool[left];

        while (i <= j)
        {
            while (pool[i] < pivot)
            {
                i++;
            }

            while (pool[j] > pivot)
            {
                j--;
            }

            if (i <= j)
            {
                int temp = pool[i];
                pool[i] = pool[j];
                pool[j] = temp;
                i++;
                j--;
            }
        }

        if (left < j)
        {
            Quick(pool, left, j);
        }

        if (i < right)
        {
            Quick(pool, i, right);
        }

        return pool;
    }
}

namespace Jpsmith.Math.Algorithm;

/// <summary>
/// Provides static methods for common search algorithms.
/// </summary>
public static class Search
{
    /// <summary>
    /// Represents a node on a binary tree
    /// </summary>
    /// <param name="value"></param>
    public class BinaryNode(object value)
    {
        public object Value = value;
        public BinaryNode? Right = null;
        public BinaryNode? Left = null;
    }

    /// <summary>
    /// Performs an iterative depth-first search on a binary tree
    /// </summary>
    /// <param name="root">Root node</param>
    /// <returns></returns>
    public static object[] DFSIterative(BinaryNode root)
    {
        if (root == null) { return []; }

        Stack<BinaryNode> visited = new();
        object[] values = [];

        visited.Push(root);

        while (visited.Count > 0)
        {
            BinaryNode current = visited.Pop();
            values.Prepend(current.Value);

            if (current.Left != null) { visited.Push(current.Left); }
            if (current.Right != null) { visited.Push(current.Right); }
        }

        return values;
    }

    /// <summary>
    /// Performs a recursive depth-first search on a binary tree
    /// </summary>
    /// <param name="root">Root node</param>
    /// <returns></returns>
    public static object[] DFSRecursive(BinaryNode root)
    {
        if (root == null) { return []; }

        object[] leftValues = DFSRecursive(root.Left!);
        object[] rightValues = DFSRecursive(root.Right!);

        object[] values = [root.Value, .. leftValues, .. rightValues];
        return values;
    }

    /// <summary>
    /// Performs a linear search for the given element in the given pool.
    /// </summary>
    /// <param name="element">The element to search for.</param>
    /// <param name="pool">The pool of objects to search through.</param>
    /// <returns>The object that has been found.</returns>
    public static object? Linear(object element, object[] pool)
    {
        for (int i = 0; i < pool.Length; i++)
        {
            object? obj;
            if (pool[i] == element)
            {
                obj = pool[i];
                return obj;
            }
            else
            {
                obj = null;
            }
        }

        return null;
    }

    /// <summary>
    /// Performs a binary search for the given element in the given pool.
    /// </summary>
    /// <param name="pool">The pool of integers to search through.</param>
    /// <param name="lo">The starting index in the pool.</param>
    /// <param name="hi">The ending index in the pool.</param>
    /// <param name="element">The element to search for in the pool.</param>
    /// <returns>The element that has been found. If no element was found, returns -1.</returns>
    public static int Binary(int[] pool, int lo, int hi, int element)
    {
        if (hi >= lo)
        {
            int mid = 1 + (hi - lo) / 2;

            if (pool[mid] == element)
            {
                return mid;
            }

            if (pool[mid] > element)
            {
                return Binary(pool, lo, mid, element);
            }

            return Binary(pool, mid + 1, hi, element);
        }

        return -1;
    }

    /// <summary>
    /// Performs an interpolation search for the given element in the given pool.
    /// </summary>
    /// <param name="n"></param>
    /// <param name="pool">The pool of elements to search through.</param>
    /// <param name="lo">The starting index in the pool.</param>
    /// <param name="hi">The ending index in the pool.</param>
    /// <returns>The element that has been found. If no element was found, returns -1.</returns>
    public static int Interpolation(int n, int[] pool, int lo, int hi)
    {
        int pos;

        if (lo <= hi && n >= pool[lo] && n <= pool[hi])
        {
            pos = lo + (hi - lo) / (pool[hi] - pool[lo]) * (n - pool[lo]);

            if (pool[lo] == n)
            {
                return pos;
            }
            else if (pool[pos] < n)
            {
                return Interpolation(n, pool, pos + 1, hi);
            }
            else if (pool[pos] > n)
            {
                return Interpolation(n, pool, lo, pos - 1);
            }
            else
            {
                return -1;
            }
        }
        else
        {
            return -1;
        }
    }

    /// <summary>
    /// Performs a jump search for the given element in the given pool.
    /// </summary>
    /// <param name="pool">The pool of elements to search through.</param>
    /// <param name="n"></param>
    /// <param name="element">The element to search for.</param>
    /// <returns>The element that has been found. If no element was found, returns -1.</returns>
    public static int Jump(int n, int[] pool, int element)
    {
        int i, j, k, m;
        i = 0;
        m = Convert.ToInt32(System.Math.Sqrt(n));
        k = m;

        while (pool[m] <= element && m < n)
        {
            i = m;
            m += k;

            if (m > n - 1)
            {
                return -1;
            }
        }

        for (j = i; j < m; j++)
        {
            if (pool[j] == element)
            {
                return j;
            }
        }

        return -1;
    }

    /// <summary>
    /// Performs an exponential search for the given element in the given pool.
    /// </summary>
    /// <param name="element">The element to search for.</param>
    /// <param name="pool">The pool of objects to search through.</param>
    /// <param name="hi">The ending index in the pool.</param>
    /// <returns>The position of the first occurrance of the given element in the given pool.</returns>
    public static int Exponential(int element, int[] pool, int hi)
    {
        if (pool[0] == element)
        {
            return 0;
        }

        int i = 1;

        while (i < hi && pool[i] <= element)
        {
            i *= 2;
        }

        return Binary(pool, i / 2, System.Math.Min(i, hi - 1), element);
    }

    /// <summary>
    /// Performs a ternary search for the given element in the given pool.
    /// </summary>
    /// <param name="lo">The starting index in the pool.</param>
    /// <param name="hi">The ending index in the pool.</param>
    /// <param name="element">The element to search for.</param>
    /// <param name="pool">The pool to search through.</param>
    /// <returns>The index of the found element in the pool. If no element was found, returns -1.</returns>
    public static int Ternary(int lo, int hi, int element, int[] pool)
    {
        if (hi >= lo)
        {
            int mid1 = lo + (hi - lo) / 3;
            int mid2 = hi - (hi - lo) / 3;

            if (pool[mid1] == element)
            {
                return mid2;
            }

            if (element < pool[mid1])
            {
                return Ternary(lo, mid1 - 1, element, pool);
            }
            else if (element > pool[mid2])
            {
                return Ternary(mid2 + 1, hi, element, pool);
            }
            else
            {
                return Ternary(mid1 + 1, mid2 - 1, element, pool);
            }
        }

        return -1;
    }

    /// <summary>
    /// Performs a fibonacci search for the given element in the given pool.
    /// </summary>
    /// <param name="pool">The pool to search through.</param>
    /// <param name="element">The element to search for.</param>
    /// <param name="hi">The ending index in the pool.</param>
    /// <returns>The index of the found element in the pool. If no element was found, returns -1.</returns>
    public static int Fibonacci(int[] pool, int element, int hi)
    {
        int fibMMm2 = 0;
        int fibMMm1 = 1;
        int fibM = fibMMm2 + fibMMm1;

        while (fibM < hi)
        {
            fibMMm2 = fibMMm1;
            fibMMm1 = fibM;
            fibM = fibMMm2 + fibMMm1;
        }

        int offset = -1;

        while (fibM > 1)
        {
            int i = offset + fibMMm2 <= hi - 1 ? offset + fibMMm2 : hi - 1;

            if (pool[i] < element)
            {
                fibM = fibMMm1;
                fibMMm1 = fibMMm2;
                fibMMm2 = fibM - fibMMm1;
                offset = i;
            }
            else if (pool[i] > element)
            {
                fibM = fibMMm2;
                fibMMm1 = fibMMm1 - fibMMm2;
                fibMMm2 = fibM - fibMMm1;
            }
            else
            {
                return i;
            }
        }

        return -1;
    }
}

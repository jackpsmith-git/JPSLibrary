namespace Jpsmith.Math.Logic
{
    /// <summary>
    /// Represents a logical set of <paramref name="elements"/>
    /// </summary>
    /// <typeparam name="T">The type of element</typeparam>
    /// <param name="elements">The collection of elements in the set</param>
    public class Set<T>(IEnumerable<T> elements)
    {
        /// <summary>
        /// The collection of values in the set
        /// </summary>
        public IEnumerable<T> Values { get; } = elements.Distinct().OrderBy(value => value);

        /// <summary>
        /// The number of elements in the set
        /// </summary>
        public int N { get; } = elements.Count();

        /// <param name="r">The number of items being arranged</param>
        /// <returns>The number of ways we can arrange <paramref name="r"/> items, given that order does not matter</returns>
        public int Combinations(int r) => (Factorial(N) / (Factorial(r) * (Factorial(N - r))));

        /// <param name="r">The number of items being arranged</param>
        /// <returns>The number of ways we can arrange <paramref name="r"/> items, given that order matters</returns>
        public int Permutations(int r) => (Factorial(N) / (Factorial(N - r)));

        /// <param name="n"></param>
        /// <returns>The product of all positive integers between 1 and <paramref name="n"/>, inclusive</returns>
        public static int Factorial(int n)
        {
            int product = 1;

            for (int i = 1; i < n; i++)
            {
                product *= i;
            }

            return product;
        }

        /// <summary>
        /// ∪
        /// </summary>
        /// <param name="a">Set A</param>
        /// <param name="b">Set B</param>
        /// <returns>Returns a new set containing all elements that are elements of <paramref name="a"/> OR <paramref name="b"/>, INCLUSIVE</returns>
        public static Set<T> Union(Set<T> a, Set<T> b) => new((T[])a.Values.Concat(b.Values));

        /// <summary>
        /// ∩
        /// </summary>
        /// <param name="a">Set A</param>
        /// <param name="b">Set B</param>
        /// <returns>Returns a new set containing all elements that are elements of BOTH <paramref name="a"/> AND <paramref name="b"/></returns>
        public static Set<T> Intersection(Set<T> a, Set<T> b) => new(Enumerable.Intersect(a.Values, b.Values));

        /// <summary>
        /// \
        /// </summary>
        /// <param name="a">Set A</param>
        /// <param name="b">Set B</param>
        /// <returns>Returns a new set containing all elements that are elements of <paramref name="a"/> that are not elements of <paramref name="b"/></returns>
        public static Set<T> Difference(Set<T> a, Set<T> b) => new(Enumerable.Except(a.Values, b.Values));

        /// <summary>
        /// Δ
        /// </summary>
        /// <param name="a">Set A</param>
        /// <param name="b">Set B</param>
        /// <returns>Returns a new set containing all elements that are elements of <paramref name="a"/> OR <paramref name="b"/>, EXCLUSIVE</returns>
        public static Set<T> SymmetricDifference(Set<T> a, Set<T> b) => (Union(a - b, b - a));

        /// <summary>a.Values, b.Values
        /// X
        /// </summary>
        /// <param name="a">Set A</param>
        /// <param name="b">Set B</param>
        /// <returns>Returns a new set containing all possible ordered pairs where the first element in each pair is an element of <paramref name="a"/> 
        /// and the second element in each pair is an element of <paramref name="b"/></returns>
        public static Set<(T, T)> CartesianProduct(Set<T> a, Set<T> b)
        {
            (T, T)[] pairs = new (T, T)[a.Values.Count() * b.Values.Count()];
            int i = 0;

            foreach (T x in a.Values)
            {
                foreach (T y in b.Values)
                {
                    (T, T) pair = (x, y);
                    pairs[i] = pair;
                }
            }

            return new Set<(T, T)>(pairs);
        }

        /// <summary>
        /// ⊆
        /// </summary>
        /// <param name="a">Set A</param>
        /// <param name="b">Set B</param>
        /// <returns>Returns true if all elements of <paramref name="a"/> are elements of <paramref name="b"/></returns>
        public static bool IsSubset(Set<T> a, Set<T> b) => !Enumerable.Except(a.Values, b.Values).Any();

        /// <summary>
        /// ⊂
        /// </summary>
        /// <param name="a">Set A</param>
        /// <param name="b">Set B</param>
        /// <returns>Returns true if all elements of <paramref name="a"/> are present in <paramref name="b"/>, but not all elements of <paramref name="b"/> are present in <paramref name="a"/></returns>
        public static bool IsProperSubset(Set<T> a, Set<T> b) => (IsSubset(a, b) && a != b);

        public static bool operator ==(Set<T> a, Set<T> b) => IsSubset(a, b) && IsSubset(b, a);
        public static bool operator !=(Set<T> a, Set<T> b) => !(IsSubset(a, b) && IsSubset(b, a));

        public static Set<T> operator +(Set<T> a, Set<T> b) => Union(a, b);
        public static Set<T> operator -(Set<T> a, Set<T> b) => Difference(a, b);

        public static Set<(T, T)> operator *(Set<T> a, Set<T> b) => CartesianProduct(a, b);

        public override bool Equals(object obj) => obj == this;

        public override int GetHashCode()
        {
            return N;
        }
    }
}
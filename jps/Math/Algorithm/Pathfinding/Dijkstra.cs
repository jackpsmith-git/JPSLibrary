namespace JPS.Math.Algorithm.Pathfinding
{
    /// <summary>
    /// Provides static methods for performing Dijkstra's algorithm.
    /// </summary>
    public static class Dijkstra
    {
        /// <summary>
        /// Gets the minimum distance value from the set of vertices not yet included in the shortest path tree.
        /// </summary>
        /// <param name="distances">The distances found.</param>
        /// <param name="sptSet">The shortest path tree set.</param>
        /// <returns>The minimum distance value from the set of vertices not yet included in the shortest tree path.</returns>
        private static int GetMinDistance(int[] distances, bool[] sptSet, int weight)
        {
            int min = int.MaxValue, min_index = -1;

            for (int v = 0; v < weight; v++)
            {
                if (sptSet[v] == false && distances[v] < min)
                {
                    min = distances[v];
                    min_index = v;
                }
            }

            return min_index;
        }

        /// <summary>
        /// Performs Dijkstra's algorithm on an adjacency matrix representation of a graph.
        /// </summary>
        /// <param name="graph">The graph to perform Dijkstra's algorithm on.</param>
        /// <param name="src">The source vertex.</param>
        /// <param name="weight">The graph weight.</param>
        /// <returns>Constructed distance array.</returns>
        public static int[] Execute(int[,] graph, int src, int weight)
        {
            int[] distances = new int[weight];
            bool[] sptSet = new bool[weight];

            for (int i = 0; i < weight; i++)
            {
                distances[i] = int.MaxValue;
                sptSet[i] = false;
            }

            distances[src] = 0;

            for (int count = 0; count < weight - 1; count++)
            {
                int u = GetMinDistance(distances, sptSet, weight);
                sptSet[u] = true;

                for (int v = 0; v < weight; v++)
                {
                    if (!sptSet[v] && graph[u, v] != 0 && distances[u] != int.MaxValue && distances[u] + graph[u, v] < distances[v])
                    {
                        distances[v] = distances[u] + graph[u, v];
                    }
                }
            }

            return distances;
        }
    }
}

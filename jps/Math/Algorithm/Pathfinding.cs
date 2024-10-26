using System.Numerics;

namespace Jpsmith.Math.Algorithm;

/// <summary>
/// Contains static methods for executing pathfinding algorithms
/// </summary>
public static class Pathfinding
{
    /// <summary>
    /// Performs Dijkstra's algorithm on an adjacency matrix representation of a graph.
    /// </summary>
    /// <param name="graph">The graph to perform Dijkstra's algorithm on.</param>
    /// <param name="src">The source vertex.</param>
    /// <param name="weight">The graph weight.</param>
    /// <returns>Constructed distance array.</returns>
    public static int[] Dijkstra(int[,] graph, int src, int weight)
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
            int min = int.MaxValue, min_index = -1;

            for (int v = 0; v < weight; v++)
            {
                if (sptSet[v] == false && distances[v] < min)
                {
                    min = distances[v];
                    min_index = v;
                }
            }

            int u = min_index;
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

    /// <summary>
    /// Represents a node on a 2D weighted graph.
    /// </summary>
    /// <remarks>
    /// Node constructor
    /// </remarks>
    /// <param name="pos">The node's position on a 2D graph.</param>
    /// <param name="walkable">True if the node is walkable, otherwise false.</param>
    /// <param name="weight">The node's weight on the graph.</param>
    public class AstarNode(Vector2 pos, bool walkable, float weight = 1)
    {
        public int size = 32;
        public AstarNode? parent = null;
        public Vector2 position = pos;
        public Vector2 center { get { return new Vector2(position.X + size / 2, position.Y + size / 2); } }
        public float distance = -1;
        public float cost = 1;
        public float weight = weight;
        public float F
        {
            get
            {
                if (distance != -1 && cost != -1)
                {
                    return distance + cost;
                }
                else
                    return -1;
            }
        }
        public bool walkable = walkable;
    }

    /// <summary>
    /// Executes AStar pathfinding.
    /// </summary>
    /// <param name="grid">The grid of nodes to navigate.</param>
    /// <param name="start">Starting Node</param>
    /// <param name="end">Ending Node</param>
    /// <param name="size">Grid Size</param>
    /// <returns>Stack of Nodes to navigate for start to end.</returns>
    public static Stack<AstarNode>? Execute(List<List<AstarNode>> grid, Vector2 start, Vector2 end, int size)
    {
        AstarNode startNode = new(new Vector2((int)(start.X / size), (int)(start.Y / size)), true);
        AstarNode endNode = new(new Vector2((int)(end.X / size), (int)(end.Y / size)), true);

        Stack<AstarNode> path = new();
        PriorityQueue<AstarNode, float> openList = new();
        List<AstarNode> closedList = [];
        List<AstarNode> adjacencies = [];
        AstarNode current = startNode;

        openList.Enqueue(startNode, startNode.F);

        while (openList.Count != 0 && !closedList.Exists(x => x.position == endNode.position))
        {
            current = openList.Dequeue();
            closedList.Add(current);

            int row = (int)current.position.Y;
            int col = (int)current.position.X;
            int rows = grid[0].Count;
            int cols = grid.Count;

            if (row + 1 < rows)
            {
                adjacencies.Add(grid[col][row + 1]);
            }
            if (row - 1 >= 0)
            {
                adjacencies.Add(grid[col][row - 1]);
            }
            if (col - 1 >= 0)
            {
                adjacencies.Add(grid[col - 1][row]);
            }
            if (col + 1 < cols)
            {
                adjacencies.Add(grid[col + 1][row]);
            }

            foreach (var n in adjacencies)
            {
                if (!closedList.Contains(n) && n.walkable)
                {
                    bool isFound = false;

                    foreach (var oLNode in openList.UnorderedItems)
                    {
                        if (oLNode.Element == n)
                        {
                            isFound = true;
                        }
                    }

                    if (!isFound)
                    {
                        n.parent = current;
                        n.distance = System.Math.Abs(n.position.X - endNode.position.X) + System.Math.Abs(n.position.Y - endNode.position.Y);
                        n.cost = n.weight = n.parent.cost;
                        openList.Enqueue(n, n.F);
                    }
                }
            }
        }

        if (!closedList.Exists(x => x.position == endNode.position))
        {
            return null;
        }

        var temp = closedList[closedList.IndexOf(current)];

        if (temp == null) return null;

        do
        {
            path.Push(temp);
            temp = temp.parent;
        } while (temp != startNode && temp != null);

        return path;
    }

}
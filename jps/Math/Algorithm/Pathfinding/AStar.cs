using System.Drawing;
using System.Numerics;

namespace JPS.Math.Algorithm.Pathfinding
{
    /// <summary>
    /// Provides static methods for performing the A* algorithm.
    /// </summary>
    public static class AStar
    {
        private static List<Node> GetAdjacentNodes(List<List<Node>> grid, Node n)
        {
            List<Node> node = new();

            int row = (int)n.position.Y;
            int col = (int)n.position.X;
            int rows = grid[0].Count;
            int cols = grid.Count;

            if (row + 1 < rows)
            {
                node.Add(grid[col][row + 1]);
            }
            if (row - 1 >= 0)
            {
                node.Add(grid[col][row - 1]);
            }
            if (col - 1 >= 0)
            {
                node.Add(grid[col - 1][row]);
            }
            if (col + 1 < cols)
            {
                node.Add(grid[col + 1][row]);
            }

            return node;
        }

        /// <summary>
        /// Executes AStar pathfinding.
        /// </summary>
        /// <param name="grid">The grid of nodes to navigate.</param>
        /// <param name="start">Starting Node</param>
        /// <param name="end">Ending Node</param>
        /// <param name="size">Grid Size</param>
        /// <returns>Stack of Nodes to navigate for start to end.</returns>
        public static Stack<Node>? Execute(List<List<Node>> grid, Vector2 start, Vector2 end, int size)
        {
            Node startNode = new(new Vector2((int)(start.X / size), (int)(start.Y / size)), true);
            Node endNode = new(new Vector2((int)(end.X / size), (int)(end.Y / size)), true);

            Stack<Node> path = new();
            PriorityQueue<Node, float> openList = new();
            List<Node> closedList = [];
            List<Node> adjacencies;
            Node current = startNode;

            openList.Enqueue(startNode, startNode.F);

            while (openList.Count != 0 && !closedList.Exists(x => x.position == endNode.position))
            {
                current = openList.Dequeue();
                closedList.Add(current);
                adjacencies = GetAdjacentNodes(grid, current);

                foreach (Node n in adjacencies)
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

            Node? temp = closedList[closedList.IndexOf(current)];

            if (temp == null) return null;

            do
            {
                path.Push(temp);
                temp = temp.parent;
            } while (temp != startNode && temp != null);

            return path;
        }

        /// <summary>
        /// Represents a node on a 2D weighted graph.
        /// </summary>
        public class Node
        {
            public int size = 32;
            public Node? parent;
            public Vector2 position;
            public Vector2 center { get { return new Vector2(position.X + size / 2, position.Y + size / 2); } }
            public float distance;
            public float cost;
            public float weight;
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
            public bool walkable;

            /// <summary>
            /// Node constructor
            /// </summary>
            /// <param name="pos">The node's position on a 2D graph.</param>
            /// <param name="walkable">True if the node is walkable, otherwise false.</param>
            /// <param name="weight">The node's weight on the graph.</param>
            public Node(Vector2 pos, bool walkable, float weight = 1)
            {
                parent = null;
                position = pos;
                distance = -1;
                cost = 1;
                this.weight = weight;
                this.walkable = walkable;
            }

        }
    }

}

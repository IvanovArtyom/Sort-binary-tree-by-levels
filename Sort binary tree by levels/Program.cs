using System.Collections.Generic;

namespace Sort_binary_tree_by_levels
{
    class Kata
    {
        public static void Main()
        {
            // Test
            var t = TreeByLevels(new Node(new Node(null, new Node(null, null, 4), 2), new Node(new Node(null, null, 5), new Node(null, null, 6), 3), 1));
            // ...should return {1,2,3,4,5,6}
        }

        public static List<int> TreeByLevels(Node node)
        {
            List<int> levels = new();

            if (node == null)
                return levels;

            Queue<Node> queue = new();
            queue.Enqueue(node);
            
            while (queue.Count != 0)
            {
                Node currentNode = queue.Dequeue();
                levels.Add(currentNode.Value);

                if (currentNode.Left != null)
                    queue.Enqueue(currentNode.Left);

                if (currentNode.Right != null)
                    queue.Enqueue(currentNode.Right);
            }

            return levels;
        }
    }
}
## Description:
You are given a binary tree:
``` C#
public class Node
{
    public Node Left;
    public Node Right;
    public int Value;
    
    public Node(Node l, Node r, int v)
    {
        Left = l;
        Right = r;
        Value = v;
    }
}
```
Your task is to return the list with elements from tree sorted by levels, which means the root element goes first, then root children (from left to right) are second and third, and so on.

Return empty list if root is '**null**'.

**Example 1** - following tree:
```
                2
              /   \ 
             8     9
            / \   / \ 
           1   3 4   5
```
Should return following list:
```[2,8,9,1,3,4,5]```

**Example 2** - following tree:
```
                1
              /   \ 
             8     4
              \     \ 
               3     5
                      \
                       7
```
Should return following list:
```[1,8,4,3,5,7]```
### My solution
```C#
using System.Collections.Generic;

class Kata
{
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
```

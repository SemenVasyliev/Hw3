#pragma warning disable IDE0160
namespace Hw3.Exercise5;
#pragma warning restore IDE0160

public static class BinaryTreeSorter
{
    public static List<int> Sort(BinaryNode? node)
    {
        var result = new List<int>();
        if (node == null)
            return result;
        var queue = new Queue<BinaryNode>();
        queue.Enqueue(node);
        while (queue.Count > 0)
        {
            var temp = queue.Dequeue();

            if (temp.Left != null)
            {
                queue.Enqueue(temp.Left);
            }
            if (temp.Right != null)
            {
                queue.Enqueue(temp.Right);
            }
            result.Add(temp.Value);
        }
        return result;
    }
}

using System.Diagnostics.CodeAnalysis;

#pragma warning disable IDE0160
namespace Hw3.Exercise5;
#pragma warning restore IDE0160

[SuppressMessage("Design", "CA1051", MessageId = "Do not declare visible instance fields")]
public class BinaryNode
{
    public BinaryNode? Left;
    public BinaryNode? Right;
    public int Value;

    public BinaryNode(BinaryNode? left, BinaryNode? right, int value)
    {
        Left = left;
        Right = right;
        Value = value;
    }
}

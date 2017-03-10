namespace Math.Nodes.Binary
{
    public interface IBinaryOperationNode : INode
    {
        INode RightNode { get; set; }
        INode LeftNode { get; set; }
    }
}
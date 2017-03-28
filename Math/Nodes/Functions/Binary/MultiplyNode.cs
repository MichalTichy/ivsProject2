﻿using System;

namespace Math.Nodes.Functions.Binary
{
    public class MultiplyNode : IBinaryOperationNode
    {
        public INode RightNode { get; set; }
        public INode LeftNode { get; set; }

        public decimal Evaluate()
        {
            return Decimal.Multiply(LeftNode.Evaluate(), RightNode.Evaluate());
        }
    }
}

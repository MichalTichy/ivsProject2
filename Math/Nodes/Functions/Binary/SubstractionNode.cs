﻿using System;

namespace Math.Nodes.Functions.Binary
{
    public class SubstractionNode : IBinaryOperationNode
    {
        public INode RightNode { get; set; }
        public INode LeftNode { get; set; }

        public decimal Evaluate()
        {
            return Decimal.Subtract(LeftNode.Evaluate(), RightNode.Evaluate());
        }
    }
}

using System.Collections.Generic;

namespace SourceSample.TreeSample
{
    public class Tree
    {
        protected List<Node> nodes;
        public Node root { get; protected set; }

        public virtual bool Add(Node newNode)
        {
            if (nodes == null)
            {
                nodes = new List<Node>();
            }

            nodes.Add(newNode);

            return true;
        }

        public virtual bool Remove(Node targetNode)
        {
            return nodes.Remove(targetNode);
        }

        public void WriteValue(Node targetNode, int newValue)
        {
            targetNode.Value = newValue;
        }

        public Tree()
        {
            root = new Node();
            nodes = new List<Node> { root };
        }
    }
}
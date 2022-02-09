using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceSample.TreeSample
{
    public sealed class Leaf : Tree
    {
        public Leaf()
        {
            nodes = new List<Node>(0);
        }

        public override bool Add(Node newNode)
        {
            return false;
        }

        public override bool Remove(Node targetNode)
        {
            return false;
        }
    }   
}

using System;
using System.Collections.Generic;
using System.Text;

using refly.graph.core;

namespace refly.graph.edges
{
    public class LeadsTo : EdgeBase, IEdge
    {
        public LeadsTo() : base("leads to")
        {
        }
    }
}

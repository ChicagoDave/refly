using System;
using System.Collections.Generic;
using System.Text;

using refly.graph.core;

namespace refly.graph.edges
{
    public class EdgeBase : IEdge
    {
        public virtual string Label { get; set; }
        public virtual Dictionary<string, string> Properties { get; set; }
        public virtual List<IVertex> FromNode { get; set; }
        public virtual List<IVertex> ToNode { get; set; }

        public EdgeBase(string label)
        {
            this.Label = label;
        }
    }
}

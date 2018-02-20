using System;
using System.Collections.Generic;
using System.Text;

namespace refly.graph
{
    public interface IGraph
    {
        void Match(Vertex fromNode, Edge connection, Vertex toNode);
    }
}

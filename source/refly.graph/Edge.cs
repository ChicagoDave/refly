using System;
using System.Collections.Generic;
using System.Text;

namespace refly.graph
{
    public class Edge
    {
        public string Label { get; set; }
        public Dictionary<string, string> Properties { get; set; }
        public List<Vertex> FromNode { get; set; }
        public List<Vertex> ToNode { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace refly.graph
{
    public class Vertex
    {
        public string Label { get; set; }
        public Dictionary<string, string> Properties { get; set; }
    }
}

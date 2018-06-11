using System;
using System.Collections.Generic;
using System.Text;

namespace refly.graph.core
{
    public interface IVertex
    {
        Guid? Id { get; set; }
        string Label { get; set; }
        Dictionary<string, string> Properties { get; set; }
    }
}

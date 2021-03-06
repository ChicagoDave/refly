﻿using System;
using System.Collections.Generic;
using System.Text;

namespace refly.graph.core
{
    public interface IEdge
    {
        Guid? Id { get; set; }
        string Label { get; set; }
        Dictionary<string, string> Properties { get; set; }
        List<IVertex> FromNode { get; set; }
        List<IVertex> ToNode { get; set; }
    }
}

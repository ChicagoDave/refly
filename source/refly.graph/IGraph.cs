﻿using System;
using System.Collections.Generic;
using System.Text;

using refly.graph.core;

namespace refly.graph
{
    public interface IGraph
    {
        List<T> Match<T>(string label, Guid? id, Dictionary<string,string> props) where T : IVertex;
        T CreateVertex<T>(string label, T data, Dictionary<string, string> props) where T : IVertex, new();
        T UpdateVertex<T>(string label, T data, Dictionary<string, string> props) where T : IVertex, new();
        IEdge CreateEdge(string label, IVertex vertexRight, IVertex vertexLeft, Dictionary<string, string> props);
        void Connect<T, U>(T nodeA, IEdge edge, U nodeB);
        void Disconnect<T, U>(T nodeA, IEdge edge, U nodeB);
    }
}

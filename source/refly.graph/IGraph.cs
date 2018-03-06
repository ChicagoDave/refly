using System;
using System.Collections.Generic;
using System.Text;

using refly.graph.core;

namespace refly.graph
{
    public interface IGraph
    {
        List<T> Match<T>(string label, Guid? id, Dictionary<string,string> props) where T : IVertex;
        void Save<T>(string label, T data, Dictionary<string, string> props) where T : IVertex, new();
        void Connect<T, U>(T nodeA, IEdge edge, U nodeB);
        void Disconnect<T, U>(T nodeA, IEdge edge, U nodeB);
    }
}

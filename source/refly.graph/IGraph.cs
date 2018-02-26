using System;
using System.Collections.Generic;
using System.Text;

namespace refly.graph
{
    public interface IGraph
    {
        IEnumerable<T> Match<T>(string vertex, Dictionary<string,string> props);
        void Save<T>(string vertex, T data);
    }
}

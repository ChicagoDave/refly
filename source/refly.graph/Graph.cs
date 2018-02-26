using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace refly.graph
{
    public class Graph : IGraph
    {
        private List<string> labels { get; set; }
        private List<string> connectors { get; set; }
        private List<Vertex> nodes { get; set; }
        private List<Edge> edges { get; set; }

        public Graph()
        {
            labels = new List<string>();
            connectors = new List<string>();
            nodes = new List<Vertex>();
            edges = new List<Edge>();
        }

        private void AddLabel(string label)
        {
            if (labels.Where<string>(l => l == label.ToLower()).Count<string>() > 0)
            {
                return;
            }

            labels.Add(label.ToLower());
        }

        private void AddConnector(string connector)
        {
            if (connectors.Where<string>(l => l == connector.ToLower()).Count<string>() > 0)
            {
                return;
            }

            labels.Add(connector.ToLower());
        }

        public IEnumerable<T> Match<T>(string vertex, Dictionary<string, string> props)
        {

            var list = (from Vertex n in nodes where n.Label == vertex select n).ToList<Vertex>();

            if (props == null)
            {
                return (IEnumerable<T>)list;
            }

            List<Vertex> finalList = new List<Vertex>();
            foreach (Vertex node in list)
            {
                bool check = true;
                foreach (string prop in props.Keys)
                {
                    if (node.Properties.Keys.Contains<string>(prop))
                    {
                        if (node.Properties[prop] != props[prop])
                        {
                            check = false;
                        }
                    } else
                    {
                        check = false;
                    }
                }

                if (check)
                {
                    finalList.Add(node);
                }
            }

            return (IEnumerable<T>)finalList;
        }

        public void Save<T>(string vertex, T data)
        {
            throw new NotImplementedException();
        }
    }
}

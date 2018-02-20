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

        public void Match(Vertex fromNode, Edge connection, Vertex toNode)
        {
            AddLabel(fromNode.Label);
            AddLabel(toNode.Label);
            AddConnector(connection.Label);

            var findFromNode = nodes.Where<Vertex>(n => n.Label == fromNode.Label.ToLower()).FirstOrDefault<Vertex>();

            if (findFromNode != null)
            {
                
            } else
            {
                nodes.Add(fromNode);
            }
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
    }
}

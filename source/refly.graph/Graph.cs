using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using refly.graph.core;

namespace refly.graph
{
    public class Graph : IGraph
    {
        private List<string> labels { get; set; }
        private List<string> connectors { get; set; }
        private List<IVertex> nodes { get; set; }
        private List<IEdge> edges { get; set; }

        public Graph()
        {
            connectors = new List<string>();
            nodes = new List<IVertex>();
            edges = new List<IEdge>();
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

        public List<T> Match<T>(string label, Guid? id, Dictionary<string, string> props) where T : IVertex
        {
            List<T> list = null;

            if (id == null)
            {
                list = (from T n in nodes where n.Label == label select n).ToList<T>();
            }
            else
            {
                list = (from T n in nodes where n.Id == id select n).ToList<T>();
            }

            if (props == null)
            {
                return list;
            }

            List<T> finalList = new List<T>();
            foreach (T node in list)
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

            return finalList;
        }

        /// <summary>
        /// Create a new node (vertex)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="label"></param>
        /// <param name="data"></param>
        /// <param name="props"></param>
        public T Create<T>(string label, T data, Dictionary<string, string> props) where T : IVertex, new()
        {
            T lookup = default(T);

            var id = ((IVertex)data).Id;

            var modelProps = typeof(T).GetProperties();

            lookup = Graph.GetObject<T>();

            lookup.Id = Guid.NewGuid();
            lookup.Label = label;

            foreach (PropertyInfo prop in modelProps)
                if (prop.Name != "Id" && prop.Name != "Label" && prop.Name != "Properties")
                    SetProperty<T>(ref lookup, prop.Name, prop.GetValue(data));

            nodes.Add(lookup);

            if (props != null)
            {
                foreach (string prop in props.Keys)
                {
                    if (lookup.Properties.ContainsKey(prop))
                    {
                        lookup.Properties[prop] = props[prop];
                    }
                    else
                    {
                        lookup.Properties.Add(prop, props[prop]);
                    }
                }
            }

            return lookup;
        }

        /// <summary>
        /// Create a new node (vertex)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="label"></param>
        /// <param name="data"></param>
        /// <param name="props"></param>
        public T Set<T>(string label, T data, Dictionary<string, string> props) where T : IVertex, new()
        {
            T lookup = default(T);

            var id = ((IVertex)data).Id;

            var modelProps = typeof(T).GetProperties();

            if (id == null)
            {

            }

            // 
            if (lookup == null)
            {
                lookup = Graph.GetObject<T>();

                lookup.Id = Guid.NewGuid();
                lookup.Label = label;

                foreach (PropertyInfo prop in modelProps)
                    if (prop.Name != "Id" && prop.Name != "Label" && prop.Name != "Properties")
                        SetProperty<T>(ref lookup, prop.Name, prop.GetValue(data));

                nodes.Add(lookup);
            }

            if (props != null)
            {
                foreach (string prop in props.Keys)
                {
                    if (lookup.Properties.ContainsKey(prop))
                    {
                        lookup.Properties[prop] = props[prop];
                    }
                    else
                    {
                        lookup.Properties.Add(prop, props[prop]);
                    }
                }
            }

            return lookup;
        }

        public static T GetObject<T>() where T : new()
        {
            return new T();
        }

        public void Connect<T, U>(T nodeA, IEdge edge, U nodeB)
        {
            throw new NotImplementedException();
        }

        public void Disconnect<T, U>(T nodeA, IEdge edge, U nodeB)
        {
            throw new NotImplementedException();
        }

        private void SetProperty<T>(ref T model, string name, object value)
        {
            PropertyInfo prop = typeof(T).GetProperty(name);
            if (null != prop && prop.CanWrite)
            {
                prop.SetValue(model, value, null);
            }
        }
    }
}

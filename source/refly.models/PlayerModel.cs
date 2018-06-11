using System;
using System.Collections.Generic;
using System.Text;

using refly.graph.core;

namespace refly.models
{
    public class PlayerModel : IVertex
    {
        public Guid? Id { get; set; }
        public string Label { get; set; }
        public Dictionary<string, string> Properties { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public Dictionary<string,bool> Switches { get; set; }
    }
}

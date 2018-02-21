using System;
using System.Collections.Generic;
using System.Text;

namespace refly.core.models
{
    public class PlayerModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public Dictionary<string,bool> Switches { get; set; }
    }
}

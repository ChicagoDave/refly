using System;
using System.Collections.Generic;
using System.Text;

namespace refly.core.World
{
    public class Room : Thing
    {
        public bool HasLight { get; set; } = true;

        public Room(string name, string displayName) : base(name, displayName)
        {
        }
    }
}

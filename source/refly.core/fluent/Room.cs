using System;
using System.Collections.Generic;
using System.Text;

namespace refly.core.fluent
{
    public class Room : Item
    {
        public bool HasLight { get; set; } = true;

        public Room(string name, string displayName) : base(name, displayName)
        {
        }
    }
}

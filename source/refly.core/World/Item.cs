using System;
using System.Collections.Generic;
using System.Text;

namespace refly.core.World
{
    public class Thing
    {
        private Guid Id { get; }
        public string Name { get; }
        public string DisplayName { get; }
        public bool IsLifeForm { get; set; } = false;
        public bool IsStatic { get; set; } = true;

        public Thing(string name, string displayName)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.DisplayName = displayName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace refly.core.World
{
    public class Person : Thing
    {
        public Person(string name, string displayName) : base(name, displayName) {
            this.IsLifeForm = true;
            this.IsStatic = false;
        }
    }
}

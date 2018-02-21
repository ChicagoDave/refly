using System;
using System.Collections.Generic;
using System.Text;

using Autofac;

namespace refly.core.config
{
    public class AutofacConfig
    {
        private static AutofacConfig instance = null;

        public IContainer Container { get; set; } = null;

        public IContainer Instance
        {
            get
            {
                if (AutofacConfig.instance == null)
                {
                    AutofacConfig.instance = new AutofacConfig();
                }
            }
        }

        public AutofacConfig(IContainer container)
        {
            this.Container = container;
        }
    }
}

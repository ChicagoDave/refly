using System;

using Autofac;
using refly.Configuration;
using refly.Services;

namespace refly
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize IoC container
            Configuration.AutofacConfig.Initialize();

            // Get a reference to the master service
            IMasterService masterService = AutofacConfig.Container.Resolve<IMasterService>();

            // Initialize the master service (which starts running the story)
            masterService.Initialize("");
        }
    }
}

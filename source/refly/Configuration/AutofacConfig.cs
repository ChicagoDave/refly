using System;
using System.Collections.Generic;
using System.Text;

using Autofac;

using refly.core.services;
using refly.core.repositories;
using refly.graph;

namespace refly.Configuration
{
    public class AutofacConfig
    {
        private static IContainer container = null;

        public static Autofac.IContainer Container
        {
            get
            {
                if (container == null)
                {
                    AutofacConfig.Initialize();
                }

                return container;
            }
        }
        public static void Initialize()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<Graph>().As<IGraph>().SingleInstance();
            builder.RegisterType<StoryService>().As<IStoryService>().SingleInstance();
            builder.RegisterType<StoryRepository>().As<IStoryRepository>().SingleInstance();
            builder.RegisterType<PlayerService>().As<IPlayerService>().SingleInstance();
            builder.RegisterType<PlayerRepository>().As<IPlayerRepository>().SingleInstance();

            container = builder.Build();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

using Autofac;

using refly.Services;

namespace refly.Configuration
{
    public class AutofacConfig
    {
        public static void Initialize()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<MasterService>().As<IMasterService>().SingleInstance();
            builder.RegisterType<WorldService>().As<IWorldService>().SingleInstance();
            builder.RegisterType<LanguageService>().As<ILanguageService>().SingleInstance();
            builder.RegisterType<ParserService>().As<IParserService>().SingleInstance();
            builder.RegisterType<PrintService>().As<IPrintService>().SingleInstance();
        }
    }
}

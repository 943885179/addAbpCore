using System;
using System.Collections.Generic;
using System.Text;
using Abp.Configuration.Startup;
using Abp.Domain.Uow;
using adminAbp.Configuration;
using adminAbp.Web;
using Microsoft.Extensions.Configuration;

namespace adminAbp.EntityFrameworkCore
{
    public class MyConnectionStringResolver : DefaultConnectionStringResolver
    {
        public MyConnectionStringResolver(IAbpStartupConfiguration configuration)
            : base(configuration)
        {
        }

        public override string GetNameOrConnectionString(ConnectionStringResolveArgs args)
        {
            if (args["DbContextConcreteType"] as Type == typeof(adminAbpDbContext1))
            {
                var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());
                return configuration.GetConnectionString(adminAbpConsts.ConnectionStringName1);
            }

            return base.GetNameOrConnectionString(args);
        }
    }
}

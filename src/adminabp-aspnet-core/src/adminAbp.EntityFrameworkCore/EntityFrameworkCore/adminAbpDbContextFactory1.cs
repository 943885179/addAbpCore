using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using adminAbp.Configuration;
using adminAbp.Web;

namespace adminAbp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class adminAbpDbContextFactory1 : IDesignTimeDbContextFactory<adminAbpDbContext1>
    {
        public adminAbpDbContext1 CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<adminAbpDbContext1>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            adminAbpDbContextConfigurer1.Configure(builder, configuration.GetConnectionString(adminAbpConsts.ConnectionStringName1));

            return new adminAbpDbContext1(builder.Options);
        }
    }
}

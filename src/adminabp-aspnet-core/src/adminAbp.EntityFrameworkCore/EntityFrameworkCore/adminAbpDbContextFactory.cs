using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using adminAbp.Configuration;
using adminAbp.Web;

namespace adminAbp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class adminAbpDbContextFactory : IDesignTimeDbContextFactory<adminAbpDbContext>
    {
        public adminAbpDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<adminAbpDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            adminAbpDbContextConfigurer.Configure(builder, configuration.GetConnectionString(adminAbpConsts.ConnectionStringName));

            return new adminAbpDbContext(builder.Options);
        }
    }
}

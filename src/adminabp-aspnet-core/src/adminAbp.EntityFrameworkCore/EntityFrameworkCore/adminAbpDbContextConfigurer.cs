using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace adminAbp.EntityFrameworkCore
{
    public static class adminAbpDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<adminAbpDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<adminAbpDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

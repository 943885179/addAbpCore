using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace adminAbp.EntityFrameworkCore
{
    public static class adminAbpDbContextConfigurer1
    {
        //public static void Configure(DbContextOptionsBuilder<adminAbpDbContext1> builder, string connectionString)
        //{
        //    builder.UseSqlServer(connectionString);
        //}

        //public static void Configure(DbContextOptionsBuilder<adminAbpDbContext1> builder, DbConnection connection)
        //{
        //    builder.UseSqlServer(connection);
        //}
        public static void Configure(
            DbContextOptionsBuilder<adminAbpDbContext1> dbContextOptions,
            string connectionString
        )
        {
            /* This is the single point to configure DbContextOptions for MultipleDbContextEfCoreDemoDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }

        public static void Configure(
            DbContextOptionsBuilder<adminAbpDbContext1> dbContextOptions,
            DbConnection connection
        )
        {
            /* This is the single point to configure DbContextOptions for MultipleDbContextEfCoreDemoDbContext */
            dbContextOptions.UseSqlServer(connection);
        }
    }
}

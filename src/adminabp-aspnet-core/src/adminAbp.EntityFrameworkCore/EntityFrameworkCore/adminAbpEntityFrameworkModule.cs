using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using adminAbp.EntityFrameworkCore.Seed;
using Abp.Configuration.Startup;
using Abp.Domain.Uow;
namespace adminAbp.EntityFrameworkCore
{
    [DependsOn(
        typeof(adminAbpCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class adminAbpEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {

            Configuration.ReplaceService<IConnectionStringResolver, MyConnectionStringResolver>();
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<adminAbpDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        adminAbpDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        adminAbpDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
                //×¢²áµÚ¶þ¸ö
                // Configure second DbContext
                Configuration.Modules.AbpEfCore().AddDbContext<adminAbpDbContext1>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        adminAbpDbContextConfigurer1.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        adminAbpDbContextConfigurer1.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(adminAbpEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}

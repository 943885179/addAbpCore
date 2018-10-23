using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using adminAbp.Authorization;
using adminAbp.Citys.Authorization;
using adminAbp.Persons.Authorization;
namespace adminAbp
{
    [DependsOn(
        typeof(adminAbpCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class adminAbpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<adminAbpAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(adminAbpApplicationModule).GetAssembly();

            Configuration.Authorization.Providers.Add<PhoneNumberAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<PersonAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<CityAuthorizationProvider>();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}

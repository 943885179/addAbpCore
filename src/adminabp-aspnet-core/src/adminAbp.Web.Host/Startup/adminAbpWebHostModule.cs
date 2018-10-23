using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using adminAbp.Configuration;

namespace adminAbp.Web.Host.Startup
{
    [DependsOn(
       typeof(adminAbpWebCoreModule))]
    public class adminAbpWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public adminAbpWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(adminAbpWebHostModule).GetAssembly());
        }
    }
}

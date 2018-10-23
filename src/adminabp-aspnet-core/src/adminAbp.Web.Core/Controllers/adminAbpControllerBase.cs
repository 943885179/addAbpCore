using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace adminAbp.Controllers
{
    public abstract class adminAbpControllerBase: AbpController
    {
        protected adminAbpControllerBase()
        {
            LocalizationSourceName = adminAbpConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Main.Controllers
{
    public abstract class MainControllerBase: AbpController
    {
        protected MainControllerBase()
        {
            LocalizationSourceName = MainConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

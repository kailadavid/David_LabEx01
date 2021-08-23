using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace David_LabEx01.Controllers
{
    public abstract class David_LabEx01ControllerBase: AbpController
    {
        protected David_LabEx01ControllerBase()
        {
            LocalizationSourceName = David_LabEx01Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

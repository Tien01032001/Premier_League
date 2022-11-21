using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CSDL.Controllers
{
    public abstract class CSDLControllerBase: AbpController
    {
        protected CSDLControllerBase()
        {
            LocalizationSourceName = CSDLConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

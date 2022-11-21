using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CSDL.EntityFrameworkCore;
using CSDL.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace CSDL.Web.Tests
{
    [DependsOn(
        typeof(CSDLWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class CSDLWebTestModule : AbpModule
    {
        public CSDLWebTestModule(CSDLEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CSDLWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(CSDLWebMvcModule).Assembly);
        }
    }
}
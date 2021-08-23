using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using David_LabEx01.EntityFrameworkCore;
using David_LabEx01.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace David_LabEx01.Web.Tests
{
    [DependsOn(
        typeof(David_LabEx01WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class David_LabEx01WebTestModule : AbpModule
    {
        public David_LabEx01WebTestModule(David_LabEx01EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(David_LabEx01WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(David_LabEx01WebMvcModule).Assembly);
        }
    }
}
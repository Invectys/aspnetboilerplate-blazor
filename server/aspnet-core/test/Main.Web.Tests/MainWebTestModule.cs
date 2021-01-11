using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Main.EntityFrameworkCore;
using Main.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Main.Web.Tests
{
    [DependsOn(
        typeof(MainWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MainWebTestModule : AbpModule
    {
        public MainWebTestModule(MainEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MainWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MainWebMvcModule).Assembly);
        }
    }
}
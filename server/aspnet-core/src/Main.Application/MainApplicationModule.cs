using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Main.Authorization;

namespace Main
{
    [DependsOn(
        typeof(MainCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MainApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MainAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MainApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

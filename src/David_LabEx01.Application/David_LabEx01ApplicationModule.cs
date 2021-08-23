using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using David_LabEx01.Authorization;

namespace David_LabEx01
{
    [DependsOn(
        typeof(David_LabEx01CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class David_LabEx01ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<David_LabEx01AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(David_LabEx01ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

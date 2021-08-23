using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using David_LabEx01.Configuration;

namespace David_LabEx01.Web.Startup
{
    [DependsOn(typeof(David_LabEx01WebCoreModule))]
    public class David_LabEx01WebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public David_LabEx01WebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<David_LabEx01NavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(David_LabEx01WebMvcModule).GetAssembly());
        }
    }
}

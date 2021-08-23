using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using David_LabEx01.Configuration;

namespace David_LabEx01.Web.Host.Startup
{
    [DependsOn(
       typeof(David_LabEx01WebCoreModule))]
    public class David_LabEx01WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public David_LabEx01WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(David_LabEx01WebHostModule).GetAssembly());
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using David_LabEx01.Configuration;
using David_LabEx01.Web;

namespace David_LabEx01.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class David_LabEx01DbContextFactory : IDesignTimeDbContextFactory<David_LabEx01DbContext>
    {
        public David_LabEx01DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<David_LabEx01DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            David_LabEx01DbContextConfigurer.Configure(builder, configuration.GetConnectionString(David_LabEx01Consts.ConnectionStringName));

            return new David_LabEx01DbContext(builder.Options);
        }
    }
}

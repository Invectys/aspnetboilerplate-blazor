using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Main.Configuration;
using Main.Web;

namespace Main.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MainDbContextFactory : IDesignTimeDbContextFactory<MainDbContext>
    {
        public MainDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MainDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MainDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MainConsts.ConnectionStringName));

            return new MainDbContext(builder.Options);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ClinicNB.Configuration;
using ClinicNB.Web;

namespace ClinicNB.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ClinicNBDbContextFactory : IDesignTimeDbContextFactory<ClinicNBDbContext>
    {
        public ClinicNBDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ClinicNBDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ClinicNBDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ClinicNBConsts.ConnectionStringName));

            return new ClinicNBDbContext(builder.Options);
        }
    }
}

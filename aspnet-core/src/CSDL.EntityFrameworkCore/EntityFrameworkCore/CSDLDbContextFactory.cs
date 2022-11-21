using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CSDL.Configuration;
using CSDL.Web;

namespace CSDL.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CSDLDbContextFactory : IDesignTimeDbContextFactory<CSDLDbContext>
    {
        public CSDLDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CSDLDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CSDLDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CSDLConsts.ConnectionStringName));

            return new CSDLDbContext(builder.Options);
        }
    }
}

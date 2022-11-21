using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CSDL.EntityFrameworkCore
{
    public static class CSDLDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CSDLDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CSDLDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ClinicNB.EntityFrameworkCore
{
    public static class ClinicNBDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ClinicNBDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ClinicNBDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Main.EntityFrameworkCore
{
    public static class MainDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MainDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MainDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

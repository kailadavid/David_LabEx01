using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace David_LabEx01.EntityFrameworkCore
{
    public static class David_LabEx01DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<David_LabEx01DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<David_LabEx01DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

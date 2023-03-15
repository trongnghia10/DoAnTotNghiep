using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN.Data.EntityFrameworkCore
{
    public class QLBanGiayDbContextFactory : IDesignTimeDbContextFactory<QLBanGiayDbContext>
    {
        public QLBanGiayDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("QLBanGiayDb");

            var optionsBuilder = new DbContextOptionsBuilder<QLBanGiayDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new QLBanGiayDbContext(optionsBuilder.Options);
        }
    }
}

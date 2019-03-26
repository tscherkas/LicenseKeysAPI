using System;
using System.Collections.Generic;
using System.Text;
using LicensesDAL_EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace Tests_LicensesDAL_EF
{
    public static class DbOptionsFactory
    {
        static DbOptionsFactory()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = config["Data:DefaultConnection:ConnectionString"];

            DbContextOptions = new DbContextOptionsBuilder<LicenceContext>()
                .UseSqlServer(connectionString)
                .Options;
        }
        
        public static DbContextOptions<LicenceContext> DbContextOptions { get; }
        public static LicenceContext DbContext => new LicenceContext(DbContextOptions);
    }
}

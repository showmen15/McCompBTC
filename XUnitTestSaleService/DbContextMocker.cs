using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SaleService.DbModel;

namespace XUnitTestSaleService
{
    public static class DbContextMocker
    {
        public static DatabaseBTCContext GetDatabaseBTCContext(string dbName)
        {
            var options = new DbContextOptionsBuilder<DatabaseBTCContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;

            var dbContext = new DatabaseBTCContext(options);

            dbContext.Seed();

            return dbContext;
        }
    }
}

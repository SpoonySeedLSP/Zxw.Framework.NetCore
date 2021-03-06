using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Zxw.Framework.NetCore.IDbContext;
using Zxw.Framework.NetCore.Options;

namespace Zxw.Framework.NetCore.DbContextCore
{
    public class InMemoryDbContext:BaseDbContext,IInMemoryDbContext
    {
        public InMemoryDbContext(DbContextOption option) : base(option)
        {

        }
        public InMemoryDbContext(IOptions<DbContextOption> option) : base(option)
        {
        }

        public InMemoryDbContext(DbContextOptions options) : base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(Option.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        public override DataTable GetDataTable(string sql, int cmdTimeout = 30, params DbParameter[] parameters)
        {
            throw new System.NotImplementedException();
        }

        public override List<DataTable> GetDataTables(string sql, int cmdTimeout = 30, params DbParameter[] parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}

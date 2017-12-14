using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jw.services.web.api.Entities;
using Microsoft.EntityFrameworkCore;

namespace jw.services.web.api.Db
{
    public class JwContext : DbContext
    {
        public DbSet<Congregation> Congregations { get; set; }

        public DbSet<AccountSheetLine> AccountSheetLines { get; set; }

        public DbSet<AccountSheet> AccountSheets { get; set; }

        public DbSet<TransactionType> TransactionTypes { get; set; }

        public DbSet<AmountNotPaid> AmountNotPaid { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

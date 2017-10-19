using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Thanu.Billing.Domain;

namespace Thanu.Billing.BLL
{
    public class BillingDbContextBll: DbContext
    {
        public BillingDbContextBll()
           : base("BillingContext")
        {
        }

        public DbSet<Billing_Item> BillingItem { get; set; }

         
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<string>().Configure(c => c.HasColumnType("varchar"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thanu.Billing.Domain;

namespace ThanuBillingSoftware
{
    public class BillingContextDb : DbContext
    {
        public BillingContextDb() : base("BillingContext")
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BillingContextDb>());
            //Database.Initialize(true);

            Database.SetInitializer<BillingContextDb>(new DropCreateDatabaseIfModelChanges<BillingContextDb>());

            //Database.SetInitializer<BillingContextDb>(new MigrateDatabaseToLatestVersion<BillingContextDb, BillingContextDb.Configuration>());
        }
       
        public DbSet<Billing_Item> BillingItem { get; set; }
    }
}

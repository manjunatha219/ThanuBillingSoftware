using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace Thanu.Billing.BLL
{
   public class BillingDbContextConfiguration:DbMigrationsConfiguration<BillingDbContextBll>
    {
        public BillingDbContextConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }
    }
}

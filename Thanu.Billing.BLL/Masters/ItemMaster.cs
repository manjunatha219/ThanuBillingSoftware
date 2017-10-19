using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thanu.Billing.Domain;

namespace Thanu.Billing.BLL.Masters
{
    public class ItemMaster
    {
        public void SaveItemMasterDetails(Billing_Item billingItem)
        {
            BillingDbContextBll db = new BillingDbContextBll();
            if (billingItem.ItemID == 0)
            {
                db.Entry(billingItem).State = System.Data.Entity.EntityState.Added;
            }
            else
            {
                db.Entry(billingItem).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();

        }

        public List<Billing_Item> GetBillingItemDetails()
        {
            BillingDbContextBll db = new BillingDbContextBll();
            List<Billing_Item> billDetails = new List<Billing_Item>();
            billDetails = db.BillingItem.ToList();
            return billDetails;
        }

        public Billing_Item GetBillItemDetailsBasedOnId(int itemId)
        {
            Billing_Item billingItem = new Billing_Item();
            BillingDbContextBll db = new BillingDbContextBll();
            billingItem= db.BillingItem.FirstOrDefault(a => a.ItemID == itemId);
            return billingItem;
        }

        public void DeleteBillItemDetailsBasedOnId(int itemId)
        {
            Billing_Item billingItem = new Billing_Item();
            BillingDbContextBll db = new BillingDbContextBll();
            billingItem = db.BillingItem.FirstOrDefault(a => a.ItemID == itemId);
            db.Entry(billingItem).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
    }
}

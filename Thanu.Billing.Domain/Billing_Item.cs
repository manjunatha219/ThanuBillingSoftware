using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanu.Billing.Domain
{
    public class Billing_Item
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemID { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public double Discount { get; set; }
        public double MRP { get; set; }
        public double NetRate { get; set; }
        public double quantity { get; set; }

    }
}

using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Windows.Forms;
using Thanu.Billing.BLL;

namespace ThanuBillingSoftware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateServiceDB();
        }
        public void UpdateServiceDB()
        {
            BillingDbContextBll context = new BillingDbContextBll();
            if (!context.Database.Exists())
            {
                var migrate = new DbMigrator(new BillingDbContextConfiguration());
                migrate.Update();
            }
        }
    }
}

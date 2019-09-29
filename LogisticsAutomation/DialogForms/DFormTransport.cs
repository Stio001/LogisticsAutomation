using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticsAutomation.DialogForms
{
    public partial class DFormTransport : Form
    {
        public DFormTransport()
        {
            InitializeComponent();

            using (LogisticsDBEntities db = new LogisticsDBEntities())
            {
                cmbDriver.DataSource = db.Drivers.ToList();
                cmbBrand.DataSource = db.Brands.ToList();
            }
        }
    }
}

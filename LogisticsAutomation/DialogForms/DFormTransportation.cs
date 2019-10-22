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
    public partial class DFormTransportation : Form
    {
        public DFormTransportation()
        {
            InitializeComponent();

            dtpDateOrder.Value = DateTime.Today;
            dtpDateArrival.Value = DateTime.Now;
            lbCargoes.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticsAutomation
{
    public partial class FormTransports : Form
    {
        LogisticsDBEntities db;

        public FormTransports()
        {
            InitializeComponent();

            db = new LogisticsDBEntities();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void LoadDriverInfo(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void ResetSearch(object sender, EventArgs e)
        {

        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            FormBrands formBrands = new FormBrands();
            formBrands.ShowDialog();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            FormDrivers formDrivers = new FormDrivers();
            formDrivers.ShowDialog();
        }
    }
}

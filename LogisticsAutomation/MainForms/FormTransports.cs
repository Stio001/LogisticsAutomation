using LogisticsAutomation.DialogForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            db.Transports.Load();
            db.Brands.Load();

            dgvTransport.DataSource = db.Transports.Local.ToBindingList();

            cmbSearchByBrand.DataSource = db.Brands.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DFormTransport dFormTransport = new DFormTransport();
            DialogResult dialogResult = dFormTransport.ShowDialog(this);

            if (dialogResult == DialogResult.Cancel)
                return;

            Transport transport = new Transport()
            {
                StateNumber = dFormTransport.tbStateNumber.Text,
                BrandID = (int)dFormTransport.cmbBrand.SelectedValue,
                DriverID = (int)dFormTransport.cmbDriver.SelectedValue,
                DateEntry = dFormTransport.dtpDateEntry.Value
            };

            db.Transports.Add(transport);
            db.SaveChanges();

            SearchObjects(this, EventArgs.Empty);

            MessageBox.Show("Новый объект добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void SearchObjects(object sender, EventArgs e)
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

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

            dgvTransport.DataSource = db.Transports.Local.ToBindingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DFormTransport dFormTransport = new DFormTransport();
            dFormTransport.cmbBrand.DataSource = db.Brands.ToList();
            dFormTransport.cmbDriver.DataSource = db.Drivers.ToList();

            DialogResult dialogResult = dFormTransport.ShowDialog(this);

            if (dialogResult == DialogResult.Cancel)
                return;

            Transport transport = new Transport()
            {
                StateNumber = dFormTransport.tbStateNumber.Text,
                Brand = (Brand)dFormTransport.cmbBrand.SelectedItem,
                Driver = (Driver)dFormTransport.cmbDriver.SelectedItem,
                DateEntry = dFormTransport.dtpDateEntry.Value
            };

            db.Transports.Add(transport);
            db.SaveChanges();

            SearchObjects(this, EventArgs.Empty);

            MessageBox.Show("Новый объект добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvTransport.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvTransport.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvTransport[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Transport transport = db.Transports.Find(id);

                db.Transports.Remove(transport);
                db.SaveChanges();

                SearchObjects(this, EventArgs.Empty);

                MessageBox.Show("Объект удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvTransport.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvTransport.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvTransport[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                DFormTransport dFormTransport = new DFormTransport();
                dFormTransport.cmbBrand.DataSource = db.Brands.ToList();
                dFormTransport.cmbDriver.DataSource = db.Drivers.ToList();

                Transport transport = db.Transports.Find(id);

                dFormTransport.tbStateNumber.Text = transport.StateNumber;
                dFormTransport.cmbBrand.SelectedItem = transport.Brand;
                dFormTransport.cmbDriver.SelectedItem = transport.Driver;
                dFormTransport.dtpDateEntry.Value = (DateTime)transport.DateEntry;

                DialogResult dialogResult = dFormTransport.ShowDialog(this);

                if (dialogResult == DialogResult.Cancel)
                    return;

                transport.StateNumber = dFormTransport.tbStateNumber.Text;
                transport.Brand = (Brand)dFormTransport.cmbBrand.SelectedItem;
                transport.Driver = (Driver)dFormTransport.cmbDriver.SelectedItem;
                transport.DateEntry = dFormTransport.dtpDateEntry.Value;

                db.SaveChanges();
                dgvTransport.Refresh();

                LoadDriverInfo(this, EventArgs.Empty);

                MessageBox.Show("Объект обновлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadDriverInfo(object sender, EventArgs e)
        {
            if (dgvTransport.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvTransport.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvTransport[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Transport transport = db.Transports.Find(id);

                tbNameDriver.Text = transport.Driver.Name;
                tbPhoneDriver.Text = transport.Driver.Phone;
                tbCategoryDriver.Text = transport.Driver.DrivingCategory;
            }
            else
            {
                tbNameDriver.Text = "";
                tbPhoneDriver.Text = "";
                tbCategoryDriver.Text = "";
            }
        }

        private void SearchObjects(object sender, EventArgs e)
        {
            if (tbSearchByStNumber.TextLength > 0)
            {
                dgvTransport.DataSource = db.Transports.Local.Where(t => t.StateNumber.Contains(tbSearchByStNumber.Text)).ToList();
            }
            else
            {
                dgvTransport.DataSource = db.Transports.Local.ToBindingList();
            }
        }

        private void ResetSearch(object sender, EventArgs e)
        {
            tbSearchByStNumber.Text = "";
            dgvTransport.DataSource = db.Transports.Local.ToBindingList();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            FormBrands formBrands = new FormBrands();
            formBrands.ShowDialog();

            RefreshDBEntries();
            dgvTransport.Refresh();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            FormDrivers formDrivers = new FormDrivers();
            formDrivers.ShowDialog();

            RefreshDBEntries();
            dgvTransport.Refresh();
            LoadDriverInfo(this, EventArgs.Empty);
        }

        public void RefreshDBEntries()
        {
            foreach (var entity in db.ChangeTracker.Entries())
            {
                entity.Reload();
            }
        }
    }
}

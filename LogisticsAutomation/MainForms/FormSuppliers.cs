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
    public partial class FormSuppliers : Form
    {
        LogisticsDBEntities db;

        public FormSuppliers()
        {
            InitializeComponent();

            db = new LogisticsDBEntities();
            db.Suppliers.Load();

            dgvSuppliers.DataSource = db.Suppliers.Local.ToBindingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DFormSupplier dFormSupplier = new DFormSupplier();
            DialogResult dialogResult = dFormSupplier.ShowDialog();

            if (dialogResult == DialogResult.Cancel)
                return;

            Supplier supplier = new Supplier();
            supplier.Name = dFormSupplier.tbName.Text;
            supplier.Address = dFormSupplier.tbAddress.Text;
            supplier.Phone = dFormSupplier.tbPhone.Text;
            supplier.ContactPerson = dFormSupplier.tbContactPerson.Text;
            supplier.Description = dFormSupplier.rtbDescription.Text;

            db.Suppliers.Add(supplier);
            db.SaveChanges();

            ResetSearch(this, EventArgs.Empty);

            MessageBox.Show("Новый объект добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvSuppliers.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvSuppliers[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Supplier supplier = db.Suppliers.Find(id);

                db.Suppliers.Remove(supplier);
                db.SaveChanges();

                MessageBox.Show("Объект удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvSuppliers.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvSuppliers[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Supplier supplier = db.Suppliers.Find(id);

                DFormSupplier dFormSupplier = new DFormSupplier();
                dFormSupplier.tbName.Text = supplier.Name;
                dFormSupplier.tbAddress.Text = supplier.Address;
                dFormSupplier.tbPhone.Text = supplier.Phone;
                dFormSupplier.tbContactPerson.Text = supplier.ContactPerson;
                dFormSupplier.rtbDescription.Text = supplier.Description;

                DialogResult dialogResult = dFormSupplier.ShowDialog(this);

                if (dialogResult == DialogResult.Cancel)
                    return;

                supplier.Name = dFormSupplier.tbName.Text;
                supplier.Address = dFormSupplier.tbAddress.Text;
                supplier.Phone = dFormSupplier.tbPhone.Text;
                supplier.ContactPerson = dFormSupplier.tbContactPerson.Text;
                supplier.Description = dFormSupplier.rtbDescription.Text;

                db.SaveChanges();
                dgvSuppliers.Refresh();
                LoadDescription(this, EventArgs.Empty);

                MessageBox.Show("Объект обновлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadDescription(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvSuppliers.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvSuppliers[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Supplier supplier = db.Suppliers.Find(id);

                rtbDescription.Text = supplier.Description;
            }
            else
            {
                rtbDescription.Text = "";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvSuppliers.DataSource = db.Suppliers.Local.Where(s => s.Name.Contains(tbSearchByName.Text)).ToList();
        }

        private void ResetSearch(object sender, EventArgs e)
        {
            tbSearchByName.Text = "";
            dgvSuppliers.DataSource = db.Suppliers.Local.ToBindingList();
        }
    }
}

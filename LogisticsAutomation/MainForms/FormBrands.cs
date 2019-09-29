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
    public partial class FormBrands : Form
    {
        LogisticsDBEntities db;

        public FormBrands()
        {
            InitializeComponent();

            db = new LogisticsDBEntities();
            db.Brands.Load();

            dgvBrands.DataSource = db.Brands.Local.ToBindingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DFormBrand dFormBrand = new DFormBrand();
            DialogResult dialogResult = dFormBrand.ShowDialog(this);

            if (dialogResult == DialogResult.Cancel)
                return;

            Brand brand = new Brand()
            {
                Name = dFormBrand.tbName.Text,
                Carrying = (int)dFormBrand.ntbCarrying.Value,
                Description = dFormBrand.rtbDescription.Text
            };

            db.Brands.Add(brand);
            db.SaveChanges();

            SearchObjects(this, EventArgs.Empty);

            MessageBox.Show("Новый объект добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvBrands.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvBrands.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvBrands[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Brand brand = db.Brands.Find(id);

                db.Brands.Remove(brand);
                db.SaveChanges();

                SearchObjects(this, EventArgs.Empty);

                MessageBox.Show("Объект удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvBrands.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvBrands.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvBrands[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Brand brand = db.Brands.Find(id);

                DFormBrand dFormBrand = new DFormBrand();
                dFormBrand.tbName.Text = brand.Name;
                dFormBrand.ntbCarrying.Value = (decimal)brand.Carrying;
                dFormBrand.rtbDescription.Text = brand.Description;

                DialogResult dialogResult = dFormBrand.ShowDialog();

                if (dialogResult == DialogResult.Cancel)
                    return;

                brand.Name = dFormBrand.tbName.Text;
                brand.Carrying = (int)dFormBrand.ntbCarrying.Value;
                brand.Description = dFormBrand.rtbDescription.Text;

                db.SaveChanges();
                dgvBrands.Refresh();

                LoadDescription(this, EventArgs.Empty);

                MessageBox.Show("Объект обновлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadDescription(object sender, EventArgs e)
        {
            if (dgvBrands.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvBrands.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvBrands[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Brand brand = db.Brands.Find(id);

                rtbDescription.Text = brand.Description;
            }
            else
            {
                rtbDescription.Text = "";
            }
        }

        private void SearchObjects(object sender, EventArgs e)
        {
            if (tbSearchByName.TextLength > 0)
            {
                dgvBrands.DataSource = db.Brands.Local.Where(b => b.Name.Contains(tbSearchByName.Text)).ToList();
            }
            else
            {
                dgvBrands.DataSource = db.Brands.Local.ToBindingList();
            }
        }

        private void ResetSearch(object sender, EventArgs e)
        {
            tbSearchByName.Text = "";
            dgvBrands.DataSource = db.Brands.Local.ToBindingList();
        }
    }
}

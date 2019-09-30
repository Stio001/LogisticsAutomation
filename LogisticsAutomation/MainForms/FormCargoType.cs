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
    public partial class FormCargoType : Form
    {
        LogisticsDBEntities db;

        public FormCargoType()
        {
            InitializeComponent();

            db = new LogisticsDBEntities();
            db.CargoTypes.Load();

            dgvCargoType.DataSource = db.CargoTypes.Local.ToBindingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DFormCargoType dFormCargoType = new DFormCargoType();
            DialogResult dialogResult = dFormCargoType.ShowDialog();

            if (dialogResult == DialogResult.Cancel)
                return;

            CargoType cargoType = new CargoType()
            {
                Name = dFormCargoType.tbName.Text,
                Description = dFormCargoType.rtbDescription.Text,
                Photo = ImageExtension.ImageToByteArray(dFormCargoType.pbPhoto.Image)
            };

            db.CargoTypes.Add(cargoType);
            db.SaveChanges();

            SearchObjects(this, EventArgs.Empty);

            MessageBox.Show("Новый объект добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCargoType.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvCargoType.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvCargoType[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                CargoType cargoType = db.CargoTypes.Find(id);

                db.CargoTypes.Remove(cargoType);
                db.SaveChanges();

                SearchObjects(this, EventArgs.Empty);

                MessageBox.Show("Объект удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvCargoType.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvCargoType.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvCargoType[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                CargoType cargoType = db.CargoTypes.Find(id);

                DFormCargoType dFormCargoType = new DFormCargoType();
                dFormCargoType.tbName.Text = cargoType.Name;
                dFormCargoType.rtbDescription.Text = cargoType.Description;
                dFormCargoType.pbPhoto.Image = ImageExtension.ByteArrayToImage(cargoType.Photo);

                DialogResult dialogResult = dFormCargoType.ShowDialog();

                if (dialogResult == DialogResult.Cancel)
                    return;

                cargoType.Name = dFormCargoType.tbName.Text;
                cargoType.Description = dFormCargoType.rtbDescription.Text;
                cargoType.Photo = ImageExtension.ImageToByteArray(dFormCargoType.pbPhoto.Image);

                db.SaveChanges();
                dgvCargoType.Refresh();

                LoadCargoInfo(this, EventArgs.Empty);

                MessageBox.Show("Объект обновлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadCargoInfo(object sender, EventArgs e)
        {
            if (dgvCargoType.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvCargoType.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvCargoType[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                CargoType cargoType = db.CargoTypes.Find(id);

                rtbDescription.Text = cargoType.Description;
                pbPhoto.Image = ImageExtension.ByteArrayToImage(cargoType.Photo);
            }
            else
            {
                rtbDescription.Text = "";
                pbPhoto.Image = null;
            }
        }

        private void SearchObjects(object sender, EventArgs e)
        {
            if (tbSearchByName.TextLength > 0)
            {
                dgvCargoType.DataSource = db.CargoTypes.Local.Where(ct => ct.Name.Contains(tbSearchByName.Text)).ToList();
            }
            else
            {
                dgvCargoType.DataSource = db.CargoTypes.Local.ToBindingList();
            }
        }

        private void ResetSearch(object sender, EventArgs e)
        {
            tbSearchByName.Text = "";
            dgvCargoType.DataSource = db.CargoTypes.Local.ToBindingList();
        }
    }
}

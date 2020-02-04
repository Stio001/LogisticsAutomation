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
    public partial class FormCargoes : Form
    {
        public LogisticsDBEntities db;

        public FormCargoes()
        {
            InitializeComponent();

            db = new LogisticsDBEntities();
            db.Cargoes.Load();

            dgvCargoes.DataSource = db.Cargoes.Local.ToBindingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DFormCargo dFormCargo = new DFormCargo();
            dFormCargo.cmbCargoType.DataSource = db.CargoTypes.ToList();
            dFormCargo.cmbSupplier.DataSource = db.Suppliers.ToList();         

            DialogResult dialogResult = dFormCargo.ShowDialog();

            if (dialogResult == DialogResult.Cancel)
                return;

            Cargo cargo = new Cargo()
            {
                Name = dFormCargo.tbName.Text,
                CargoType = (CargoType)dFormCargo.cmbCargoType.SelectedItem,
                Number = (int)dFormCargo.ntbNumber.Value,
                UnitMeasurement = dFormCargo.tbUnitMeasurement.Text,
                Weight = (int)dFormCargo.ntbWeight.Value,
                Supplier = (Supplier)dFormCargo.cmbSupplier.SelectedItem,
                Lenght = (int)dFormCargo.ntbLenght.Value,
                Width = (int)dFormCargo.ntbWidth.Value,
                Height = (int)dFormCargo.ntbHeight.Value
            };

            db.Cargoes.Add(cargo);
            db.SaveChanges();

            SearchObjects(this, EventArgs.Empty);

            MessageBox.Show("Новый объект добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCargoes.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvCargoes.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvCargoes[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Cargo cargo = db.Cargoes.Find(id);

                db.Cargoes.Remove(cargo);
                db.SaveChanges();

                SearchObjects(this, EventArgs.Empty);

                MessageBox.Show("Объект удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvCargoes.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvCargoes.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvCargoes[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;             

                DFormCargo dFormCargo = new DFormCargo();
                dFormCargo.cmbCargoType.DataSource = db.CargoTypes.ToList();
                dFormCargo.cmbSupplier.DataSource = db.Suppliers.ToList();

                Cargo cargo = db.Cargoes.Find(id);

                dFormCargo.tbName.Text = cargo.Name;
                dFormCargo.cmbCargoType.SelectedItem = cargo.CargoType;
                dFormCargo.ntbNumber.Value = (decimal)cargo.Number;
                dFormCargo.tbUnitMeasurement.Text = cargo.UnitMeasurement;
                dFormCargo.ntbWeight.Value = (decimal)cargo.Weight;
                dFormCargo.cmbSupplier.SelectedItem = cargo.Supplier;
                dFormCargo.ntbLenght.Value = (decimal)cargo.Lenght;
                dFormCargo.ntbWidth.Value = (decimal)cargo.Width;
                dFormCargo.ntbHeight.Value = (decimal)cargo.Height;

                DialogResult dialogResult = dFormCargo.ShowDialog();

                if (dialogResult == DialogResult.Cancel)
                    return;

                cargo.Name = dFormCargo.tbName.Text;
                cargo.CargoType = (CargoType)dFormCargo.cmbCargoType.SelectedItem;
                cargo.Number = (int)dFormCargo.ntbNumber.Value;
                cargo.UnitMeasurement = dFormCargo.tbUnitMeasurement.Text;
                cargo.Weight = (int)dFormCargo.ntbWeight.Value;
                cargo.Supplier = (Supplier)dFormCargo.cmbSupplier.SelectedItem;
                cargo.Lenght = (int)dFormCargo.ntbLenght.Value;
                cargo.Width = (int)dFormCargo.ntbWidth.Value;
                cargo.Height = (int)dFormCargo.ntbHeight.Value;

                db.SaveChanges();
                dgvCargoes.Refresh();

                LoadCargoInfo(this, EventArgs.Empty);

                MessageBox.Show("Объект обновлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void LoadCargoInfo(object sender, EventArgs e)
        {
            if (dgvCargoes.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvCargoes.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvCargoes[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Cargo cargo = db.Cargoes.Find(id);

                tbCTName.Text = cargo.CargoType.Name;
                rtbCTDescription.Text = cargo.CargoType.Description;
                pbCTPhoto.Image = ImageExtension.ByteArrayToImage(cargo.CargoType.Photo);
                tbLenght.Text = cargo.Lenght.ToString();
                tbWidth.Text = cargo.Width.ToString();
                tbHeight.Text = cargo.Height.ToString();
            }
            else
            {
                tbCTName.Text = "";
                rtbCTDescription.Text = "";
                pbCTPhoto.Image = null;
                tbLenght.Text = "";
                tbWidth.Text = "";
                tbHeight.Text = "";
            }
        }

        private void SearchObjects(object sender, EventArgs e)
        {
            if (tbSearchByName.TextLength > 0)
            {
                dgvCargoes.DataSource = db.Cargoes.Local.Where(c => c.Name.Contains(tbSearchByName.Text)).ToList();
            }
            else
            {
                dgvCargoes.DataSource = db.Cargoes.Local.ToBindingList();
            }
        }

        private void ResetSearch(object sender, EventArgs e)
        {
            tbSearchByName.Text = "";
            dgvCargoes.DataSource = db.Cargoes.Local.ToBindingList();
        }

        private void btnCargoType_Click(object sender, EventArgs e)
        {
            FormCargoType formCargoType = new FormCargoType();
            formCargoType.ShowDialog();

            RefreshDBEntries();
            dgvCargoes.Refresh();
            LoadCargoInfo(this, EventArgs.Empty);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            FormSuppliers formSuppliers = new FormSuppliers();
            formSuppliers.ShowDialog();

            RefreshDBEntries();
            dgvCargoes.Refresh();
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

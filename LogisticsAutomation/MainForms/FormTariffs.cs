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
    public partial class FormTariffs : Form
    {
        LogisticsDBEntities db;

        public FormTariffs()
        {
            InitializeComponent();

            db = new LogisticsDBEntities();
            db.Tariffs.Load();

            dgvTariffs.DataSource = db.Tariffs.Local.ToBindingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DFormTariff dFormTariff = new DFormTariff();
            DialogResult dialogResult = dFormTariff.ShowDialog(this);

            if (dialogResult == DialogResult.Cancel)
                return;

            Tariff tariff = new Tariff();
            tariff.Name = dFormTariff.tbName.Text;
            tariff.PerHour = (int)dFormTariff.ntbPerHour.Value;
            tariff.PerKG = (int)dFormTariff.ntbPerKG.Value;
            tariff.PerKM = (int)dFormTariff.ntbPerKM.Value;
            tariff.Description = dFormTariff.rtbDescription.Text;

            db.Tariffs.Add(tariff);
            db.SaveChanges();

            ResetSearch(this, EventArgs.Empty);

            MessageBox.Show("Новый объект добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvTariffs.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvTariffs.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvTariffs[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Tariff tariff = db.Tariffs.Find(id);

                db.Tariffs.Remove(tariff);
                db.SaveChanges();

                MessageBox.Show("Объект удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvTariffs.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvTariffs.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvTariffs[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;
               
                Tariff tariff = db.Tariffs.Find(id);

                DFormTariff dFormTariff = new DFormTariff();
                dFormTariff.tbName.Text = tariff.Name;
                dFormTariff.ntbPerHour.Value = (decimal)tariff.PerHour;
                dFormTariff.ntbPerKG.Value = (decimal)tariff.PerKG;
                dFormTariff.ntbPerKM.Value = (decimal)tariff.PerKM;
                dFormTariff.rtbDescription.Text = tariff.Description;

                DialogResult dialogResult = dFormTariff.ShowDialog(this);

                if (dialogResult == DialogResult.Cancel)
                    return;

                tariff.Name = dFormTariff.tbName.Text;
                tariff.PerHour = (int)dFormTariff.ntbPerHour.Value;
                tariff.PerKG = (int)dFormTariff.ntbPerKG.Value;
                tariff.PerKM = (int)dFormTariff.ntbPerKM.Value;
                tariff.Description = dFormTariff.rtbDescription.Text;

                db.SaveChanges();
                LoadDescription(this, EventArgs.Empty);

                MessageBox.Show("Объект обновлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadDescription(object sender, EventArgs e)
        {
            if (dgvTariffs.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvTariffs.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvTariffs[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Tariff tariff = db.Tariffs.Find(id);

                rtbDescription.Text = tariff.Description;
            }
            else
            {
                rtbDescription.Text = "";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvTariffs.DataSource = db.Tariffs.Local.Where(t => t.Name.Contains(tbSearchByName.Text)).ToList();
        }

        private void ResetSearch(object sender, EventArgs e)
        {
            tbSearchByName.Text = "";
            dgvTariffs.DataSource = db.Tariffs.Local.ToBindingList();
        }
    }
}

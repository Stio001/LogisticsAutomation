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
    public partial class FormDrivers : Form
    {
        LogisticsDBEntities db;

        public FormDrivers()
        {
            InitializeComponent();

            db = new LogisticsDBEntities();
            db.Drivers.Load();
            
            dgvDrivers.DataSource = db.Drivers.Local.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DFormDriver dFormDriver = new DFormDriver();
            DialogResult dialogResult = dFormDriver.ShowDialog();

            if (dialogResult == DialogResult.Cancel)
                return;

            Driver driver = new Driver();
            driver.Name = dFormDriver.tbName.Text;
            driver.Phone = dFormDriver.tbPhone.Text;
            driver.DrivingCategory = dFormDriver.tbDrivengCategory.Text;
            driver.Comments = dFormDriver.rtbComments.Text;

            db.Drivers.Add(driver);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvDrivers.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvDrivers.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvDrivers[0, selectedIndex].Value.ToString(), out id);
            
                if (!converted)
                    return;
            
                Driver driver = db.Drivers.Find(id);
            
                db.Drivers.Remove(driver);
                db.SaveChanges();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvDrivers.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvDrivers.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvDrivers[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Driver driver = db.Drivers.Find(id);

                DFormDriver dFormDriver = new DFormDriver();
                dFormDriver.tbName.Text = driver.Name;
                dFormDriver.tbPhone.Text = driver.Phone;
                dFormDriver.tbDrivengCategory.Text = driver.DrivingCategory;
                dFormDriver.rtbComments.Text = driver.Comments;

                DialogResult dialogResult = dFormDriver.ShowDialog(this);

                if (dialogResult == DialogResult.Cancel)
                    return;

                driver.Name = dFormDriver.tbName.Text;
                driver.Phone = dFormDriver.tbPhone.Text;
                driver.DrivingCategory = dFormDriver.tbDrivengCategory.Text;
                driver.Comments = dFormDriver.rtbComments.Text;

                db.SaveChanges();
                dgvDrivers_SelectionChanged(this, EventArgs.Empty);

                MessageBox.Show("Объект обновлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);         
            }
        }

        private void dgvDrivers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDrivers.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvDrivers.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvDrivers[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Driver driver = db.Drivers.Find(id);

                rtbComments.Text = driver.Comments;
            }
            else
            {
                rtbComments.Text = "";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvDrivers.DataSource = db.Drivers.Local.Where(x => x.Name.Contains(tbSearchByName.Text)).ToList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvDrivers.DataSource = db.Drivers.Local.ToList();
        }
    }
}

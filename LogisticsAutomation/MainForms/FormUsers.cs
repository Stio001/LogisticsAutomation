using LogisticsAutomation.DialogForms;
using LogisticsAutomation.MainForms;
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
    public partial class FormUsers : Form
    {
        LogisticsDBEntities db;

        public FormUsers()
        {
            InitializeComponent();

            db = new LogisticsDBEntities();
            db.Users.Load();

            dgvUsers.DataSource = db.Users.Local.ToBindingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DFormUser dFormUser = new DFormUser();
            dFormUser.cmbPosition.DataSource = db.Positions.ToList();

            DialogResult dialogResult = dFormUser.ShowDialog();

            if (dialogResult == DialogResult.Cancel)
                return;

            User user = new User()
            {
                Name = dFormUser.tbName.Text,
                Position = (Position)dFormUser.cmbPosition.SelectedItem
            };

            db.Users.Add(user);
            db.SaveChanges();

            SearchObjects(this, EventArgs.Empty);

            MessageBox.Show("Новый объект добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvUsers.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvUsers[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                User user = db.Users.Find(id);

                db.Users.Remove(user);
                db.SaveChanges();

                SearchObjects(this, EventArgs.Empty);

                MessageBox.Show("Объект удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvUsers.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvUsers[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                DFormUser dFormUser = new DFormUser();
                dFormUser.cmbPosition.DataSource = db.Positions.ToList();

                User user = db.Users.Find(id);

                dFormUser.tbName.Text = user.Name;
                dFormUser.cmbPosition.SelectedItem = user.Position;

                DialogResult dialogResult = dFormUser.ShowDialog();

                if (dialogResult == DialogResult.Cancel)
                    return;

                user.Name = dFormUser.tbName.Text;
                user.Position = (Position)dFormUser.cmbPosition.SelectedItem;

                db.SaveChanges();
                dgvUsers.Refresh();

                MessageBox.Show("Объект обновлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchObjects(object sender, EventArgs e)
        {
            if (tbSearchByName.TextLength > 0)
            {
                dgvUsers.DataSource = db.Users.Local.Where(u => u.Name.Contains(tbSearchByName.Text)).ToList();
            }
            else
            {
                dgvUsers.DataSource = db.Users.Local.ToBindingList();
            }
        }

        private void ResetSearch(object sender, EventArgs e)
        {
            tbSearchByName.Text = "";
            dgvUsers.DataSource = db.Users.Local.ToBindingList();
        }

        private void btnPositions_Click(object sender, EventArgs e)
        {
            FormPositions formPositions = new FormPositions();
            formPositions.ShowDialog();

            RefreshDBEntries();
            dgvUsers.Refresh();
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

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

namespace LogisticsAutomation.MainForms
{
    public partial class FormPositions : Form
    {
        LogisticsDBEntities db;

        public FormPositions()
        {
            InitializeComponent();

            db = new LogisticsDBEntities();
            db.Positions.Load();

            dgvPositions.DataSource = db.Positions.Local.ToBindingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DFormPosition dFormPosition = new DFormPosition();
            DialogResult dialogResult = dFormPosition.ShowDialog();

            if (dialogResult == DialogResult.Cancel)
                return;

            Position position = new Position()
            {
                Name = dFormPosition.tbName.Text
            };

            db.Positions.Add(position);
            db.SaveChanges();

            SearchObjects(this, EventArgs.Empty);

            MessageBox.Show("Новый объект добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvPositions.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvPositions.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvPositions[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Position position = db.Positions.Find(id);

                db.Positions.Remove(position);
                db.SaveChanges();

                SearchObjects(this, EventArgs.Empty);

                MessageBox.Show("Объект удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvPositions.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvPositions.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvPositions[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Position position = db.Positions.Find(id);

                DFormPosition dFormPosition = new DFormPosition();
                dFormPosition.tbName.Text = position.Name;

                DialogResult dialogResult = dFormPosition.ShowDialog();

                if (dialogResult == DialogResult.Cancel)
                    return;

                position.Name = dFormPosition.tbName.Text;

                db.SaveChanges();
                dgvPositions.Refresh();

                MessageBox.Show("Объект обновлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchObjects(object sender, EventArgs e)
        {
            if (tbSearchByName.TextLength > 0)
            {
                dgvPositions.DataSource = db.Positions.Local.Where(p => p.Name.Contains(tbSearchByName.Text)).ToList();
            }
            else
            {
                dgvPositions.DataSource = db.Positions.Local.ToBindingList();
            }
        }

        private void ResetSearch(object sender, EventArgs e)
        {
            tbSearchByName.Text = "";
            dgvPositions.DataSource = db.Positions.Local.ToBindingList();
        }
    }
}

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
    public partial class FormClients : Form
    {
        LogisticsDBEntities db;

        public FormClients()
        {
            InitializeComponent();

            db = new LogisticsDBEntities();
            db.Clients.Load();

            dgvClients.DataSource = db.Clients.Local.ToBindingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DFormClient dFormClient = new DFormClient();
            DialogResult dialogResult = dFormClient.ShowDialog(this);

            if (dialogResult == DialogResult.Cancel)
                return;

            Client client = new Client();
            client.Name = dFormClient.tbName.Text;
            client.Address = dFormClient.tbAddress.Text;
            client.Phone = dFormClient.tbPhone.Text;
            client.ContactPerson = dFormClient.tbContactPerson.Text;
            client.Comments = dFormClient.rtbComments.Text;

            db.Clients.Add(client);
            db.SaveChanges();

            ResetSearch(sender, EventArgs.Empty);

            MessageBox.Show("Новый объект добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvClients.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvClients[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Client client = db.Clients.Find(id);

                db.Clients.Remove(client);
                db.SaveChanges();

                MessageBox.Show("Объект удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvClients.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvClients[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Client client = db.Clients.Find(id);

                DFormClient dFormClient = new DFormClient();
                dFormClient.tbName.Text = client.Name;
                dFormClient.tbAddress.Text = client.Address;
                dFormClient.tbPhone.Text = client.Phone;
                dFormClient.tbContactPerson.Text = client.ContactPerson;
                dFormClient.rtbComments.Text = client.Comments;

                DialogResult dialogResult = dFormClient.ShowDialog(this);

                if (dialogResult == DialogResult.Cancel)
                    return;

                client.Name = dFormClient.tbName.Text;
                client.Address = dFormClient.tbAddress.Text;
                client.Phone = dFormClient.tbPhone.Text;
                client.ContactPerson = dFormClient.tbContactPerson.Text;
                client.Comments = dFormClient.rtbComments.Text;

                db.SaveChanges();
                dgvClients.Refresh();
                LoadComments(this, EventArgs.Empty);

                MessageBox.Show("Объект обновлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadComments(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvClients.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvClients[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Client client = db.Clients.Find(id);

                rtbComments.Text = client.Comments;
            }
            else
            {
                rtbComments.Text = "";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvClients.DataSource = db.Clients.Local.Where(c => c.Name.Contains(tbSearchByName.Text)).ToList();
        }

        private void ResetSearch(object sender, EventArgs e)
        {
            tbSearchByName.Text = "";
            dgvClients.DataSource = db.Clients.Local.ToBindingList();          
        }
    }
}

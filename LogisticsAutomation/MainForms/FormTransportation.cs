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
    public partial class FormTransportation : Form
    {
        LogisticsDBEntities db;

        public FormTransportation()
        {
            InitializeComponent();

            db = new LogisticsDBEntities();
            db.Transportations.Load();

            dgvTransportations.DataSource = db.Transportations.Local.ToBindingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void LoadInfo(object sender, EventArgs e)
        {
            if (dgvTransportations.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvTransportations.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvTransportations[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Transportation transportation = db.Transportations.Find(id);

                dgvCargoes.DataSource = transportation.Cargoes.ToList();
                dgvCargoes.Refresh();

                tbTransport.Text = transportation.Transport.StateNumber;
                tbClient.Text = transportation.Client.Name;
                tbTariff.Text = transportation.Tariff.Name;
                tbFuelDeparture.Text = transportation.FuelQuantityComing.ToString();
                tbFuelComing.Text = transportation.FuelQuantityDeparture.ToString();
                tbSpeedometerDeparture.Text = transportation.SpeedometerValueComing.ToString();
                tbSpeedometerComing.Text = transportation.SpeedometerValueDeparture.ToString();
                rtbAdditionalData.Text = transportation.AdditionalData;
            }
            else
            {
                dgvCargoes.DataSource = null;
                dgvCargoes.Refresh();
                tbTransport.Text = "";
                tbClient.Text = "";
                tbTariff.Text = "";
                tbFuelDeparture.Text = "";
                tbFuelComing.Text = "";
                tbSpeedometerDeparture.Text = "";
                tbSpeedometerComing.Text = "";
                rtbAdditionalData.Text = "";
            }
        }

        private void SearchObjects(object sender, EventArgs e)
        {
            dgvTransportations.DataSource = db.Transportations.Local
                .Where(t => t.ID == (int)ntbSearchByID.Value)
                .ToList();
        }

        private void ResetSearch(object sender, EventArgs e)
        {
            dgvTransportations.DataSource = db.Transportations.Local.ToBindingList();
        }
    }
}

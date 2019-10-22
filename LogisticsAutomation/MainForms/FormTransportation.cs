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
            DFormTransportation dFormTransportation = new DFormTransportation();
            dFormTransportation.cmbClient.DataSource = db.Clients.ToList();
            dFormTransportation.cmbTariff.DataSource = db.Tariffs.ToList();
            dFormTransportation.cmbTransport.DataSource = db.Transports.ToList();
            dFormTransportation.lbCargoes.DataSource = db.Cargoes.ToList();
            dFormTransportation.lbCargoes.SelectedIndex = -1;

            DialogResult dialogResult = dFormTransportation.ShowDialog(this);
            if (dialogResult == DialogResult.Cancel)
                return;

            Transportation transportation = new Transportation()
            {
                DateOrder = dFormTransportation.dtpDateOrder.Value,
                PlaceDelivery = dFormTransportation.tbPlaceDelivery.Text,
                Kilometrage = (int)dFormTransportation.ntbKilometrage.Value,
                TravelTime = (int)dFormTransportation.ntbTravelTime.Value,
                Transport = (Transport)dFormTransportation.cmbTransport.SelectedItem,
                Client = (Client)dFormTransportation.cmbClient.SelectedItem,
                Tariff = (Tariff)dFormTransportation.cmbTariff.SelectedItem,
                FuelQuantityDeparture = (int)dFormTransportation.ntbFuelDeparture.Value,
                FuelQuantityComing = (int)dFormTransportation.ntbFuelComing.Value,
                SpeedometerValueDeparture = (int)dFormTransportation.ntbSpeedometerDeparture.Value,
                SpeedometerValueComing = (int)dFormTransportation.ntbSpeedometerComing.Value,
                DateArrival = dFormTransportation.dtpDateArrival.Value,
                AdditionalData = dFormTransportation.rtbAdditionalData.Text,
            };

            //var cargoes = new List<Cargo>();
            foreach (var cargo in dFormTransportation.lbCargoes.SelectedItems)
            {
                transportation.Cargoes.Add((Cargo)cargo);
                //cargoes.Add((Cargo)cargo);
            }
            //transportation.Cargoes = cargoes;

            db.Transportations.Add(transportation);
            db.SaveChanges();

            ResetSearch(this, EventArgs.Empty);

            MessageBox.Show("Новый объект добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvTransportations.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvTransportations.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvTransportations[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Transportation transportation = db.Transportations.Find(id);

                db.Transportations.Remove(transportation);
                db.SaveChanges();

                ResetSearch(this, EventArgs.Empty);

                MessageBox.Show("Объект удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvTransportations.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvTransportations.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvTransportations[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Transportation transportation = db.Transportations.Find(id);

                DFormTransportation dFormTransportation = new DFormTransportation();
                dFormTransportation.cmbClient.DataSource = db.Clients.ToList();
                dFormTransportation.cmbTariff.DataSource = db.Tariffs.ToList();
                dFormTransportation.cmbTransport.DataSource = db.Transports.ToList();
                dFormTransportation.lbCargoes.DataSource = db.Cargoes.ToList();
                dFormTransportation.lbCargoes.SelectedIndex = -1;
                foreach (var cargo in transportation.Cargoes)
                {
                    dFormTransportation.lbCargoes.SelectedItem = cargo;
                }

                dFormTransportation.dtpDateOrder.Value = (DateTime)transportation.DateOrder;
                dFormTransportation.tbPlaceDelivery.Text = transportation.PlaceDelivery;
                dFormTransportation.ntbKilometrage.Value = (decimal)transportation.Kilometrage;
                dFormTransportation.ntbTravelTime.Value = (decimal)transportation.TravelTime;
                dFormTransportation.cmbTransport.SelectedItem = transportation.Transport;
                dFormTransportation.cmbClient.SelectedItem = transportation.Client;
                dFormTransportation.cmbTariff.SelectedItem = transportation.Tariff;
                dFormTransportation.ntbFuelDeparture.Value = (decimal)transportation.FuelQuantityDeparture;
                dFormTransportation.ntbFuelComing.Value = (decimal)transportation.FuelQuantityComing;
                dFormTransportation.ntbSpeedometerDeparture.Value = (decimal)transportation.SpeedometerValueDeparture;
                dFormTransportation.ntbSpeedometerComing.Value = (decimal)transportation.SpeedometerValueComing;
                dFormTransportation.dtpDateArrival.Value = (DateTime)transportation.DateArrival.Value;
                dFormTransportation.rtbAdditionalData.Text = transportation.AdditionalData;

                DialogResult dialogResult = dFormTransportation.ShowDialog(this);
                if (dialogResult == DialogResult.Cancel)
                    return;

                transportation.DateOrder = dFormTransportation.dtpDateOrder.Value;
                transportation.PlaceDelivery = dFormTransportation.tbPlaceDelivery.Text;
                transportation.Kilometrage = (int)dFormTransportation.ntbKilometrage.Value;
                transportation.TravelTime = (int)dFormTransportation.ntbTravelTime.Value;
                transportation.Transport = (Transport)dFormTransportation.cmbTransport.SelectedItem;
                transportation.Client = (Client)dFormTransportation.cmbClient.SelectedItem;
                transportation.Tariff = (Tariff)dFormTransportation.cmbTariff.SelectedItem;
                transportation.FuelQuantityDeparture = (int)dFormTransportation.ntbFuelDeparture.Value;
                transportation.FuelQuantityComing = (int)dFormTransportation.ntbFuelComing.Value;
                transportation.SpeedometerValueDeparture = (int)dFormTransportation.ntbSpeedometerDeparture.Value;
                transportation.SpeedometerValueComing = (int)dFormTransportation.ntbSpeedometerComing.Value;
                transportation.DateArrival = dFormTransportation.dtpDateArrival.Value;
                transportation.AdditionalData = dFormTransportation.rtbAdditionalData.Text;

                transportation.Cargoes.Clear();
                foreach (var cargo in dFormTransportation.lbCargoes.SelectedItems)
                {
                    transportation.Cargoes.Add((Cargo)cargo);
                }

                db.SaveChanges();
                dgvTransportations.Refresh();
                LoadInfo(this, EventArgs.Empty);

                ResetSearch(this, EventArgs.Empty);

                MessageBox.Show("Объект был изменен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                tbDateArrival.Text = transportation.DateArrival.Value.ToShortDateString();
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
                tbDateArrival.Text = "";
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
            ntbSearchByID.Value = 0M;
            dgvTransportations.DataSource = db.Transportations.Local.ToBindingList();
        }
    }
}

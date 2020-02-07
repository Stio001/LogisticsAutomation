using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticsAutomation.DialogForms
{
    public partial class DFormTransportation : Form
    {
        public DFormTransportation()
        {
            InitializeComponent();

            dtpDateOrder.Value = DateTime.Today;
            dtpDateArrival.Value = DateTime.Now;
            lbCargoes.SelectedIndex = -1;
        }

        private void btCalculateCost_Click(object sender, EventArgs e)
        {
            if (lbCargoes.SelectedItems.Count > 0)
            {
                Tariff selectedTariff = (Tariff)cmbTariff.SelectedItem;
                int cost = (int)(selectedTariff.PerHour * (int)ntbTravelTime.Value)
                         + (int)(selectedTariff.PerKM * (int)(ntbSpeedometerComing.Value - ntbSpeedometerDeparture.Value));

                foreach (var objCargo in lbCargoes.SelectedItems)
                {
                    Cargo cargo = (Cargo)objCargo;
                    cost += (int)(cargo.Weight * selectedTariff.PerKG);
                }

                tbCost.Text = cost.ToString() + " руб.";
            }
            else
            {
                tbCost.Text = "Нет грузов.";
            }
        }

        private void btCheckingCapacity_Click(object sender, EventArgs e)
        {
            if (lbCargoes.SelectedItems.Count > 0)
            {
                Transport transport = (Transport)cmbTransport.SelectedItem;
                int totalCargoWeight = 0;
                int totalCargoVolume = 0;

                foreach (var objCargo in lbCargoes.SelectedItems)
                {
                    Cargo cargo = (Cargo)objCargo;
                    totalCargoWeight += (int)cargo.Weight;
                    totalCargoVolume += (int)(cargo.Lenght * cargo.Width * cargo.Height * cargo.Number);
                }

                int maxCargoVolume = (int)(transport.Brand.Lenght * transport.Brand.Width * transport.Brand.Height / 2);
                if (totalCargoWeight > transport.Brand.Capacity)
                {
                    tbCheckingCapacity.Text = "Не проходит по весу!";
                    return;
                }
                else
                {
                    if (totalCargoVolume > maxCargoVolume)
                    {
                        tbCheckingCapacity.Text = "Не проходит по объему!";
                    }
                    else
                    {
                        tbCheckingCapacity.Text = "Всё впорядке!";
                    }
                }
            }
            else
            {
                tbCheckingCapacity.Text = "Нет грузов.";
            }
        }
    }
}

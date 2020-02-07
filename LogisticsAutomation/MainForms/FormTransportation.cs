using LogisticsAutomation.DialogForms;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;

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

            foreach (var cargo in dFormTransportation.lbCargoes.SelectedItems)
            {
                transportation.Cargoes.Add((Cargo)cargo);
            }

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

        private void btnWaybill_Click(object sender, EventArgs e)
        {
            if (dgvTransportations.SelectedRows.Count > 0)
            {
                if (!SelectEmployeeQuestion(out User employee))
                    return;

                int selectedIndex = dgvTransportations.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvTransportations[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Transportation transportation = db.Transportations.Find(id);

                Microsoft.Office.Interop.Excel.Application xcl;
                _Workbook oWB;
                _Worksheet oSheet;

                try
                {
                    xcl = new Microsoft.Office.Interop.Excel.Application();
                    oWB = xcl.Workbooks.Open(@"C:\Users\User\source\repos\Stio001\LogisticsAutomation\LogisticsAutomation\Шаблоны\Путевой лист.xls");
                    oSheet = oWB.ActiveSheet;

                    oSheet.Cells[6, 4] = transportation.Transport.Driver.Name; //ФИО водителя
                    oSheet.Cells[7, 4] = transportation.Transport.Driver.DrivingCategory;
                    oSheet.Cells[10, 4] = transportation.Transport.Driver.Phone;
                    oSheet.Cells[11, 4] = transportation.Transport.Brand.Name;
                    oSheet.Cells[12, 4] = transportation.Client.Name;
                    oSheet.Cells[13, 4] = transportation.PlaceDelivery;
                    oSheet.Cells[14, 4] = transportation.FuelQuantityComing;
                    oSheet.Cells[15, 4] = transportation.SpeedometerValueComing + " л.";
                    oSheet.Cells[6, 6] = transportation.DateArrival;
                    oSheet.Cells[7, 6] = transportation.TravelTime + " мин.";
                    oSheet.Cells[28, 4] = employee.Name;

                    Range line = (Range)oSheet.Rows[22];
                    for (int quantityCargo = 0; quantityCargo < transportation.Cargoes.Count - 2; quantityCargo++)
                    {
                        line.Insert(Type.Missing, line);
                    }

                    var cargoes = transportation.Cargoes.ToList();
                    for (int numberCargo = 0; numberCargo < cargoes.Count; numberCargo++)
                    {
                        oSheet.Cells[21 + numberCargo, 3] = numberCargo + 1;
                        oSheet.Cells[21 + numberCargo, 4] = cargoes[numberCargo].Name;
                        oSheet.Cells[21 + numberCargo, 5] = cargoes[numberCargo].CargoType.Name;
                        oSheet.Cells[21 + numberCargo, 6] = cargoes[numberCargo].Supplier.Name;
                    }

                    oWB.SaveAs($@"C:\Users\User\source\repos\Stio001\LogisticsAutomation\LogisticsAutomation\Документы\Путевой лист №{transportation.ID}.xls");
                    xcl.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void makeContract_Click(object sender, EventArgs e)
        {
            if (dgvTransportations.SelectedRows.Count > 0)
            {
                if (!SelectEmployeeQuestion(out User employee))
                    return;

                int selectedIndex = dgvTransportations.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvTransportations[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                Transportation transportation = db.Transportations.Find(id);

                Microsoft.Office.Interop.Excel.Application xcl;
                _Workbook oWB;
                _Worksheet oSheet;

                try
                {
                    xcl = new Microsoft.Office.Interop.Excel.Application();
                    oWB = xcl.Workbooks.Open(@"C:\Users\User\source\repos\Stio001\LogisticsAutomation\LogisticsAutomation\Шаблоны\Договор.xls");
                    oSheet = oWB.ActiveSheet;

                    oSheet.Cells[7, 4] = transportation.Tariff.Name;
                    oSheet.Cells[11, 4] = String.Format($"{transportation.Tariff.PerKM}.00 руб. за км.");
                    oSheet.Cells[12, 4] = String.Format($"{transportation.Tariff.PerHour}.00 руб. за мин.");
                    oSheet.Cells[13, 4] = String.Format($"{transportation.Tariff.PerKG}.00 руб. за кг.");
                    oSheet.Cells[11, 5] = transportation.Tariff.PerKM * (transportation.SpeedometerValueComing - transportation.SpeedometerValueDeparture) + ".00 руб.";
                    oSheet.Cells[12, 5] = transportation.Tariff.PerHour * transportation.TravelTime + ".00 руб.";
                    oSheet.Cells[13, 5] = transportation.Tariff.PerKG * transportation.Cargoes.Sum(c => c.Weight) + ".00 руб.";
                    oSheet.Cells[10, 8] = transportation.Transport.StateNumber;
                    oSheet.Cells[11, 8] = transportation.Transport.Driver.Name;
                    oSheet.Cells[24, 4] = transportation.PlaceDelivery;
                    oSheet.Cells[23, 8] = String.Format($"{transportation.Tariff.PerKG * transportation.Cargoes.Sum(c => c.Weight)}.00 руб");
                    int cost = (int)(transportation.Tariff.PerHour * transportation.TravelTime)
                        + (int)(transportation.Tariff.PerKM * (transportation.SpeedometerValueComing - transportation.SpeedometerValueDeparture))
                        + (int)(transportation.Tariff.PerKG * transportation.Cargoes.Sum(c => c.Weight));
                    oSheet.Cells[24, 8] = String.Format($"{cost}.00 руб.");
                    oSheet.Cells[28, 4] = transportation.Client.ContactPerson;
                    oSheet.Cells[28, 7] = employee.Name;

                    Range line = (Range)oSheet.Rows[22];
                    for (int quantityCargo = 0; quantityCargo < transportation.Cargoes.Count - 2; quantityCargo++)
                    {
                        line.Insert(XlInsertShiftDirection.xlShiftDown, true);
                    }

                    var cargoes = transportation.Cargoes.ToList();
                    for (int numberCargo = 0; numberCargo < cargoes.Count; numberCargo++)
                    {
                        oSheet.Cells[21 + numberCargo, 3] = numberCargo + 1;
                        oSheet.Cells[21 + numberCargo, 4] = cargoes[numberCargo].Name;
                        oSheet.Cells[21 + numberCargo, 5] = cargoes[numberCargo].CargoType.Name;
                        oSheet.Cells[21 + numberCargo, 6] = cargoes[numberCargo].Supplier.Name;
                        oSheet.Cells[21 + numberCargo, 7] = cargoes[numberCargo].Weight;
                        oSheet.Cells[21 + numberCargo, 8] = cargoes[numberCargo].Weight * transportation.Tariff.PerKG + ".00 руб.";
                    }

                    oWB.SaveAs($@"C:\Users\User\source\repos\Stio001\LogisticsAutomation\LogisticsAutomation\Документы\Договор №{transportation.ID}.xls");
                    xcl.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool SelectEmployeeQuestion(out User selectedEmployee)
        {
            DFormEmployeeQuestion dFormEmployeeQuestion = new DFormEmployeeQuestion();
            dFormEmployeeQuestion.cmbWorkers.DataSource = db.Users.ToList();
            DialogResult dialogResult = dFormEmployeeQuestion.ShowDialog();
            selectedEmployee = (User)dFormEmployeeQuestion.cmbWorkers.SelectedItem;

            if (dialogResult == DialogResult.Cancel)
                return false;

            return true;
        }     
    }
}

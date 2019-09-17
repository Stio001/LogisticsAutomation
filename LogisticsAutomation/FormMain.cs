using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticsAutomation
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void frmAboutOpen(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void frmBrandsOpen(object sender, EventArgs e)
        {
            FormBrands formBrands = new FormBrands();
            formBrands.ShowDialog();
        }

        private void frmCargosOpen(object sender, EventArgs e)
        {
            FormCargos formCargos = new FormCargos();
            formCargos.ShowDialog();
        }

        private void frmCargosTypeOpen(object sender, EventArgs e)
        {
            FormCargoType formCargoType = new FormCargoType();
            formCargoType.ShowDialog();
        }

        private void frmClientsOpen(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients();
            formClients.ShowDialog();
        }

        private void frmDriversOpen(object sender, EventArgs e)
        {
            FormDrivers formDrivers = new FormDrivers();
            formDrivers.ShowDialog();
        }

        private void frmReportOpen(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.ShowDialog();
        }

        private void frmStatOpen(object sender, EventArgs e)
        {
            FormStats formStats = new FormStats();
            formStats.ShowDialog();
        }

        private void frmSuppliersOpen(object sender, EventArgs e)
        {
            FormSuppliers formSuppliers = new FormSuppliers();
            formSuppliers.ShowDialog();
        }

        private void frmTariffsOpen(object sender, EventArgs e)
        {
            FormTariffs formTariffs = new FormTariffs();
            formTariffs.ShowDialog();
        }

        private void frmTranspotationOpen(object sender, EventArgs e)
        {
            FormTransportation formTransportation = new FormTransportation();
            formTransportation.ShowDialog();
        }

        private void frmTransportsOpen(object sender, EventArgs e)
        {
            FormTransports formTransports = new FormTransports();
            formTransports.ShowDialog();
        }

        private void frmUsersOpen(object sender, EventArgs e)
        {
            FormUsers formUsers = new FormUsers();
            formUsers.ShowDialog();
        }

        private void РезервнаяКопияБДToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ЗакрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}

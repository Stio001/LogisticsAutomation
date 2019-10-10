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
        List<CargoTransportation> cargoTransportation;

        public DFormTransportation()
        {
            InitializeComponent();

            dgvCargoTransportation.DataSource = cargoTransportation;

            dtpDateOrder.Value = DateTime.Today;
            dtpDateArrival.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvCargoes.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvCargoes.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dgvCargoes[0, selectedIndex].Value.ToString(), out id);

                if (!converted)
                    return;

                
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}

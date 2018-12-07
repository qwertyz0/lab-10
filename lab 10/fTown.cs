using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_10
{
    public partial class fTown : Form
    {
        public Town TheTown;
        public fTown(Town t)
        {
            TheTown = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheTown.Name = tbName.Text.Trim();
            TheTown.Country = tbCountry.Text.Trim();
            TheTown.Region = tbRegion.Text.Trim();
            TheTown.Population = int.Parse(tbPopulation.Text.Trim());
            TheTown.YearIncome = double.Parse(tbYearIncome.Text.Trim());
            TheTown.Square = double.Parse(tbSquare.Text.Trim());
            TheTown.HasPort = chbHasPort.Checked;
            TheTown.HasAirport = chbHasAirport.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fTown_Load(object sender, EventArgs e)
        {
            if (TheTown != null)
            {
                tbName.Text = TheTown.Name;
                tbCountry.Text = TheTown.Country;
                tbRegion.Text = TheTown.Region;
                tbPopulation.Text = TheTown.Population.ToString();
                tbYearIncome.Text = TheTown.YearIncome.ToString("0.00");
                tbSquare.Text = TheTown.Square.ToString("0.000");
                chbHasPort.Checked = TheTown.HasPort;
                chbHasAirport.Checked = TheTown.HasAirport;
            }
        }
    }
}

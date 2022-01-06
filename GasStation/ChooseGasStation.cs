using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStation
{
    public partial class ChooseGasStation : BaseForm
    {
        public ChooseGasStation()
        {
            InitializeComponent();
        }
        private void Next(object sender,EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                GasStation station = GasStation.FoundStation(index);
                double fuel = Double.Parse(textBox3.Text);
                if (fuel <= 0)
                {
                    throw new Exception();
                }
                station.SellingFuel(fuel);
            }
            catch
            {
                MessageBox.Show("Incorect");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
;
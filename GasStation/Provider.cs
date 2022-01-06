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
    public partial class Provider : BaseForm
    {
        public Provider()
        {
            InitializeComponent();
        }
        private void Next(object sender, EventArgs e)
        {
            try
            {
                int index = listBox2.SelectedIndex;
                GasStation station = GasStation.FoundStation(index);
                double fuel = Double.Parse(textBox3.Text);
                if (fuel <= 0)
                {
                    throw new Exception();
                }
                station.BuyFuel(fuel);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Incorect\n" +ex.Message);
            }
        }
    }
}

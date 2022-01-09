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
    public partial class ChooseGasStationForClient : BaseForm
    {
        AccountClient accountClient;
        public ChooseGasStationForClient()
        {
            InitializeComponent();
            //if (VerificatingClient.Done)
            //{
            //    this.Controls.Add(this.checkBox);
            //}
        }
        private void Next(object sender,EventArgs e)
        {
            try
            {
                accountClient = AccountClient.GetValidAccount();
                int index = listBox1.SelectedIndex;
                double fuel = Double.Parse(textBox3.Text);
                if (fuel <= 0)
                {
                    throw new Exception();
                }
                double sum = GasStation.SellingFuel(fuel, index);
                //if (checkBox.Checked) 
                //{
                //    accountClient?.UsingBonus(sum);
                //}
                accountClient?.AddingBonus(sum);
            }
            catch
            {
                MessageBox.Show("Incorect");
            }
        }
    }
}
;
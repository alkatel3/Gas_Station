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
    public partial class СreatingGasStation : BaseForm
    {
        string nameStation;
        string password;
        double fuel;
        double maxFuel;
        double price;

        public СreatingGasStation(Form form)
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                nameStation = textBox1.Text;
                password = textBox2.Text;
                fuel = Double.Parse(textBox3.Text);
                maxFuel = Double.Parse(textBox4.Text);
                price = Double.Parse(textBox5.Text);
                if (fuel <= 0 || maxFuel <= 0 || price <= 0 || fuel > maxFuel)
                {
                    throw new Exception();
                }
                var Station = new GasStation(nameStation, fuel, maxFuel, price, password);
                Station.InformationForOwner();
                Station.SaveStation();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Incorect input");
            }
        }
    }
}

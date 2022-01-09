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
    public partial class CreatingGasStation : BaseForm
    {
        string nameStation;
        string password;
        double fuel;
        double maxFuel;
        double price;

        public CreatingGasStation()
        {
            InitializeComponent();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            try
            {
                nameStation = textBox1.Text;
                password = textBox2.Text;
                fuel = Double.Parse(textBox3.Text);
                maxFuel = Double.Parse(textBox4.Text);
                price = Double.Parse(textBox5.Text);
                if (GasStation.FoundStation(nameStation) != null)
                {
                    MessageBox.Show("Gas station with that name already exists");
                    return;
                }
                if (fuel <= 0 || maxFuel <= 0 || price <= 0 || fuel > maxFuel)
                {
                    throw new Exception();
                }
                var Station = new GasStation(nameStation, fuel, maxFuel, price, password,DateTime.Now);
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

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
    public partial class VerificatingOwner : BaseForm
    {
        public VerificatingOwner(Form form)
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var station = GasStation.FoundStation(textBox1.Text, textBox2.Text);
            station.InformationForOwner();
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            ListForm.Cansel();
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ListForm.Back();
            this.Close();
        }
    }
}

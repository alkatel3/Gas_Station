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
        public VerificatingOwner()
        {
            InitializeComponent();
        }

        private void buttonNext_cl(object sender, EventArgs e)
        {
            var station = GasStation.FoundStation(textBox1.Text, textBox2.Text);
            if(station!=null)
            station.InformationForOwner();
        }
    }
}

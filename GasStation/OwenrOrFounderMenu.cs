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
    public partial class OwenrOrFounderMenu : BaseForm
    {
        public OwenrOrFounderMenu()
        {
            InitializeComponent();
        }
        private void buttonYes_Click(object sender, EventArgs e)
        {
            baseForm = new VerificatingOwner();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            baseForm = new CreatingGasStation();
        }


        
    }
}

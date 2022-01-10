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
    public partial class VerificatingClient : BaseForm
    {
        //static public bool Done = false;
        public VerificatingClient()
        {
            InitializeComponent();
        }
        private void buttonNext_cl(object sender, EventArgs e)
        {
            var Account = AccountClient.FoundAccount(textBox1.Text, textBox2.Text);
            if (Account != null)
            {
                //Done = true;
                Account?.GetInformation();
                baseForm = new ChooseGasStationForClient();
                buttonNext_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Account didn't found");
            }
        }
    }
}

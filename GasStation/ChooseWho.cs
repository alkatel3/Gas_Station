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

    public partial class ChooseWho : BaseForm
    {
        public ChooseWho()
        {
            InitializeComponent();
        }

        private void buttonProvider_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            baseForm = new ClientMenu();
        }


        private void buttonOwnerOrFounder_Click(object sender, EventArgs e)
        {
            baseForm = new OwenrOrFounderMenu();
        }

        private void ChooseWho_Load(object sender, EventArgs e)
        {
           BaseForm.Do = false;
            this.Close();
        }
    }
}

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
        BaseForm baseForm;
        public ChooseWho()
        {
            InitializeComponent();
        }

        private void buttonProvider_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            baseForm = new ClientMenu(this);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ListForm.AddForm(baseForm);
            this.Close();
        }

        private void buttonOwnerOrFounder_Click(object sender, EventArgs e)
        {
            baseForm = new OwenrOrFounderMenu(this);
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            ListForm.Cansel();
            this.Close();
        }
    }
}

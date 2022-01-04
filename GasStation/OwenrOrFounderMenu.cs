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
        BaseForm form;
        public OwenrOrFounderMenu(Form form)
        {
            InitializeComponent();
        }
        private void buttonYes_Click(object sender, EventArgs e)
        {
            form = new VerificatingOwner(this);
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            form = new СreatingGasStation(this);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ListForm.AddForm(form);
            this.Close();
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

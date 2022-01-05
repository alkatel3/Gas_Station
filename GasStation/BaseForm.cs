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
    public partial class BaseForm : Form
    {
        public static bool Do = true;
        protected BaseForm baseForm;
        public BaseForm()
        {
        }
        protected void buttonCansel_Click(object sender, EventArgs e)
        {
            ListForm.Cansel();
            this.Close();
        }
        protected void buttonBack_Click(object sender, EventArgs e)
        {
            ListForm.Back();
            this.Close();
        }
        protected void buttonNext_Click(object sender, EventArgs e)
        {
            ListForm.AddForm(baseForm);
            this.Close();
        }
    }
}
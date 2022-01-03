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
    public partial class Form1 : Form
    {
        BaseForm baseForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baseForm = new Form3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baseForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baseForm = new Form2();
        }
    }
}

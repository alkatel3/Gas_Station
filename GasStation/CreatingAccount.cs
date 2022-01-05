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
    public partial class CreatingAccount : BaseForm
    {
        string AccountName;
        string AccountPassword;
        public CreatingAccount()
        {
            InitializeComponent();
        }
        private void buttonFinish_Click(object sender,EventArgs e)
        {
            AccountName = textBox1.Text;
            AccountPassword = textBox2.Text;
            var Account = new AccountClient(AccountName, AccountPassword);
            Account.SaveAccount();
            Account.GetInformation();
            this.Close();
        }
    }
}

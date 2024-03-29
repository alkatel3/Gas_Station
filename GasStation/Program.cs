using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStation
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ListForm.AddForm(new ChooseWho());
            while (BaseForm.Do)
            {
                try
                {
                    Application.Run(ListForm.Show());
                }
                catch(Exception e)
                {
                    MessageBox.Show("Problem with run form \n" + e.Message);
                    ListForm.Cansel();
                }
                finally
                {
                    GasStation.SaveAllStationAtFile();
                    AccountClient.SaveAllAccountAtFile();
                }
            }
        }
    }
}

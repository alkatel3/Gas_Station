using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStation
{
    static class ListForm
    {
        static List<Form> listForm = new List<Form>(100);
        static int counter = -1;
        
        static public void AddForm (Form form)
        {
            listForm.Add(form);
            counter++;
        }
        static public Form Back()
        {
            Form form = listForm[counter];
            counter--;
            return form;
        }
        static public Form Cansel()
        {
            counter = 0;
            return listForm[counter];
        }
        static public Form Show()
        {
            return listForm[counter];
        }
    }
}

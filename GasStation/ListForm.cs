using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace GasStation
{
    static class ListForm
    {
        static List<Form> listForm = new List<Form>(100);
        
        static public void AddForm (Form form)
        {
            listForm.Add(form);
        }
        static public void Back()
        {
            listForm.RemoveAt(listForm.Count - 1);
        }
        static public void Cansel()
        {
            listForm.RemoveRange(1, listForm.ToArray().Length - 1);
        }
        static public Form Show()
        {
            try
            {
                Type FormType = listForm[listForm.Count-1].GetType();
                ConstructorInfo[] constructors = FormType.GetConstructors();
                Form form = (Form)constructors[0].Invoke(new Object[0]);
                return form;
            }
            catch
            {
                Cansel();
                MessageBox.Show("You didn't choose any form");
                return new ChooseWho();
            }
        }
    }
}

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
        static int counter = -1;
        
        static public void AddForm (Form form)
        {
            listForm.Add(form);
            counter++;
        }
        static public void Back()
        {
            listForm.RemoveAt(counter);
            counter--;
        }
        static public void Cansel()
        {
            listForm.RemoveRange(1, listForm.ToArray().Length - 1);
            counter = 0;
        }
        static public Form Show()
        {
                Type FormType = listForm[counter].GetType();
                ConstructorInfo[] constructors = FormType.GetConstructors();
                Form form = (Form)constructors[0].Invoke(new Object[0]);
                return form;
        }
    }
}

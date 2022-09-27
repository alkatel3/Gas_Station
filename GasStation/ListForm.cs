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
        static Stack<Form> StackForm = new Stack<Form>(100);
        
        static public void AddForm (Form form)
        {
            StackForm.Push(form);
        }
        static public void Back()
        {
            StackForm.Pop();
        }
        static public void Cansel()
        {
            StackForm.Clear();
            StackForm.Push(new ChooseWho());
        }
        static public Form Show()
        {
            try
            {
                Type FormType = StackForm.Peek().GetType();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendAssignment1.ConsoleService.Form
{
    internal class FormLogin : ConsoleForm
    {
        public FormLogin(string title, int left, int top, int width, int height, FormTheme formTheme) :
            base(title, left, top, width, height, formTheme)
        {
            AddFormField(new FormField("Login", 3, 2, 12 ));
            AddFormField(new FormField("Password", 3, 4, 12));
        }

        public T GetInput<T>()
        {
            
        }
    }
}

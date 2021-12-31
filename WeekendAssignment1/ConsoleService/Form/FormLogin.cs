using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WeekendAssignment1.ConsoleService.Form
{
    internal class FormLogin : ConsoleForm
    {
        public FormLogin(string title, int left, int top, int width, int height, FormTheme formTheme) :
            base(title, left, top, width, height, formTheme)
        {
            AddFormField(new FormField("Username", 3, 2, 12, "Login"));
            AddFormField(new FormField("Password", 3, 4, 12));
        }

        public T GetInput<T>() where T : class, new()
        {
            T obj = new();
            var inputType = typeof(T);

            //var properties = inputType.GetProperties(
            //    System.Reflection.BindingFlags.Public |
            //    System.Reflection.BindingFlags.Instance |
            //    System.Reflection.BindingFlags.DeclaredOnly);

            foreach (var formField in FormFields)
            {
                var piInstance = inputType.GetProperty(formField.Name);

                Debug.Assert(piInstance != null);
                piInstance.SetValue(obj, formField.Value);
            }

            return obj;
        }
    }
}

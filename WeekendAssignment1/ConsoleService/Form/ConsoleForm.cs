using System;
using System.Collections.Generic;
using System.Diagnostics;
using WeekendAssignment1.ConsoleService.Exceptions;
using WeekendAssignment1.Entities;

namespace WeekendAssignment1.ConsoleService.Form
{
    internal class ConsoleForm
    {
        private readonly string _title;
        private readonly FormTheme _formTheme;
        private readonly FormBorder _formBorder;

        protected readonly List<FormField> FormFields;

        public ConsoleForm(string title, int left, int top, int width, int height, FormTheme formTheme)
        {
            if (width - title.Length < 3)
                throw new FormTooSmallException();

            _formBorder = new FormBorder(left, top, width, height, formTheme);
            _title = title;
            _formTheme = formTheme;
            FormFields = new List<FormField>();
        }

        protected void AddFormField(FormField formField)
        {
            FormFields.Add(formField);
        }

        public void Show()
        {
            _formBorder.DisplayRuler = false;
            _formBorder.Display(_title);

            DisplayBackground();

            DisplayFormFields();

            var loginInfo = InputFormFields<LoginInfo>();

            Console.SetCursorPosition(_formBorder.Left, _formBorder.Bottom + 1);
        }

        private void DisplayBackground()
        {
            _formTheme.SetFormColor();
            var rowIndex = _formBorder.Top + 1;

            for (var i = 1; i < _formBorder.Height - 1; i++)
            {
                var formBackground = new string(' ', _formBorder.Width - 2);

                Console.SetCursorPosition(_formBorder.Left + 1, rowIndex);
                Console.Write(formBackground);

                rowIndex++;
            }

            _formTheme.ResetFormColor();
        }

        private void DisplayFormFields()
        {
            //foreach (var formField in FormFields)
            //{
            //    Console.SetCursorPosition(_formBorder.Left + formField.Left, _formBorder.Top + formField.Top);
            //    Console.Write($"{formField.Name}: {new string('_', formField.ValueWidth)}");
            //}
            _formTheme.SetFormColor();

            foreach (var formField in FormFields)
            {
                formField.Display(_formBorder.Left, _formBorder.Top);
            }

            _formTheme.ResetFormColor();
        }

        private T InputFormFields<T>() where T : class, new()
        {
            T obj = new();
            var inputType = typeof(T);

            foreach (var formField in FormFields)
            {
                formField.Input(_formBorder.Left, _formBorder.Top);

                var piInstance = inputType.GetProperty(formField.Name);

                Debug.Assert(piInstance != null);
                piInstance.SetValue(obj, formField.Value);
            }

            return obj;
        }
    }
}

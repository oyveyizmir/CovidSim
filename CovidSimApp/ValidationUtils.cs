using CovidSim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidSimApp
{
    class ValidationUtils
    {
        public static T ValidateAndGet<T>(TextBox edit, string message) => ValidateAndGet<T>(edit, null, message);

        public static T? ValidateAndGetNullable<T>(TextBox edit, Func<T, bool> validationFunc, string message) where T : struct
        {
            if (edit.Text.Trim().Length == 0)
                return null;

            return ValidateAndGet(edit, validationFunc, message);
        }

        public static T ValidateAndGet<T>(TextBox edit, Func<T, bool> validationFunc, string message)
        {
            T value;

            try
            {
                try
                {
                    value = (T)Convert.ChangeType(edit.Text, typeof(T));
                }
                catch (FormatException)
                {
                    throw new ValidationException(message);
                }

                if (validationFunc == null || validationFunc(value))
                    return value;

                throw new ValidationException(message);
            }
            catch (ValidationException)
            {
                Control control = edit;

                while (true)
                {
                    control = control.Parent;
                    if (control is Form)
                        break;
                    if (control is TabPage tabPage)
                    {
                        var tabControl = (TabControl)tabPage.Parent;
                        tabControl.SelectedTab = tabPage;
                        break;
                    }
                }

                edit.Focus();
                MessageBox.Show(message, "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                throw;
            }
        }
    }
}

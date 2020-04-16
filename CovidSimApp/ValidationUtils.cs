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
        public static T ValidateAndGet<T>(TextBox edit, Func<T, bool> validationFunc, string message)
        {
            try
            {
                T value = (T)Convert.ChangeType(edit.Text, typeof(T));
                if (validationFunc(value))
                    return value;
                throw new FormatException(message);
            }
            catch (FormatException)
            {
                MessageBox.Show(message, "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                edit.Focus();
                throw;
            }
        }
    }
}

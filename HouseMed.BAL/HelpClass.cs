using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HouseMed;

namespace HouseMed.BAL
{
    /// <summary>
    /// Static helper class for helper methods for PL actions
    /// </summary>
    public static class HelpClass
    {
        /// <summary>
        /// Method for returning the null value and not 0 to DB if some textboxes are null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T? GetValueOrNull<T>(this string value) where T : struct
        {
            try
            {
                if (string.IsNullOrEmpty(value))
                {
                    return null;
                }
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch (Exception e)
            {
                if(e is FormatException)
                {
                    MessageBox.Show(String.Format("Vijednost: '{0}' je krivog formata", value), "Upozorenje!");
                }
                return null;
            }
        }

        public enum Ecarton
        {
            Uputnica = 1,
            Recept,
            Cijepljenje,
            Hospitalizacija,
            Postupci,
            Raspored
        }
    }
}

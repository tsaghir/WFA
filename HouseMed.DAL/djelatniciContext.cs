using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    /// <summary>
    /// Extended class for presonal and calculated properties
    /// </summary>
    public partial class djelatnici
    {
        private string imePrezime;

        public string ImePrezime
        {
            get
            {
                return string.Concat(ime," ",prezime);
            }

            set
            {
                imePrezime = value;
            }
        }
    }
}

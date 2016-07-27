using HouseMed.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.BAL
{
    public class DjelatniciBAL
    {
        #region private variables
        private DjelatniciDAL _djelatnici;
        #endregion

        #region constructor
        public DjelatniciBAL()
        {
            _djelatnici = new DjelatniciDAL();
        }
        #endregion

        #region public methods
        /// <summary>
        /// Method for getting all the workers in the hospital
        /// </summary>
        /// <returns></returns>
        public IEnumerable<djelatnici> GetAllDjelatnici()
        {
            return _djelatnici.GetAllDjelatnici();
        }
        #endregion

    }
}

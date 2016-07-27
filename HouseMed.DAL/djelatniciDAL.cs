using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    public class DjelatniciDAL
    {
        #region private variables
        // instance the DB entities so we can use it as a context for queries
        DAL.HouseMedDBEntities context = new HouseMedDBEntities();
        #endregion

        #region public methods
        /// <summary>
        /// Method for getting all the workers in the hospital
        /// </summary>
        /// <returns></returns>
        public IEnumerable<djelatnici> GetAllDjelatnici()
        {
            try
            {
                return (from a in context.djelatnici
                        select a).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

    }
}

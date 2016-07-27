using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    public class ZdravUstanovaDAL
    {
        #region private variables
        // instance the DB context
        DAL.HouseMedDBEntities context = new HouseMedDBEntities();
        #endregion

        #region public methods
        /// <summary>
        /// Getting ALL the Ustanovas from the DB
        /// </summary>
        /// <returns></returns>
        public IEnumerable<sifra_zdrv_ustanove> GetAllUstanove()
        {
            try
            {
                return (from a in context.sifra_zdrv_ustanove
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

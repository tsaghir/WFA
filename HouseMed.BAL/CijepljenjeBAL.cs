using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMed.DAL;
using System.ComponentModel;

namespace HouseMed.BAL
{
    public class CijepljenjeBAL
    {
        #region private variables
        private CijepljenjeDAL _cijepljenjeDAL;
        #endregion

        #region constructor
        public CijepljenjeBAL()
        {
            _cijepljenjeDAL = new CijepljenjeDAL();
        }
        #endregion

        #region public methods
        /// <summary>
        /// Method for getting "Cijepljenje" from DB with Full prop names for data grid views
        /// </summary>
        /// <param name="pacijentId"></param>
        /// <returns></returns>
        public BindingList<cijepljenjeCustom> GetAllCijepPropNamesById(int pacijentId)
        {
            return _cijepljenjeDAL.GetAllCijepPropNamesById(pacijentId);
        }
        public BindingList<cijepljenjeCustom> GetAllRasporedPropNamesByDate(DateTime datum)
        {
            return _cijepljenjeDAL.GetAllRasporedPropNamesByDate(datum);
        }

        /// <summary>
        /// funkcija za DAL koja zbraja broj redaka u tablici
        /// </summary>
        /// <returns></returns>
        public int broj()
        {
            return _cijepljenjeDAL.broj();
        }

        /// <summary>
        /// funkcija koja poziva DAL za unos novog cijepljenja
        /// </summary>
        /// <param name="pregled"></param>
        public void AddNewCijepljenje(cijepljenje cijep)
        {
            _cijepljenjeDAL.AddNewCijepljenje(cijep);
        }
        #endregion
    }
}

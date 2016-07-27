using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMed.DAL;
using System.ComponentModel;

namespace HouseMed.BAL
{
    public class RasporedBAL
    {
        #region private variables
        private RasporedDAL _rasporedDAL;
        #endregion

        #region constructor
        public RasporedBAL()
        {
            _rasporedDAL = new RasporedDAL();
        }
        #endregion

        #region public methods
        /// <summary>
        /// Method for getting ALL "Raspored" from DB with custom prop names
        /// </summary>
        /// <param name="pacijentId"></param>
        /// <returns></returns>
        public BindingList<rasporedCustom> GetAllRasporedPropNamesById(int pacijentId)
        {
            return _rasporedDAL.GetAllRasporedPropNamesById(pacijentId);
        }

        public BindingList<rasporedCustom> GetAllRasporedPropNamesByDate(DateTime datum)
        {
            return _rasporedDAL.GetAllRasporedPropNamesByDate(datum);
        }
        /// <summary>
        /// pozivanje funkcije na DAL za dodavanje Pregleda
        /// </summary>
        /// <param name="pacijent"></param>
        public void AddNewRaspored(raspored pregled)
        {
            _rasporedDAL.AddNewRaspored(pregled);
        }
        /// <summary>
        /// pozivanje funckije na DALU za zbroj redaka
        /// </summary>
        /// <returns></returns>
        public int broj()
        {
            return _rasporedDAL.broj();
        }
        #endregion
    }
}

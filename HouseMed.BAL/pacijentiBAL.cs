using HouseMed.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.BAL
{
    public class PacijentiBAL
    {
        #region private variables
        private PacijentiDAL _pacijentiDAL;
        #endregion

        #region constructor
        public PacijentiBAL()
        {
            _pacijentiDAL = new PacijentiDAL();
        }
        #endregion

        #region public methods
        /// <summary>
        /// method for getting all the "pacijenti" from the DB
        /// </summary>
        /// <returns></returns>
        public BindingList<pacijenti> GetAllPacijenti()
        {
            return _pacijentiDAL.GetAllPacijenti();
        }
        /// <summary>
        /// metoda za dobivanje svih pacijenta po pretrazenom tekstu
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public BindingList<pacijenti> GetAllPacijentiBy(string name)
        {
            return _pacijentiDAL.GetAllPacijentiBy(name);
        }


        public void AddNewPacijent(pacijenti pacijent)
        {
            _pacijentiDAL.AddNewPacijent(pacijent);
        }

        /// <summary>
        /// Remove patient by id
        /// </summary>
        /// <param name="pacijentiID"></param>
        public void RemovePatientById(int pacijentiID)
        {
            _pacijentiDAL.RemovePatientById(pacijentiID);
        }

        /// <summary>
        /// update pacijenta
        /// </summary>
        public void SaveChanges()
        {
            _pacijentiDAL.SaveChanges();
        }
        #endregion
    }
}

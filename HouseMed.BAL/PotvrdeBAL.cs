using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMed.DAL;
using System.ComponentModel;

namespace HouseMed.BAL
{
    public class PotvrdeBAL
    {
        #region private variables
        private PotvrdeDAL _potvrdeDAL;
        #endregion

        #region constructor
        public PotvrdeBAL()
        {
            _potvrdeDAL = new PotvrdeDAL();
        }
        #endregion


        #region public methods
        /// <summary>
        /// Method for getting all the "Postupci" from DB with custom props names
        /// </summary>
        /// <param name="pacijentId"></param>
        /// <returns></returns>
        public BindingList<potvrdeCustom> GetAllPotvrdeByID(int pacijentId)
        {
            return _potvrdeDAL.GetAllPotvrdeByID(pacijentId);
        }

        public void AddNewPotvrda(potvrde potvrda)
        {
            _potvrdeDAL.AddNewPotvrda(potvrda);
        }

        public potvrde GetPotvrdaByID(int potvrdaID)
        {
            return _potvrdeDAL.GetPotvrdaByID(potvrdaID);
        }

        public void SaveChanges()
        {
            _potvrdeDAL.SaveChanges();
        }

        public void RemovePotvrdaByID(int potvrdaID)
        {
            _potvrdeDAL.RemovePotvrdaByID(potvrdaID);
        }


        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMed.DAL;
using System.ComponentModel;

namespace HouseMed.BAL
{
    public class PostupciBAL
    {
        #region private variables
        PostupciDAL _postupciDAL;
        #endregion

        #region constructor
        public PostupciBAL()
        {
            _postupciDAL = new PostupciDAL();
        }
        #endregion

        #region public methods
        /// <summary>
        /// Method for getting all the "Postupci" from DB with custom props names
        /// </summary>
        /// <param name="pacijentId"></param>
        /// <returns></returns>
        public BindingList<postupciCustom> GetAllPostupciPropNamesById(int pacijentId)
        {
            return _postupciDAL.GetAllPostupciPropNamesById(pacijentId);
        }

        public void AddNewPostupak(postupci postupak)
        {
            _postupciDAL.AddNewPostupak(postupak);
        }
        #endregion
    }
}

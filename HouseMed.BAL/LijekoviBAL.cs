using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMed.DAL;
using System.ComponentModel;

namespace HouseMed.BAL
{
    public class LijekoviBAL
    {
        #region private variables
        private LijekoviDAL _lijekoviDAL;
        #endregion

        #region constructor
        public LijekoviBAL()
        {
            _lijekoviDAL = new LijekoviDAL();
        }
        #endregion

        #region public methods
        /// <summary>
        /// Getting all the medications from the DB
        /// </summary>
        /// <returns></returns>
        public BindingList<lijekovi> GetAllLijekovi()
        {
            return _lijekoviDAL.GetAllLijekovi();
        }

        /// <summary>
        /// Getting medication from DB by name for filtering purposes 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public BindingList<lijekovi> GetLijekoviByName(string name)
        {
            return _lijekoviDAL.GetLijekoviByName(name);
        }
        /// <summary>
        /// Deleting the lijekovi object from the DB
        /// </summary>
        /// <param name="selectedLijek"></param>
        /// <returns></returns>
        public bool DeleteLijek(lijekovi selectedLijek)
        {
            return _lijekoviDAL.DeleteLijek(selectedLijek);
        }
        /// <summary>
        /// Saving the changes in the database
        /// </summary>
        public void SaveChanges()
        {
            _lijekoviDAL.SaveChanges();
        }
        /// <summary>
        /// Adds "lijek" object into the DB
        /// </summary>
        /// <param name="lijek"></param>
        public void AddNewLijekoviObject(lijekovi lijek)
        {
            _lijekoviDAL.AddNewLijekoviObject(lijek);
        }
        #endregion
    }
}


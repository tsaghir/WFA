using HouseMed.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.BAL
{
    public class ReceptiBAL
    {
        #region private variables
        private ReceptiDAL _receptiDAL;
        #endregion

        #region consturctor
        public ReceptiBAL()
        {
            _receptiDAL = new ReceptiDAL();
        }
        #endregion

        #region public methods
        /// <summary>
        /// Returns all the "Recepti" from the DB to bind the bindingsource
        /// </summary>
        /// <returns></returns>
        public BindingList<receptiCustom> GetAllReceptiNamedProps()
        {
            return _receptiDAL.GetAllReceptiNamedProps();
        }
        /// <summary>
        /// Returns all the "Recepti" from the DB with ID names not values
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BindingList<receptiCustom> GetAllReceptiNamedPropsById(int PacijentId)
        {
            return _receptiDAL.GetAllReceptiNamedPropsById(PacijentId);
        }
        /// <summary>
        /// Gets a single "recepti" object from the database
        /// </summary>
        public recepti GetReceptObjectById(int receptId)
        {
           return  _receptiDAL.GetReceptObjectById(receptId);
        }
        /// <summary>
        /// Bool method for deleting the recept object from the database
        /// </summary>
        /// <param name="recept"></param>
        /// <returns></returns>
        public bool DeleteRecept(int receptId)
        {
            return _receptiDAL.DeleteReceptById(receptId);
        }
        /// <summary>
        /// Adds new "Recept" into the DB
        /// </summary>
        public void AddNewRecept(recepti recept)
        {
            _receptiDAL.AddNewRecept(recept);
        }
        /// <summary>
        /// Method for saving the current context (used for updating)
        /// </summary>
        public void SaveChanges()
        {
            _receptiDAL.SaveChanges();
        }
        #endregion

    }
}

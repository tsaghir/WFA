using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HouseMed.DAL
{
    public class LijekoviDAL
    {
        #region private variables
        // instance the context
        HouseMedDBEntities context = new HouseMedDBEntities();
        #endregion

        #region public methods
        /// <summary>
        /// #1 Getting ALL the medication from the DB
        /// </summary>
        /// <returns></returns>
        public BindingList<lijekovi> GetAllLijekovi()
        {
            try
            {
                var lijekovi = (from a in context.lijekovi
                                select a).ToList();
                BindingList<lijekovi> lista = new BindingList<DAL.lijekovi>(lijekovi);
                return lista;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LijekoviDAL(#1): {0}", ex.InnerException);
                return null;
            }
        }
        /// <summary>
        /// #2 Getting the medication by name for filtering purposes
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public BindingList<lijekovi> GetLijekoviByName(string name)
        {
            try
            {
                var lijekovi = (from a in context.lijekovi
                                where a.naziv.Contains(name) || a.kolicina.ToString().Contains(name) 
                                select a).ToList();
                BindingList<lijekovi> lista = new BindingList<DAL.lijekovi>(lijekovi);
                return lista;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LijekoviDAL(#2): {0}", ex.InnerException);
                return null;
            }
        }
        /// <summary>
        /// #3 Deleting the lijekovi object from the DB
        /// </summary>
        /// <param name="selectedLijek"></param>
        /// <returns></returns>
        public bool DeleteLijek(lijekovi selectedLijek)
        {
            try
            {
                context.lijekovi.Remove(selectedLijek);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LijekoviDAL(#3): {0}", ex.InnerException);
                return false;
            }
        }
        /// <summary>
        /// #4 Adds "lijek" object into the DB
        /// </summary>
        /// <param name="lijek"></param>
        public void AddNewLijekoviObject(lijekovi lijek)
        {
            try
            {
                context.lijekovi.Add(lijek);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LijekoviDAL(#4): {0}", ex.InnerException);
            }
        }
        /// <summary>
        ///#5 Saving the changes in the database
        /// </summary>
        public void SaveChanges()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LijekoviDAL(#5): {0}", ex.InnerException);
            }
        }
        #endregion
    }
}

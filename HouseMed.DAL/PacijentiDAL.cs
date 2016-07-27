using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HouseMed.DAL
{
    public class PacijentiDAL
    {
        #region private variables
        // instance DB context
        HouseMedDBEntities context = new HouseMedDBEntities();
        #endregion

        #region public methods
        /// <summary>
        /// Method for getting ALL the "pacijenti" from the DB
        /// </summary>
        /// <returns></returns>
        public BindingList<pacijenti> GetAllPacijenti()
        {
            try
            {

                var pacijenti = (from a in context.pacijenti
                                 select a).ToList();
                BindingList<pacijenti> lista = new BindingList<pacijenti>(pacijenti);
                return lista;
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Greška kod GetAllPacijenti", ex.InnerException);
                return null;

            }
        }


        /// <summary>
        /// Remove patient by id
        /// </summary>
        /// <param name="pacijentiID"></param>
        public void RemovePatientById(int pacijentiID)
        {
            try
            {
                var pacijent = (from a in context.pacijenti
                                where a.pacijentiID == pacijentiID
                                select a).FirstOrDefault();

                context.pacijenti.Remove(pacijent);
                context.SaveChanges();
            } catch(Exception ex)
            {
                Debug.WriteLine("Greška kod RemovePatientById", ex.InnerException);
                
            }
        }
            

        /// <summary>
        /// Adds new "Pacijent" u bazu
        /// </summary>
        public void AddNewPacijent(pacijenti pacijent)
        {
            try
            {
                context.pacijenti.Add(pacijent);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Greška kod AddNewPacijent", ex.InnerException);
            }
        }

        /// <summary>
        /// funkcija za update pacijenta u bazi
        /// </summary>
        public void SaveChanges()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Greška kod SaveChanges", ex.InnerException);
            }
            #endregion
        }
        /// <summary>
        /// dobivanje pacijenata po trazenom textu
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public BindingList<pacijenti> GetAllPacijentiBy(string name)
        {
            try
            {
                var pacijenti = (from a in context.pacijenti
                                where a.OIB.ToString().Contains(name) || a.ime.Contains(name) || a.prezime.Contains(name) || a.mjesto.Contains(name) || a.adresa.Contains(name) || a.drzava.Contains(name) || a.email.Contains(name) || a.mobitel.Contains(name) || a.spol.Contains(name)
                                select a).ToList();
                BindingList<pacijenti> lista = new BindingList<DAL.pacijenti>(pacijenti);
                return lista;
            }
            catch (Exception ex)
            {

                Debug.WriteLine("Greška kod GetAllPacijentiBy", ex.InnerException);
                return null;
            }
        }
    }
}

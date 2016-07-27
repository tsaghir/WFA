using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HouseMed.DAL
{
    public class PotvrdeDAL
    {
        #region private variables
        // instance the context
        HouseMedDBEntities context = new HouseMedDBEntities();
        #endregion

        public BindingList<potvrdeCustom> GetAllPotvrdeByID(int pacijentId)
        {
            try
            {
                var potvrde = (from a in context.potvrde
                               join b in context.pacijenti on a.pacijentiID equals b.pacijentiID
                               where a.pacijentiID == pacijentId
                               join c in context.djelatnici on a.djelatniciID equals c.djelatniciID
                               select new potvrdeCustom()
                               {
                                   PotvrdaID = a.potvrdeID,
                                   Svrha = a.svrha,
                                   Opis = a.opis,
                                   Djelatnik = string.Concat(c.ime, " ", c.prezime)
                               }
                                       ).ToList();
                BindingList<potvrdeCustom> lista = new BindingList<potvrdeCustom>(potvrde);
                return lista;
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Greška kod GetAllPotvrdeByID", ex.InnerException);
                return null;
            }
        }

        public void SaveChanges()
        {
            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Greška kod SaveChanges", ex.InnerException);
                
            }
        }

        public void RemovePotvrdaByID(int potvrdaID)
        {
            try
            {
                var potvrda = (from a in context.potvrde
                               where a.potvrdeID == potvrdaID
                               select a).FirstOrDefault();
                context.potvrde.Remove(potvrda);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Greška kod RemovePotvrdaByID", ex.InnerException);
            }
        }

        public potvrde GetPotvrdaByID(int potvrdaID)
        {
            try
            {
                var potvrda = (from a in context.potvrde
                               where a.potvrdeID == potvrdaID
                               select a).FirstOrDefault();
                return potvrda;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Greška kod GetPotvrdaByID", ex.InnerException);
                return null;
            }
        }

        public void AddNewPotvrda(potvrde potvrda)
        {
            try
            {
                context.potvrde.Add(potvrda);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Greška kod AddNewPotvrda", ex.InnerException);
            }
        }
    }
}

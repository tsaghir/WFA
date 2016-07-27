using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HouseMed.DAL
{
    public class RasporedDAL
    {
        #region private variables
        HouseMedDBEntities context = new HouseMedDBEntities();
        #endregion

        #region public methods
        /// <summary>
        /// Method for getting ALL "Raspored" from DB with custom prop names
        /// </summary>
        /// <param name="pacijentId"></param>
        /// <returns></returns>
        public BindingList<rasporedCustom> GetAllRasporedPropNamesById(int pacijentId)
        {
            try
            {
                var raspored = (from a in context.raspored
                                join b in context.sifra_zdrv_ustanove on a.sifra_zdrv_ustanoveID equals b.sifra_zdrv_ustanoveID
                                join c in context.pacijenti on a.pacijentiID equals c.pacijentiID
                                where a.pacijentiID == pacijentId
                                select new rasporedCustom()
                                {
                                    RaposredId = a.rasporedID,
                                    Datum = a.datum,
                                    Vrijeme = a.vrijeme,
                                    Ustanova = b.naziv,
                                    Pacijent = string.Concat(c.ime, " ", c.prezime),
                                    Opis = a.opis
                                }).ToList();
                BindingList<rasporedCustom> lista = new BindingList<rasporedCustom>(raspored);
                return lista;
            } catch(Exception ex)
            {
                Debug.WriteLine("Greška kod GetAllRasporedPropNamesById", ex.InnerException); 
                    return null;
            }
        }

        public BindingList<rasporedCustom> GetAllRasporedPropNamesByDate(DateTime datum)
        {
            try
            {
                var raspored = (from a in context.raspored
                                join b in context.sifra_zdrv_ustanove on a.sifra_zdrv_ustanoveID equals b.sifra_zdrv_ustanoveID
                                join c in context.pacijenti on a.pacijentiID equals c.pacijentiID
                                where a.datum == datum
                                select new rasporedCustom()
                                {
                                    RaposredId = a.rasporedID,
                                    Datum = a.datum,
                                    Vrijeme = a.vrijeme,
                                    Ustanova = b.naziv,
                                    Pacijent = string.Concat(c.ime, " ", c.prezime),
                                    Opis = a.opis
                                }).ToList();
                BindingList<rasporedCustom> lista = new BindingList<rasporedCustom>(raspored);
                return lista;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Greška kod GetAllRasporedPropNamesByDate", ex.InnerException);
                return null;
            }
        }
        public int broj() {
            var raspored = (from u in context.raspored select u).Count();
            

            return raspored+1;
            }

        /// <summary>
        /// Adds new "Raspored" u bazu
        /// </summary>
        public void AddNewRaspored(raspored pregled)
        {
            try
            {
                context.raspored.Add(pregled);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Greška kod GetAllRasporedPropNamesByDate", ex.InnerException); 
            }
        }
        #endregion
    }
}

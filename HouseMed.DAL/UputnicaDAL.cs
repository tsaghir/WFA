using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    public class UputnicaDAL
    {
        #region private variables
        // instance the context
        HouseMedDBEntities context = new HouseMedDBEntities();
        #endregion

        #region public methods
        /// <summary>
        /// Gets all "Uputnica" from the DB
        /// </summary>
        /// <returns></returns>
        public BindingList<uputnica> GetAllUputnica()
        {
            try
            {
                var uputnice = (from a in context.uputnica
                                select a).ToList();
                BindingList<uputnica> lista = new BindingList<uputnica>(uputnice);
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Method for getting all the Recipes from the DB with full names by ID
        /// </summary>
        /// <returns></returns>
        public BindingList<uputnicaCustom> GetAllUputnicaPropsNameById(int pacijentId)
        {
            try
            {
                var uputnica = (from a in context.uputnica
                                join b in context.pacijenti on a.pacijentID equals b.pacijentiID
                                join c in context.djelatnici on a.djelatniciID equals c.djelatniciID
                                join d in context.sifra_zdrv_ustanove on a.sifra_zdrv_ustanoveID equals d.sifra_zdrv_ustanoveID
                                where a.pacijentID == pacijentId
                                select new uputnicaCustom()
                                {
                                    UputnicaId = a.uputnicaID,
                                    Pacijent = string.Concat(b.ime, " ", b.prezime),
                                    Ustanova = d.naziv,
                                    UpucujeSe = a.upucuje_se,
                                    Dijagnoza = a.dijagnoza,
                                    TraziSe = a.trazi_se,
                                    Napomena = a.napomena,
                                    Datum = a.datum,
                                    Djelatnik = string.Concat(c.ime, " ", c.prezime)
                                }).ToList();
                BindingList<uputnicaCustom> lista = new BindingList<uputnicaCustom>(uputnica);
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// dobivanje uputnice po id za edit
        /// </summary>
        /// <param name="IDnaloga"></param>
        /// <returns></returns>
        public uputnica GetUputnicaByID(int IdUputnice)
        {
            var uputnica = (from a in context.uputnica
                         where a.uputnicaID == IdUputnice
                            select a).FirstOrDefault();
            return uputnica;
        }

        /// <summary>
        /// Method for getting all the Uputnice from the DB with full names
        /// </summary>
        /// <returns></returns>
        public BindingList<uputnicaCustom> GetAllUputnicaPropsName()
        {
            try
            {
                var uputnica = (from a in context.uputnica
                                join b in context.pacijenti on a.pacijentID equals b.pacijentiID
                                join c in context.djelatnici on a.djelatniciID equals c.djelatniciID
                                join d in context.sifra_zdrv_ustanove on a.sifra_zdrv_ustanoveID equals d.sifra_zdrv_ustanoveID
                                select new uputnicaCustom()
                                {
                                    UputnicaId = a.uputnicaID,
                                    Pacijent = string.Concat(b.ime, " ", b.prezime),
                                    Ustanova = d.naziv,
                                    UpucujeSe = a.upucuje_se,
                                    Dijagnoza = a.dijagnoza,
                                    TraziSe = a.trazi_se,
                                    Napomena = a.napomena,
                                    Datum = a.datum,
                                    Djelatnik = string.Concat(c.ime, " ", c.prezime)
                                }).ToList();
                BindingList<uputnicaCustom> lista = new BindingList<uputnicaCustom>(uputnica);
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Adds new "Uputnica" u bazu
        /// </summary>
        public void AddNewUputnica(uputnica uputnica)
        {
            try
            {
                context.uputnica.Add(uputnica);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Remove Uputnica by id
        /// </summary>
        /// <param name="uputnicaID"></param>
        public void RemoveUputnicaById(int uputnicaID)
        {
            var uputnica = (from a in context.uputnica
                            where a.uputnicaID == uputnicaID
                            select a).FirstOrDefault();

            context.uputnica.Remove(uputnica);
            context.SaveChanges();
        }

        /// <summary>
        /// funkcija za update uputnice u bazi
        /// </summary>
        public void SaveChanges()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseMed.DAL
{
    public class ReceptiDAL
    {
        #region private variables
        // instance the context DB
        HouseMedDBEntities context = new HouseMedDBEntities();
        #endregion

        #region public methods
        /// <summary>
        /// #1 Method for getting all the Recipes from the DB with full FK names
        /// </summary>
        /// <returns></returns>
        public BindingList<receptiCustom> GetAllReceptiNamedProps()
        {
            try
            {
                var recepti = (from a in context.recepti
                               join b in context.lijekovi on a.lijekoviID equals b.lijekoviID
                               join c in context.pacijenti on a.pacijentiID equals c.pacijentiID
                               join d in context.djelatnici on a.djelatniciID equals d.djelatniciID
                               join e in context.sifra_zdrv_ustanove on a.sifra_zdrv_ustanoveID equals e.sifra_zdrv_ustanoveID
                               select new receptiCustom()
                               {
                                   ReceptID = a.receptID,
                                   PacijentiIDName = string.Concat(c.ime, " ", c.prezime),
                                   LijekoviIDName = b.naziv,
                                   Slucaj = a.slucaj,
                                   Kolicina = a.kolicina,
                                   Doziranje = a.doziranje,
                                   Nadoplata = a.nadoplata,
                                   DjelatniciIDName = string.Concat(d.ime, " ", d.prezime),
                                   SifraZdrvUstanoveIDName = e.naziv,
                                   DjelatniciID = d.djelatniciID,
                                   LijekoviID = b.lijekoviID,
                                   PacijentID = c.pacijentiID,
                                   UstanovaID = e.sifra_zdrv_ustanoveID
                               }).ToList();
                BindingList<receptiCustom> lista = new BindingList<receptiCustom>(recepti);
                return lista;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ReceptiDAL(#1): {0}", ex.InnerException);
                return null;
            }
        }
        /// <summary>
        /// #2 Method for getting all the Recipes from the DB with full FK names by pacijentId
        /// </summary>
        /// <returns></returns>
        public BindingList<receptiCustom> GetAllReceptiNamedPropsById(int PacijentId)
        {
            try
            {
                var recepti = (from a in context.recepti
                               join b in context.lijekovi on a.lijekoviID equals b.lijekoviID
                               join c in context.pacijenti on a.pacijentiID equals c.pacijentiID
                               join d in context.djelatnici on a.djelatniciID equals d.djelatniciID
                               join e in context.sifra_zdrv_ustanove on a.sifra_zdrv_ustanoveID equals e.sifra_zdrv_ustanoveID
                               where a.pacijentiID == PacijentId
                               select new receptiCustom()
                               {
                                   ReceptID = a.receptID,
                                   Slucaj = a.slucaj,
                                   LijekoviIDName = b.naziv,
                                   Kolicina = a.kolicina,
                                   Doziranje = a.doziranje,
                                   Nadoplata = a.nadoplata,
                                   PacijentiIDName = string.Concat(c.ime, " ", c.prezime),
                                   DjelatniciIDName = string.Concat(d.ime, " ", d.prezime),
                                   SifraZdrvUstanoveIDName = e.naziv
                               }).ToList();
                BindingList<receptiCustom> lista = new BindingList<receptiCustom>(recepti);
                return lista;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ReceptiDAL(#2): {0}", ex.InnerException);
                return null;
            }
        }
        
        /// <summary>
        /// #3 Gets a single "recepti" object from the database
        /// </summary>
        public recepti GetReceptObjectById(int receptId)
        {
            try
            {
                var recept = (from a in context.recepti
                              where a.receptID == receptId
                              select a).FirstOrDefault();
                return recept;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ReceptiDAL(#3): {0}", ex.InnerException);
                return null;
            }
        }
        /// <summary>
        /// #4 Bool method for deleting the recept object from the database
        /// </summary>
        /// <param name="recept"></param>
        /// <returns></returns>
        public bool DeleteReceptById(int receptId)
        {
            try
            {
                var recept = (from a in context.recepti
                              where a.receptID == receptId
                              select a).FirstOrDefault();

                context.recepti.Remove(recept);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ReceptiDAL(#4): {0}", ex.InnerException);
                return false;
            }
        }
        /// <summary>
        /// #5 Adds new "Recept" into the DB
        /// </summary>
        public void AddNewRecept(recepti recept)
        {
            try
            {
                context.recepti.Add(recept);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ReceptiDAL(#5): {0}", ex.InnerException);
            }
        }
        /// <summary>
        /// #6 Method for saving the current context (used for updating)
        /// </summary>
        public void SaveChanges()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ReceptiDAL(#6): {0}", ex.InnerException);
            }
        }
        #endregion

    }
}

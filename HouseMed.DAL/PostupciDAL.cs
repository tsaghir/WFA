using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    public class PostupciDAL
    {
        #region private variables
        HouseMedDBEntities context = new HouseMedDBEntities();
        #endregion

        #region public methods
        /// <summary>
        /// Method for getting all the "Postupci" from DB with custom props names
        /// </summary>
        /// <param name="pacijentId"></param>
        /// <returns></returns>
        public BindingList<postupciCustom> GetAllPostupciPropNamesById(int pacijentId)
        {
            var postupci = (from a in context.postupci
                            join b in context.djelatnici on a.ljecnikID equals b.djelatniciID
                            join c in context.pacijenti on a.pacijentiID equals c.pacijentiID
                            where a.pacijentiID == pacijentId
                            select new postupciCustom()
                            {
                                PostupciId = a.postupciID,
                                Datum = a.datum,
                                Djelatnik = string.Concat(b.ime," ", b.prezime),
                                Anamneza = a.anamneza,
                                Status = a.status,
                                Dijagnoza = a.dijagnoza,
                                Terapija = a.terapija,
                                Preporuka = a.preporuka,
                                Pacijent = string.Concat(c.ime," ", c.prezime)
                            }).ToList();
            BindingList<postupciCustom> lista = new BindingList<postupciCustom>(postupci);
            return lista;
        }

        /// <summary>
        /// Dodaje novi postupak u bazu
        /// </summary>
        /// <param name="postupak"></param>
        public void AddNewPostupak(postupci postupak)
        {
            try
            {
                context.postupci.Add(postupak);
                context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMed.DAL;
using System.ComponentModel;
using System.Windows.Forms;

namespace HouseMed.BAL
{
    public class HospitalizacijaBAL
    {
        #region private varibales
        private HospitalizacijaDAL _hospitalizacijaDAL;
        #endregion

        #region constructor
        public HospitalizacijaBAL()
        {
            _hospitalizacijaDAL = new HospitalizacijaDAL();
        }
        #endregion

        #region public methods
        /// <summary>
        /// Getting ALL the "Hospitalizacija" from DB with custom prop names
        /// </summary>
        /// <param name="pacijentId"></param>
        /// <returns></returns>
        public BindingList<hospitalizacijaCustom> GetAllHospitalizacijaPropNamesById(int pacijentId)
        {
            return _hospitalizacijaDAL.GetAllHospitalizacijaPropNamesById(pacijentId);
        }

        /// <summary>
        /// dodavanje nove uputnice
        /// </summary>
        /// <param name="nalog"></param>
        public void AddNewNalog(evidencija_hospitalizacije nalog)
        {
            _hospitalizacijaDAL.AddNewNalog(nalog);
        }

        /// <summary>
        /// Funkcija koja vraća novi id naloga
        /// </summary>
        /// <returns></returns>
        public int getNewID()
        {
            return _hospitalizacijaDAL.getNewID();
        }

        /// <summary>
        /// Briše nalog s određenim ID-jem
        /// </summary>
        /// <param name="evidencija_hospitalizacijeID"></param>
        public void RemoveNalogByID(string evidencija_hospitalizacijeID)
        {
            _hospitalizacijaDAL.RemoveNalogByID(evidencija_hospitalizacijeID);
        }

        // <summary>
        /// update hospitalizacija
        /// </summary>
        public void SaveChanges()
        {
            _hospitalizacijaDAL.SaveChanges();
        }

        
        /// <summary>
        /// Vraća objekt koji ima određeni ID
        /// </summary>
        /// <param name="IDnaloga"></param>
        /// <returns></returns>
        public evidencija_hospitalizacije GetNalogByID(string IDnaloga)
        {
            return _hospitalizacijaDAL.GetNalogByID(IDnaloga);
        }

        /// <summary>
        /// Pretražuje boravke po svim stupcima
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pacijentiID"></param>
        /// <returns></returns>
        public BindingList<hospitalizacijaCustom> SearchHospitalizacija(string name, int pacijentiID)
        {
            return _hospitalizacijaDAL.SearchHospitalizacija(name, pacijentiID);
        }
        #endregion
    }
}

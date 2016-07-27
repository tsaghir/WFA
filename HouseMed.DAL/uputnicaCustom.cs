using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    /// <summary>
    /// Custom entity for query purposes
    /// </summary>
    public class uputnicaCustom
    {
        private int uputnicaId;
        private string pacijent;
        private string ustanova;
        private string upucujeSe;
        private string dijagnoza;
        private string traziSe;
        private string napomena;
        private DateTime? datum;
        private string djelatnik;

        public int UputnicaId
        {
            get
            {
                return uputnicaId;
            }

            set
            {
                uputnicaId = value;
            }
        }

        public string Pacijent
        {
            get
            {
                return pacijent;
            }

            set
            {
                pacijent = value;
            }
        }

        public string Ustanova
        {
            get
            {
                return ustanova;
            }

            set
            {
                ustanova = value;
            }
        }

        public string UpucujeSe
        {
            get
            {
                return upucujeSe;
            }

            set
            {
                upucujeSe = value;
            }
        }

        public string Dijagnoza
        {
            get
            {
                return dijagnoza;
            }

            set
            {
                dijagnoza = value;
            }
        }

        public string TraziSe
        {
            get
            {
                return traziSe;
            }

            set
            {
                traziSe = value;
            }
        }

        public string Napomena
        {
            get
            {
                return napomena;
            }

            set
            {
                napomena = value;
            }
        }

        public DateTime? Datum
        {
            get
            {
                return datum;
            }

            set
            {
                datum = value;
            }
        }

        public string Djelatnik
        {
            get
            {
                return djelatnik;
            }

            set
            {
                djelatnik = value;
            }
        }
    }
}

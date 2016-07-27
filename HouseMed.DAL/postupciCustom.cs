using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    public class postupciCustom
    {
        private int postupciId;
        private DateTime? datum;
        private string djelatnik;
        private string anamneza;
        private string status;
        private string terapija;
        private string dijagnoza;
        private string preporuka;
        private string pacijent;

        public int PostupciId
        {
            get
            {
                return postupciId;
            }

            set
            {
                postupciId = value;
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

        public string Anamneza
        {
            get
            {
                return anamneza;
            }

            set
            {
                anamneza = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public string Terapija
        {
            get
            {
                return terapija;
            }

            set
            {
                terapija = value;
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

        public string Preporuka
        {
            get
            {
                return preporuka;
            }

            set
            {
                preporuka = value;
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
    }
}

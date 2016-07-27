using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    public class cijepljenjeCustom
    {
        private int cijepljenjeId;
        private string slucaj;
        private DateTime? datum;
        private string vrstaCijepljenja;
        private string pripravaCjepiva;
        private string brojDoze;
        private int? kolicina;
        private string djelatnik;
        private string pacijent;

        public int CijepljenjeId
        {
            get
            {
                return cijepljenjeId;
            }

            set
            {
                cijepljenjeId = value;
            }
        }

        public string Slucaj
        {
            get
            {
                return slucaj;
            }

            set
            {
                slucaj = value;
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

        public string VrstaCijepljenja
        {
            get
            {
                return vrstaCijepljenja;
            }

            set
            {
                vrstaCijepljenja = value;
            }
        }

        public string PripravaCjepiva
        {
            get
            {
                return pripravaCjepiva;
            }

            set
            {
                pripravaCjepiva = value;
            }
        }

        public string BrojDoze
        {
            get
            {
                return brojDoze;
            }

            set
            {
                brojDoze = value;
            }
        }

        public int? Kolicina
        {
            get
            {
                return kolicina;
            }

            set
            {
                kolicina = value;
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

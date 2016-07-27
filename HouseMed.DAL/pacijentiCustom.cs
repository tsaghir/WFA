using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    public class pacijentiCustom
    {
        private int pacijentiId;
        private int MBO;
        private int OIB;
        private string ime;
        private string prezime;
        private string spol;
        private string mjesto;
        private string adresa;
        private string drzava;
        private string telefon;
        private string mobitel;
        private string email;
        private string ustanova;

        public int PacijentiId
        {
            get
            {
                return pacijentiId;
            }

            set
            {
                pacijentiId = value;
            }
        }

        public int MBo
        {
            get
            {
                return MBO;
            }

            set
            {
                MBO = value;
            }
        }

        public int OIb
        {
            get
            {
                return OIB;
            }

            set
            {
                OIB = value;
            }
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public string Spol
        {
            get
            {
                return spol;
            }

            set
            {
                spol = value;
            }
        }
        public string Mjesto
        {
            get
            {
                return mjesto;
            }

            set
            {
                mjesto = value;
            }
        }
        public string Adresa
        {
            get
            {
                return adresa;
            }

            set
            {
                adresa = value;
            }
        }
        public string Drzava
        {
            get
            {
                return drzava;
            }

            set
            {
                drzava = value;
            }
        }
        public string Telefon
        {
            get
            {
                return telefon;
            }

            set
            {
                telefon = value;
            }
        }
        public string Mobitel
        {
            get
            {
                return mobitel;
            }

            set
            {
                mobitel = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    public class potvrdeCustom
    {
        private int potvrdeID;
        private string svrha;
        private string opis;
        private string djelatnik;

        public int PotvrdaID
        {
            get
            {
                return potvrdeID;
            }

            set
            {
                potvrdeID = value;
            }
        }

        public string Svrha
        {
            get
            {
                return svrha;
            }

            set
            {
                svrha = value;
            }
        }

        public string Opis
        {
            get
            {
                return opis;
            }

            set
            {
                opis = value;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    public class rasporedCustom
    {
        private int raposredId;
        private DateTime? datum;
        private TimeSpan? vrijeme;
        private string ustanova;
        private string pacijent;
        private string opis;

        public int RaposredId
        {
            get
            {
                return raposredId;
            }

            set
            {
                raposredId = value;
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

        public TimeSpan? Vrijeme
        {
            get
            {
                return vrijeme;
            }

            set
            {
                vrijeme = value;
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
    }
}

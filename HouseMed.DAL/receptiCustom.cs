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
    public class receptiCustom
    {
        private int receptID;
        private int? djelatniciID;
        private int? ustanovaID;
        private int? pacijentID;
        private int? lijekoviID;
        private string slucaj;
        private int? kolicina;
        private string doziranje;
        private bool? nadoplata;
        private string lijekoviIDName;
        private string pacijentiIDName;
        private string djelatniciIDName;
        private string sifraZdrvUstanoveIDName;

        public int ReceptID
        {
            get
            {
                return receptID;
            }

            set
            {
                receptID = value;
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

        public string Doziranje
        {
            get
            {
                return doziranje;
            }

            set
            {
                doziranje = value;
            }
        }

        public bool? Nadoplata
        {
            get
            {
                return nadoplata;
            }

            set
            {
                nadoplata = value;
            }
        }

        public string LijekoviIDName
        {
            get
            {
                return lijekoviIDName;
            }

            set
            {
                lijekoviIDName = value;
            }
        }

        public string PacijentiIDName
        {
            get
            {
                return pacijentiIDName;
            }

            set
            {
                pacijentiIDName = value;
            }
        }

        public string DjelatniciIDName
        {
            get
            {
                return djelatniciIDName;
            }

            set
            {
                djelatniciIDName = value;
            }
        }

        public string SifraZdrvUstanoveIDName
        {
            get
            {
                return sifraZdrvUstanoveIDName;
            }

            set
            {
                sifraZdrvUstanoveIDName = value;
            }
        }

        public int? DjelatniciID
        {
            get
            {
                return djelatniciID;
            }

            set
            {
                djelatniciID = value;
            }
        }

        public int? UstanovaID
        {
            get
            {
                return ustanovaID;
            }

            set
            {
                ustanovaID = value;
            }
        }

        public int? PacijentID
        {
            get
            {
                return pacijentID;
            }

            set
            {
                pacijentID = value;
            }
        }

        public int? LijekoviID
        {
            get
            {
                return lijekoviID;
            }

            set
            {
                lijekoviID = value;
            }
        }
    }
}

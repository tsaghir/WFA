using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMed.DAL
{
    public class hospitalizacijaCustom
    {
        private string hospitalizacijaId;
        private DateTime? boravioOdDatuma;
        private DateTime? boravioDoDatuma;
        private string nazivBolnice;
        private string razlog;
        private string pacijent;

        public string HospitalizacijaId
        {
            get
            {
                return hospitalizacijaId;
            }

            set
            {
                hospitalizacijaId = value;
            }
        }

        public DateTime? BoravioOdDatuma
        {
            get
            {
                return boravioOdDatuma;
            }

            set
            {
                boravioOdDatuma = value;
            }
        }

        public DateTime? BoravioDoDatuma
        {
            get
            {
                return boravioDoDatuma;
            }

            set
            {
                boravioDoDatuma = value;
            }
        }

        public string NazivBolnice
        {
            get
            {
                return nazivBolnice;
            }

            set
            {
                nazivBolnice = value;
            }
        }

        public string Razlog
        {
            get
            {
                return razlog;
            }

            set
            {
                razlog = value;
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

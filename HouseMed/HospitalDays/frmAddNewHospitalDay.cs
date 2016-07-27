using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HouseMed.BAL;
using HouseMed.DAL;

namespace HouseMed.HospitalDays
{
    public partial class frmAddNewHospitalDay : Form
    {
        #region private variables
        private PacijentiBAL _pacijentiBAL;
        //private ReceptiBAL _receptiBAL;
        //private UputnicaBAL _uputnicaBAL;
        //private CijepljenjeBAL _cijepljenjeBAL;
        //private PostupciBAL _postupciBAL;
        private HospitalizacijaBAL _hospitalizacijaBAL;
        //private RasporedBAL _rasporedBAL;
        private hospitalizacijaCustom selectedNalog;
        int _workingPatient = 0;

        #endregion

        #region constructor
        public frmAddNewHospitalDay(int workingPatient)
        {
            InitializeComponent();
            _pacijentiBAL = new PacijentiBAL();
            _hospitalizacijaBAL = new HospitalizacijaBAL();
            _workingPatient = workingPatient;

        }

        public frmAddNewHospitalDay(hospitalizacijaCustom selectedItem, int workingPatient)
        {
            this.selectedNalog = selectedItem;
            InitializeComponent();
            _pacijentiBAL = new PacijentiBAL();
            _hospitalizacijaBAL = new HospitalizacijaBAL();
            _workingPatient = workingPatient;
        }

        #endregion

        #region private methods

        /// <summary>
        /// Instancing a new Evidencija object
        /// </summary>
        private void SetNewEvidencijaObject()
        {
            evidencija_hospitalizacije nalog = new evidencija_hospitalizacije()
            {
                evidencija_hospitalizacijeID = _hospitalizacijaBAL.getNewID().ToString(),
                boravio_od_datuma = HelpClass.GetValueOrNull<DateTime>(dtpBoravioOd.Text),
                boravio_do_datuma = HelpClass.GetValueOrNull<DateTime>(dtpBoravioDo.Text),
                naziv_bolnice = tbBolnica.Text,
                razlog = tbRazlogBoravka.Text,
                pacijentiID = _workingPatient
            };

            _hospitalizacijaBAL.AddNewNalog(nalog);
        }

        /// <summary>
        /// Sprema trenutne izmjene naloga u bazu
        /// </summary>
        private void EditNalog()
        {
            evidencija_hospitalizacije editableNalog = _hospitalizacijaBAL.GetNalogByID(selectedNalog.HospitalizacijaId.ToString());
            editableNalog.boravio_od_datuma = HelpClass.GetValueOrNull<DateTime>(dtpBoravioOd.Text);
            editableNalog.boravio_do_datuma = HelpClass.GetValueOrNull<DateTime>(dtpBoravioDo.Text);
            editableNalog.naziv_bolnice = tbBolnica.Text;
            editableNalog.razlog = tbRazlogBoravka.Text;
            _hospitalizacijaBAL.SaveChanges();
        }

        /// <summary>
        /// Učitava odabrani nalog u formu
        /// </summary>
        private void LoadSelectedNalog()
        {
            tbBolnica.Text = selectedNalog.NazivBolnice;
            dtpBoravioOd.Text = selectedNalog.BoravioOdDatuma.ToString();
            dtpBoravioOd.Text = selectedNalog.BoravioDoDatuma.ToString();
            tbRazlogBoravka.Text = selectedNalog.Razlog;
        }
        #endregion

        #region event handlers
        /// <summary>
        /// Odlučuje da li se kreira novi nalog ili sprema postojeći
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajBoravak_Click(object sender, EventArgs e)
        {
            if (selectedNalog != null)
            {
                EditNalog();
            }
            else
            {
                SetNewEvidencijaObject();
            }
            this.Close();
        }
        /// <summary>
        /// Pri učitavanju forme mjenja text gumba Dodaj/spremi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddNewHospitalDay_Load(object sender, EventArgs e)
        {
            if (selectedNalog != null)
            {
                LoadSelectedNalog();
                btnDodajBoravak.Text = "Spremi";
            }
            else
            {
                btnDodajBoravak.Text = "Dodaj";
            }
        }

        /// <summary>
        /// event koji se aktivira na tipku F1 i zove nasu wiki stranicu za pomoc korisniku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddNewHospitalDay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r16049/wiki/7.-Pomo%C4%87-korisnicima#boravci-u-bolnici");
            }
        }
        #endregion
    }
}

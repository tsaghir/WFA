using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMed.BAL;
using HouseMed.DAL;
using System.Windows.Forms;

namespace HouseMed.Raspored
{

    public partial class FrmAddNewCijepljenje : Form
    {

        #region private variables
        private DjelatniciBAL _djelatniciBAL;
        private ZdravUstanovaBAL _zdravUstanovaBAL;
        private ReceptiBAL _receptiBAL;
        private PacijentiBAL _pacijentiBAL;
        private CijepljenjeBAL _cijepljenjeBAL;
        //private int _ustanovaID;
        private int _pacijentiID;
        private int _djelatniciID;
        private RasporedBAL _rasporedBAL;
        #endregion

        #region constructor
        public FrmAddNewCijepljenje()
        {
            InitializeComponent();
            _djelatniciBAL = new DjelatniciBAL();
            _zdravUstanovaBAL = new ZdravUstanovaBAL();
            _pacijentiBAL = new PacijentiBAL();
            _receptiBAL = new ReceptiBAL();
            _rasporedBAL = new RasporedBAL();
            _cijepljenjeBAL = new CijepljenjeBAL();
        }
        #endregion

        #region event handler

        /// <summary>
        /// event za ucitanje forme koji zove funkciju  za comboboxove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddNewCijepljenje_Load(object sender, EventArgs e)
        {
            SetComboBox();
        }

        /// <summary>
        /// dohvacanje vrijednosti iz comboboxa pacijent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxPacijent_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = comboBoxPacijent.SelectedItem as pacijenti;
            _pacijentiID = selectedItem.pacijentiID;
        }

        /// <summary>
        /// dohvacanje vrijednosti iz comobboxa dijelatnik
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxDjelatnik_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = comboBoxDjelatnik.SelectedItem as djelatnici;
            _djelatniciID = selectedItem.djelatniciID;
        }

        /// <summary>
        /// klik event za poziv funkcije koja instancira objekt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajCijepljenje_Click(object sender, EventArgs e)
        {
            DateTime d1 = dateTimePickerDatum.Value;
            DateTime d2 = d1.Date;
            SetNewCijepljenjeObject(d2);

            this.Close();
        }

        #endregion

        #region private methods

        /// <summary>
        /// punjenje i prikaz comboboxa
        /// </summary>
        private void SetComboBox()
        {
            var listaDjelatnici = _djelatniciBAL.GetAllDjelatnici();
            var listaPacijenti = _pacijentiBAL.GetAllPacijenti();

            // set djelatnici
            comboBoxDjelatnik.DataSource = listaDjelatnici;
            comboBoxDjelatnik.DisplayMember = "ImePrezime";
            comboBoxDjelatnik.ValueMember = "djelatniciID";

            //set pacijenti

            comboBoxPacijent.DataSource = listaPacijenti;
            comboBoxPacijent.DisplayMember = "ImePrezime";
            comboBoxPacijent.ValueMember = "pacijentiID";


        }


        /// <summary>
        /// instanciranje objekta s podacima iz forme i poziv funkcije
        /// </summary>
        /// <param name="d2"></param>
        private void SetNewCijepljenjeObject(DateTime d2)
        {
            int broj = _cijepljenjeBAL.broj();
            cijepljenje cijep = new cijepljenje()
            {
                cijepljenjeID = broj,
                slucaj = textBoxSlucaj.Text,
                datume = d2,
                vrsta_cijepljenja = textBoxVrsta.Text,
                prirava_cjepiva = textBoxPriprava.Text,
                broj_doze = textBoxBroj.Text,
                kolicina = HelpClass.GetValueOrNull<int>(textBoxKolicina.Text),
                djelatniciID = _djelatniciID,
                pacijentiID = _pacijentiID


            };

            _cijepljenjeBAL.AddNewCijepljenje(cijep);
        }




        #endregion


    }

}

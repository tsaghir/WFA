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
    public partial class frmAddNewPregled : Form
    {
        #region private variables
        private DjelatniciBAL _djelatniciBAL;
        private ZdravUstanovaBAL _zdravUstanovaBAL;
        private ReceptiBAL _receptiBAL;
        private PacijentiBAL _pacijentiBAL;
        private int _ustanovaID;
        private int _pacijentiID;
        private RasporedBAL _rasporedBAL;
        #endregion

        #region constructor
        public frmAddNewPregled()
        {
            InitializeComponent();
            _djelatniciBAL = new DjelatniciBAL();
            _zdravUstanovaBAL = new ZdravUstanovaBAL();
            _pacijentiBAL = new PacijentiBAL();
            _receptiBAL = new ReceptiBAL();
            _rasporedBAL = new RasporedBAL();
            SetComboBox();
        }

        public frmAddNewPregled(pacijenti trenutniPacijent)
        {
            InitializeComponent();
            _djelatniciBAL = new DjelatniciBAL();
            _zdravUstanovaBAL = new ZdravUstanovaBAL();
            _pacijentiBAL = new PacijentiBAL();
            _receptiBAL = new ReceptiBAL();
            _rasporedBAL = new RasporedBAL();
            SetComboBox();
            comboBoxPacijent.Text = trenutniPacijent.ImePrezime;
        }
        #endregion

        #region event handler
        /// <summary>
        /// dohvacanje vrijednosti iz comboboxa pacijenti
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxPacijent_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = comboBoxPacijent.SelectedItem as pacijenti;
            _pacijentiID = selectedItem.pacijentiID;
        }

        /// <summary>
        /// dohvacanje vrijednosti iz comboboxa zdrastvena ustanova
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxUstanova_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = comboBoxUstanova.SelectedItem as sifra_zdrv_ustanove;
            _ustanovaID = selectedItem.sifra_zdrv_ustanoveID;
        }

        /// <summary>
        /// event za klik gumba Dodaj Pregled poziva funkciju za instanciranje objekta pregleda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DateTime d1 = dateTimePickerDatum.Value;
            DateTime d2 = d1.Date;
            SetNewPregledObject(d2);

            this.Close();
         }

        #endregion

        #region private methods
        /// <summary>
        /// funkcija za prikaz vrijednosti umjesto vanjskih kljuceva u comobobxu
        /// </summary>
        private void SetComboBox()
        {

            var listaZdravUstanova = _zdravUstanovaBAL.GetAllUstanove();
            var listaPacijenti = _pacijentiBAL.GetAllPacijenti();


            // set ustanova
            comboBoxUstanova.DataSource = listaZdravUstanova;
            comboBoxUstanova.DisplayMember = "naziv";
            comboBoxUstanova.ValueMember = "sifra_zdrv_ustanoveID";

            //set pacijenti

            comboBoxPacijent.DataSource = listaPacijenti;
            comboBoxPacijent.DisplayMember = "ImePrezime";
            comboBoxPacijent.ValueMember = "pacijentiID";

        }

        /// <summary>
        /// instanciranje objekta s podacima iz forme i poziv funkcije
        /// </summary>
        /// <param name="d2"></param>
        private void SetNewPregledObject(DateTime d2)
        {
           int broj =  _rasporedBAL.broj();
            DateTime sati;
            DateTime.TryParse(textBoxVrijeme.Text, out sati);

            raspored pregled = new raspored()
            {
                rasporedID = broj,
                opis = textBoxOpis.Text,
                datum = d2,
                vrijeme = sati.TimeOfDay,
                pacijentiID = _pacijentiID,
                sifra_zdrv_ustanoveID = _ustanovaID

            };

            _rasporedBAL.AddNewRaspored(pregled);
        }

        #endregion

    }
}

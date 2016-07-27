using HouseMed.BAL;
using HouseMed.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseMed.Medication
{
    public partial class frmAddNewMedication : Form
    {
        #region private variables
        private ZdravUstanovaBAL _zdravUstanovaBAL;
        private LijekoviBAL _lijekoviBAL;
        private lijekovi _selectedLijek;
        private int _ustanovaId;
        #endregion

        #region constructor
        public frmAddNewMedication()
        {
            InitializeComponent();
            _zdravUstanovaBAL = new ZdravUstanovaBAL();
            _lijekoviBAL = new LijekoviBAL();
        }

        public frmAddNewMedication(lijekovi selectedLijek)
        {
            InitializeComponent();
            _zdravUstanovaBAL = new ZdravUstanovaBAL();
            _lijekoviBAL = new LijekoviBAL();
            _selectedLijek = selectedLijek;
        }
        #endregion

        #region form methods
        /// <summary>
        /// Form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddNewMedication_Load(object sender, EventArgs e)
        {
            if (_selectedLijek != null)
            {
                LoadComboBox();
                LoadTextBox();
                this.ActiveControl = txtNaziv;
            }
            else
            {
                LoadComboBox();
                this.ActiveControl = txtNaziv;
            }
        }
        /// <summary>
        /// Form KeyDownEvent: Open the help for the app on the website
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddNewMedication_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r16049/wiki/7.-Pomo%C4%87-korisnicima");
            }
        }
        #endregion

        #region event handlers
        /*/// <summary> <------- Umjesto ovoga dodan ucNatrag (Karlo)
        /// Button[Odustani] event handler: closing this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/
        /// <summary>
        /// ComboBox[Ustanove] event handler: take "ustanovaID" when selection is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboUstanova_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = comboUstanova.SelectedItem as sifra_zdrv_ustanove;
            _ustanovaId = selectedItem.sifra_zdrv_ustanoveID;
        }
        /// <summary>
        /// Button[U redu] event handler: instance new object to add in the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_selectedLijek != null)
            {
                if (UpdateExistingLijekoviObject())
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Provjerite da li su vam svi unosi u redu!", "Upozorenje!");
                }
            }
            else
            {
                if(SetNewLijekoviObject())
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Provjerite da li su vam svi unosi u redu!", "Upozorenje!");
                }
            }
        }
        #endregion

        #region private methods
        /// <summary>
        /// Setting the combobox Djelatnici and Ustanova with values
        /// </summary>
        private void LoadComboBox()
        {
            var listaZdravUstanova = _zdravUstanovaBAL.GetAllUstanove();

            // set ustanove
            comboUstanova.DataSource = listaZdravUstanova;
            comboUstanova.DisplayMember = "naziv";
            comboUstanova.ValueMember = "sifra_zdrv_ustanoveID";

        }
        /// <summary>
        /// Instancing a new "lijekovi" object
        /// </summary>
        private bool SetNewLijekoviObject()
        {
            lijekovi lijekovi = new lijekovi()
            {
                sifra_zdrv_ustanoveID = _ustanovaId,
                naziv = txtNaziv.Text,
                datum_vrijeme_kontrole = HelpClass.GetValueOrNull<DateTime>(dtpDatumKontrole.Text),
                rok_trajanja = HelpClass.GetValueOrNull<DateTime>(dtpRokTrajanja.Text),
                kolicina = HelpClass.GetValueOrNull<int>(txtKolicina.Text),
                cijena = HelpClass.GetValueOrNull<decimal>(txtCijena.Text)
            };
            if(lijekovi.kolicina != null && lijekovi.cijena != null)
            {
                _lijekoviBAL.AddNewLijekoviObject(lijekovi);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Set the textbox values with the selected object
        /// </summary>
        private void LoadTextBox()
        {
            txtCijena.Text = _selectedLijek.cijena.ToString();
            txtId.Text = _selectedLijek.lijekoviID.ToString();
            txtKolicina.Text = _selectedLijek.kolicina.ToString();
            txtNaziv.Text = _selectedLijek.naziv;
        }
        /// <summary>
        /// Updating the existing "lijekovi" object in the DB
        /// </summary>
        private bool UpdateExistingLijekoviObject()
        {
            _selectedLijek.cijena = HelpClass.GetValueOrNull<decimal>(txtCijena.Text);
            _selectedLijek.datum_vrijeme_kontrole = dtpDatumKontrole.Value.Date;
            _selectedLijek.kolicina = HelpClass.GetValueOrNull<int>(txtKolicina.Text);
            _selectedLijek.naziv = txtNaziv.Text;
            _selectedLijek.rok_trajanja = dtpRokTrajanja.Value.Date;
            _selectedLijek.sifra_zdrv_ustanoveID = _ustanovaId;

            if( _selectedLijek.cijena != null && _selectedLijek.kolicina != null)
            {
                _lijekoviBAL.SaveChanges();
                return true;
            }

            return false;
        }
        #endregion

        
    }
}

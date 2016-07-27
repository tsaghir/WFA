using HouseMed.BAL;
using HouseMed.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace HouseMed.Recipes
{
    public partial class frmAddNewRecipe : Form
    {
        public static class ObjectProps
        {
            public static pacijenti pacijenti { get; set; }
            public static lijekovi lijekovi { get; set; }
            public static bool IsGood { get; set; }
        }

        #region private variables
        private DjelatniciBAL _djelatniciBAL;
        private ZdravUstanovaBAL _zdravUstanovaBAL;
        private ReceptiBAL _receptiBAL;
        private receptiCustom _selectedRecept;
        private int _djelatniciID;
        private int _ustanovaID;
        #endregion

        #region constructor
        public frmAddNewRecipe()
        {
            InitializeComponent();
            _djelatniciBAL = new DjelatniciBAL();
            _zdravUstanovaBAL = new ZdravUstanovaBAL();
            _receptiBAL = new ReceptiBAL();
        }

        public frmAddNewRecipe(receptiCustom selectedRecept)
        {
            InitializeComponent();
            _djelatniciBAL = new DjelatniciBAL();
            _zdravUstanovaBAL = new ZdravUstanovaBAL();
            _receptiBAL = new ReceptiBAL();
            _selectedRecept = selectedRecept;
        }
        #endregion

        #region form methods
        /// <summary>
        /// form load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddNewRecipe_Load(object sender, EventArgs e)
        {
            if(_selectedRecept != null)
            {
                LoadComboBox();
                LoadTextBox();
            }
            else
            {
                LoadComboBox();
            }
        }
        /// <summary>
        /// Form KeyDownEvent: Open the help for the app on the website
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddNewRecipe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r16049/wiki/7.-Pomo%C4%87-korisnicima");
            }
        }
        #endregion

        #region event handlers
        /// <summary>
        /// Button[OK] event handler: Insert new recipe in DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_selectedRecept != null)
            {
                if(UpdateExistingObject())
                {
                    this.Close();
                }
            }
            else
            {
                if (SetNewRecipeObject())
                {
                    this.Close();
                }
            }
        }
        /// <summary>
        /// Button[Odustani] event handler: Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Button[Odaberi] "Lijekovi" event handler: Open new form to select the medication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChooseMedicine_Click(object sender, EventArgs e)
        {
            frmMedicationSelect frm = new frmMedicationSelect();
            frm.recipeSelection = true;
            frm.ShowDialog();
            if(ObjectProps.lijekovi != null)
            {
                txtLijekovi.Text = ObjectProps.lijekovi.naziv;
            }
            
        }
        /// <summary>
        /// Button[Odaberi] "Pacijent" event handler: Open new form to select the patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoosePatient_Click(object sender, EventArgs e)
        {
            E_Carton.frmECarton frm = new E_Carton.frmECarton();
            frm.recipeSelection = true;
            frm.ShowDialog();
            if(ObjectProps.pacijenti != null)
            {
                txtPacijent.Text = ObjectProps.pacijenti.ImePrezime;
            }
        }
        /// <summary>
        /// ComboBox[Djelatnici] event handler: take djelatnici ID when the selection is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboDjelatnici_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = comboDjelatnici.SelectedItem as djelatnici;
            _djelatniciID = selectedItem.djelatniciID;
        }
        /// <summary>
        /// ComboBox[Ustanove] event handler: take ustanova ID when selection is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboUstanova_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = comboUstanova.SelectedItem as sifra_zdrv_ustanove;
            _ustanovaID = selectedItem.sifra_zdrv_ustanoveID;
        }
        #endregion

        #region private methods
        /// <summary>
        /// Setting the combobox Djelatnici and Ustanova with values
        /// </summary>
        private void LoadComboBox()
        {
            var listaDjelatnici = _djelatniciBAL.GetAllDjelatnici();
            var listaZdravUstanova = _zdravUstanovaBAL.GetAllUstanove();

            // set djelatnici
            comboDjelatnici.DataSource = listaDjelatnici;
            comboDjelatnici.DisplayMember = "ImePrezime";
            comboDjelatnici.ValueMember = "djelatniciID";

            // set ustanove
            comboUstanova.DataSource = listaZdravUstanova;
            comboUstanova.DisplayMember = "naziv";
            comboUstanova.ValueMember = "sifra_zdrv_ustanoveID";

        }
        /// <summary>
        /// If there is a selected recipe load in the data from the object into textboxes
        /// </summary>
        private void LoadTextBox()
        {
            txtDoziranje.Text = _selectedRecept.Doziranje;
            txtKolicina.Text = _selectedRecept.Kolicina.ToString();
            txtLijekovi.Text = _selectedRecept.LijekoviIDName;
            txtPacijent.Text = _selectedRecept.PacijentiIDName;
            txtSlucaj.Text = _selectedRecept.Slucaj;
            chckNadoplata.Checked = (bool)_selectedRecept.Nadoplata;
        }
        /// <summary>
        /// Instancing a new recipe object
        /// </summary>
        private bool SetNewRecipeObject()
        {
            recepti recepti = new recepti()
            {
                kolicina = HelpClass.GetValueOrNull<int>(txtKolicina.Text),
                nadoplata = chckNadoplata.Checked,
                djelatniciID = _djelatniciID,
                sifra_zdrv_ustanoveID = _ustanovaID,
                pacijentiID = ObjectProps.pacijenti != null ? ObjectProps.pacijenti.pacijentiID : (int?)null,
                lijekoviID = ObjectProps.lijekovi != null? ObjectProps.lijekovi.lijekoviID : (int?)null,
                doziranje = txtDoziranje.Text,
                slucaj = txtSlucaj.Text
            };

            if(ObjectProps.lijekovi != null && ObjectProps.pacijenti != null)
            {
                if (recepti.kolicina != null)
                {
                    _receptiBAL.AddNewRecept(recepti);
                    return true;
                }
                else
                {
                    MessageBox.Show("Provjerite da li su vam svi unosi u redu!", "Upozorenje!");
                }
            }
            else
            {
                MessageBox.Show("Zaboravili ste odabrati pacijenta ili lijek! \n Pokušajte ponovo.", "Upozorenje!");
            }
            return false;
        }
        /// <summary>
        /// Updating the existing object in the DB
        /// </summary>
        private bool UpdateExistingObject()
        {

            _selectedRecept.Kolicina = HelpClass.GetValueOrNull<int>(txtKolicina.Text);
            _selectedRecept.Nadoplata = chckNadoplata.Checked;
            _selectedRecept.DjelatniciID = _djelatniciID;
            _selectedRecept.UstanovaID = _ustanovaID;
            _selectedRecept.PacijentID = ObjectProps.pacijenti != null ? ObjectProps.pacijenti.pacijentiID : _selectedRecept.PacijentID;
            _selectedRecept.LijekoviID = ObjectProps.lijekovi != null ? ObjectProps.lijekovi.lijekoviID : _selectedRecept.LijekoviID;
            _selectedRecept.Doziranje = txtDoziranje.Text;
            _selectedRecept.Slucaj = txtSlucaj.Text;

            if(_selectedRecept.Kolicina != null)
            {
                var editRecept = _receptiBAL.GetReceptObjectById(_selectedRecept.ReceptID);
                editRecept.kolicina = _selectedRecept.Kolicina;
                editRecept.nadoplata = _selectedRecept.Nadoplata;
                editRecept.djelatniciID = _selectedRecept.DjelatniciID;
                editRecept.sifra_zdrv_ustanoveID = _selectedRecept.UstanovaID;
                editRecept.pacijentiID = _selectedRecept.PacijentID;
                editRecept.lijekoviID = _selectedRecept.LijekoviID;
                editRecept.doziranje = _selectedRecept.Doziranje;
                editRecept.slucaj = _selectedRecept.Slucaj;
                _receptiBAL.SaveChanges();
                return true;
            }
            return false;
        }
        #endregion
    }
}

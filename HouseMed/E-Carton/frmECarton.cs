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
using HouseMed.Recipes;

namespace HouseMed.E_Carton
{
    public partial class frmECarton : Form
    {
        #region public variables
        public bool recipeSelection = false;
        #endregion

        #region private variables
        private PacijentiBAL _pacijentiBAL;
        private ReceptiBAL _receptiBAL;
        private UputnicaBAL _uputnicaBAL;
        private CijepljenjeBAL _cijepljenjeBAL;
        private PostupciBAL _postupciBAL;
        private HospitalizacijaBAL _hospitalizacijaBAL;
        private RasporedBAL _rasporedBAL;
        #endregion

        #region constructor
        public frmECarton()
        {
            InitializeComponent();
            _pacijentiBAL = new PacijentiBAL();
            _receptiBAL = new ReceptiBAL();
            _uputnicaBAL = new UputnicaBAL();
            _cijepljenjeBAL = new CijepljenjeBAL();
            _postupciBAL = new PostupciBAL();
            _hospitalizacijaBAL = new HospitalizacijaBAL();
            _rasporedBAL = new RasporedBAL();
        }
        #endregion

        #region form methods
        /// <summary>
        /// Event for loading the data in the datagrids
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmECarton_Load(object sender, EventArgs e)
        {
            if (!recipeSelection)
            {
                odaberiPacijentaToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.None;
            }
            dgvPatients.DataSource = _pacijentiBAL.GetAllPacijenti();
            comboPrikaz.ComboBox.DataSource = Enum.GetValues(typeof(HelpClass.Ecarton));
            GetSelectedPatient();
            dgvPatients.Select();
        }
        /// <summary>
        /// Form KeyDownEvent: Open the help for the app on the website
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmECarton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r16049/wiki/7.-Pomo%C4%87-korisnicima");
            }
        }
        #endregion

        #region event handlers
        /// <summary>
        /// MenuStrip[Natrag] event: Closes the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void natragToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// MenuStrip[Odaberi pacijenta] event: pass the chosen object to the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void odaberiPacijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = dgvPatients.CurrentRow.DataBoundItem as pacijenti;
            if (selectedItem != null)
            {
                frmAddNewRecipe.ObjectProps.pacijenti = selectedItem;
            }
            this.Close();
        }
        /// <summary>
        /// MenuStrip[ComboBox] event: getting the selected patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboPrikaz_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSelectedPatient();
            dgvPatients.Select();
        }
        /// <summary>
        /// DataGrid[Pacijent] event handler: get the selected patient and execute query
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPatients_SelectionChanged(object sender, EventArgs e)
        {
            GetSelectedPatient();
        }
        /// <summary>
        /// MenuStrip[TextBox] event handler: filter the patients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvPatients.DataSource = _pacijentiBAL.GetAllPacijentiBy(txtSearch.Text);
        }
        #endregion

        #region private methods
        /// <summary>
        /// Method for getting the selected patient in Patient data grid
        /// </summary>
        private void GetSelectedPatient()
        {
            var selectedItem = dgvPatients.CurrentRow.DataBoundItem as pacijenti;
            if(selectedItem != null && comboPrikaz.ComboBox.DataSource != null)
            {
                switch ((HelpClass.Ecarton)comboPrikaz.ComboBox.SelectedValue)
                {
                    case HelpClass.Ecarton.Uputnica:
                        lblPreview.Text = "Uputnica";
                        dgvPreview.DataSource = _uputnicaBAL.GetAllUputnicaPropsNameById(selectedItem.pacijentiID);
                        dgvPreview.Columns[0].HeaderCell.Value = "Br. Uputnice";
                        dgvPreview.Columns[3].HeaderCell.Value = "Upućuje se";
                        dgvPreview.Columns[5].HeaderCell.Value = "Traži se";
                        break;
                    case HelpClass.Ecarton.Recept:
                        lblPreview.Text = "Recept";
                        dgvPreview.DataSource = _receptiBAL.GetAllReceptiNamedPropsById(selectedItem.pacijentiID);
                        dgvPreview.Columns[0].HeaderCell.Value = "Br. Recepta";
                        dgvPreview.Columns[1].HeaderCell.Value = "Slučaj";
                        dgvPreview.Columns[2].HeaderCell.Value = "Količina";
                        dgvPreview.Columns[5].HeaderCell.Value = "Lijek";
                        dgvPreview.Columns[6].HeaderCell.Value = "Pacijent";
                        dgvPreview.Columns[7].HeaderCell.Value = "Djelatnik";
                        dgvPreview.Columns[8].HeaderCell.Value = "Ustanova";
                        break;
                    case HelpClass.Ecarton.Cijepljenje:
                        lblPreview.Text = "Cijepljenje";
                        dgvPreview.DataSource = _cijepljenjeBAL.GetAllCijepPropNamesById(selectedItem.pacijentiID);
                        dgvPreview.Columns[0].HeaderCell.Value = "Br. Cijepljenja";
                        dgvPreview.Columns[1].HeaderCell.Value = "Slučaj";
                        dgvPreview.Columns[3].HeaderCell.Value = "Vrsta cijepljenja";
                        dgvPreview.Columns[4].HeaderCell.Value = "Priprava cjepiva";
                        dgvPreview.Columns[5].HeaderCell.Value = "Broj doze";
                        dgvPreview.Columns[6].HeaderCell.Value = "Količina";
                        break;
                    case HelpClass.Ecarton.Hospitalizacija:
                        lblPreview.Text = "Hospitalizacija";
                        dgvPreview.DataSource = _hospitalizacijaBAL.GetAllHospitalizacijaPropNamesById(selectedItem.pacijentiID);
                        dgvPreview.Columns[0].HeaderCell.Value = "Br. Hospitalizacije";
                        dgvPreview.Columns[1].HeaderCell.Value = "Boravio od datuma";
                        dgvPreview.Columns[2].HeaderCell.Value = "Boravio do datuma";
                        dgvPreview.Columns[3].HeaderCell.Value = "Naziv bolnice";
                        break;
                    case HelpClass.Ecarton.Postupci:
                        lblPreview.Text = "Postupci";
                        dgvPreview.DataSource = _postupciBAL.GetAllPostupciPropNamesById(selectedItem.pacijentiID);
                        dgvPreview.Columns[0].HeaderCell.Value = "Br. Postupaka";
                        break;
                    case HelpClass.Ecarton.Raspored:
                        lblPreview.Text = "Raspored";
                        dgvPreview.DataSource = _rasporedBAL.GetAllRasporedPropNamesById(selectedItem.pacijentiID);
                        dgvPreview.Columns[0].HeaderCell.Value = "Br. Raporeda";
                        break;
                    default:
                        break;

                }
            }
        }
        #endregion

        
    }
}

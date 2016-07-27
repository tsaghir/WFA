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

namespace HouseMed.Recipes
{
    public partial class frmMedicationSelect : Form
    {
        #region public variables
        public bool recipeSelection = false;
        #endregion

        #region private variables
        private LijekoviBAL _lijekoviBAL;
        #endregion

        #region constructor
        public frmMedicationSelect()
        {
            InitializeComponent();
            _lijekoviBAL = new LijekoviBAL();
        }
        #endregion

        #region form methods
        /// <summary>
        /// Event handler for form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMedicationSelect_Load(object sender, EventArgs e)
        {
            if (!recipeSelection)
            {
                odaberiLijekToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.None;
            }
            RefreshDatagrid();
        }
        /// <summary>
        /// Form KeyDownEvent: Open the help for the app on the website
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMedicationSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r16049/wiki/7.-Pomo%C4%87-korisnicima");
            }
        }
        #endregion

        #region event handlers
        /// <summary>
        /// MenuStripEvent[Natrag]: Close the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void natragToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// MenuStripEvent[Dodaj novi lijek]: Opens the new form for adding a new "lijekovi" object into the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dodajNoviLijekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HouseMed.Medication.frmAddNewMedication frm = new Medication.frmAddNewMedication();
            frm.ShowDialog();
            RefreshDatagrid();
        }
        /// <summary>
        /// MenuStripEvent[Odaberi lijek]: Closes the form and passes the selected object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void odaberiLijekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = dgvMedication.CurrentRow.DataBoundItem as lijekovi;
            if (selectedItem != null)
            {
                frmAddNewRecipe.ObjectProps.lijekovi = selectedItem;
            }
            this.Close();
        }
        /// <summary>
        ///  Search event handler for filtering the medication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvMedication.DataSource = _lijekoviBAL.GetLijekoviByName(txtSearch.Text);
        }
        /// <summary>
        /// MenuStrip[Uredi odabrani lijek] event: opens the form "frmAddNewMedicine" with the selecet objects values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void urediOdabraniLijekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = dgvMedication.CurrentRow.DataBoundItem as lijekovi;
            Medication.frmAddNewMedication frm = new Medication.frmAddNewMedication(selectedItem);
            frm.ShowDialog();
            RefreshDatagrid();
        }
        /// <summary>
        /// MenuSelect[Obriši odabrani lijek] event: Remove the selected object from the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void obrišiOdabraniLijekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite obrisati odabrani lijek?", "Upozorenje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var selectedItem = dgvMedication.CurrentRow.DataBoundItem as lijekovi;
                if (_lijekoviBAL.DeleteLijek(selectedItem))
                {
                    RefreshDatagrid();
                    MessageBox.Show(string.Format("Lijek '{0}' je obrisan.", selectedItem.naziv), "Obavijest!");
                }
            }
        }
        #endregion

        #region private methods
        /// <summary>
        /// Refresh the datagrid with data
        /// </summary>
        private void RefreshDatagrid()
        {
            dgvMedication.DataSource = _lijekoviBAL.GetAllLijekovi();
            lijekoviBindingSource.DataSource = _lijekoviBAL.GetAllLijekovi();
        }
        #endregion
    }
}

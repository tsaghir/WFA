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
    public partial class frmRecipe : Form
    {
        #region private variables
        private ReceptiBAL _receptiBAL;
        #endregion

        #region constructor
        public frmRecipe()
        {
            InitializeComponent();
            _receptiBAL = new ReceptiBAL();
        }
        #endregion

        #region form methods
        /// <summary>
        /// FormLoad event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRecipe_Load(object sender, EventArgs e)
        {
            RefreshRecipeDatagrid();
        }
        /// <summary>
        /// Form KeyDownEvent: Open the help for the app on the website
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRecipe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r16049/wiki/7.-Pomo%C4%87-korisnicima");
            }
        }
        #endregion

        #region event handlers
        /// <summary>
        /// MenuStripEvent[Novi recept]: open the "frmAddNewRecipe" form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void noviReceptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewRecipe frm = new frmAddNewRecipe();
            frm.ShowDialog();
            RefreshRecipeDatagrid();
        }
        /// <summary>
        /// MenuStripEvent[Uredi odabrani recept]: opent form "frmAddNewRecipe" for editing the selected object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void akcijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedReceptiCustom = dgvRecipe.CurrentRow.DataBoundItem as receptiCustom;
            frmAddNewRecipe frm = new frmAddNewRecipe(selectedReceptiCustom);
            frm.ShowDialog();
            RefreshRecipeDatagrid();
        }
        /// <summary>
        /// MenuStripEvent[Obriši odabrani recept]: Delete the selected item from the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void obrišiOdabraniReceptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite obrisati","Upozorenje!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var selectedReceptCustom = dgvRecipe.CurrentRow.DataBoundItem as receptiCustom;
                if (_receptiBAL.DeleteRecept(selectedReceptCustom.ReceptID))
                {
                    RefreshRecipeDatagrid();
                    MessageBox.Show(string.Format("Recept pacijenta '{0}' je obrisan", selectedReceptCustom.PacijentiIDName), "Obavijest!");
                }
                
            }
            
        }
        /// <summary>
        /// MenuStripEvent[Natrag]: Close the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void natragToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region private methods
        /// <summary>
        /// Setting the datagrid datasource
        /// </summary>
        private void RefreshRecipeDatagrid()
        {
            dgvRecipe.DataSource = _receptiBAL.GetAllReceptiNamedProps();

            // "Recept"
            dgvRecipe.Columns[0].HeaderCell.Value = "Br. Recepta";
            dgvRecipe.Columns[1].HeaderCell.Value = "Slučaj";
            dgvRecipe.Columns[2].HeaderCell.Value = "Količina lijeka";
            dgvRecipe.Columns[5].HeaderCell.Value = "Lijek";
            dgvRecipe.Columns[6].HeaderCell.Value = "Pacijent";
            dgvRecipe.Columns[7].HeaderCell.Value = "Djelatnik";
            dgvRecipe.Columns[8].HeaderCell.Value = "Ustanova";

            dgvRecipe.Columns[6].DisplayIndex = 1;
            dgvRecipe.Columns[7].DisplayIndex = 2;
            dgvRecipe.Columns[5].DisplayIndex = 3;

            dgvRecipe.Columns[9].Visible = false;
            dgvRecipe.Columns[10].Visible = false;
            dgvRecipe.Columns[11].Visible = false;
            dgvRecipe.Columns[12].Visible = false;
        }



        #endregion
    }
}

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
using HouseMed.Raspored;
using HouseMed.Certificates;
using HouseMed.Uputnice;
using HouseMed.Recipes;

namespace HouseMed.Procedures
{
    public partial class frmProceduresControl : Form
    {
        #region private variables
        private PostupciBAL _postupciBAL;
        private DjelatniciBAL _djelatniciBAL;
        private pacijenti trenutniPacijent = frmMenu.trenutniPacijent;
        #endregion

        #region consturctor
        public frmProceduresControl()
        {
            _postupciBAL = new PostupciBAL();
            _djelatniciBAL = new DjelatniciBAL();

            InitializeComponent();
            dgvPostupciPacijenta.DataSource = _postupciBAL.GetAllPostupciPropNamesById(trenutniPacijent.pacijentiID);
        }
        #endregion

        #region event handlers
        private void btnPregled_Click(object sender, EventArgs e)
        {
            frmAddNewPregled frm = new frmAddNewPregled(trenutniPacijent); //TODO: Proslijediti i ustanovu za koju se radi raspored
            frm.ShowDialog();
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            frmAddNewCertificate frm = new frmAddNewCertificate();
            frm.ShowDialog();
        }

        private void btnUputnica_Click(object sender, EventArgs e)
        {
            frmAddNewUputnice frm = new frmAddNewUputnice();
            frm.ShowDialog();
        }

        private void btnRecept_Click(object sender, EventArgs e)
        {
            frmAddNewRecipe frm = new frmAddNewRecipe();
            frm.ShowDialog();
        }

        private void btnCijepljenje_Click(object sender, EventArgs e)
        {
            FrmAddNewCijepljenje frm = new FrmAddNewCijepljenje();
            frm.ShowDialog();
        }

        /// <summary>
        /// event koji se aktivira na tipku F1 i zove nasu wiki stranicu za pomoc korisniku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProceduresControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r16049/wiki/7.-Pomo%C4%87-korisnicima#zaprimi-pacijenta");
            }
        }
        #endregion
    }
}

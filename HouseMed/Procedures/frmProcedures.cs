using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HouseMed.DAL;
using HouseMed.BAL;
using HouseMed.Patients;

namespace HouseMed.Procedures
{
    public partial class frmProcedures : Form
    {
        #region private variables
        private PostupciBAL _postupciBAL;
        private DjelatniciBAL _djelatniciBAL;
        private pacijenti trenutniPacijent;
        #endregion

        #region constructor
        public frmProcedures()
        {
            _postupciBAL = new PostupciBAL();
            _djelatniciBAL = new DjelatniciBAL();
            InitializeComponent();
            OdabraniPacijentRefresh();
            labelDatum.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        #endregion

        #region private methods
        private void OdabraniPacijentRefresh()
        {
            trenutniPacijent = frmMenu.trenutniPacijent;
            if (trenutniPacijent != null)
            {
                labelPacijentIspis.Text = trenutniPacijent.ImePrezime;
                foreach (Control c in this.Controls)
                {
                    if ((c is Button || c is TextBox) && c.Name.ToString() != "btnOdaberi")
                        c.Enabled = true;
                }
            }
            else
            {
                labelPacijentIspis.Text = "----->";
                foreach (Control c in this.Controls)
                {
                    if ((c is Button || c is TextBox) && c.Name.ToString() != "btnOdaberi")
                        c.Enabled = false;
                }
            }
        }
        

        /// <summary>
        /// Instancira se novi postupak
        /// </summary>
        private void SetNewProcedureObject()
        {
            postupci postupak = new postupci()
            {
                pacijentiID = trenutniPacijent.pacijentiID,
                datum = HelpClass.GetValueOrNull<DateTime>(labelDatum.Text),
                ljecnikID = frmMenu.trenutniDjelatnik.djelatniciID,
                anamneza = tbAnamneza.Text,
                status = tbStatus.Text,
                dijagnoza = tbDijagnoza.Text,
                terapija = tbTerapija.Text,
                preporuka = tbPreporuka.Text
            };

            _postupciBAL.AddNewPostupak(postupak);
            this.Close();
            frmProceduresControl frm = new frmProceduresControl();
            frm.ShowDialog();
        }
        #endregion

        #region event handlers
        /// <summary>
        /// Shortctu za testiranje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProceduresControl frm = new frmProceduresControl();
            frm.ShowDialog();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            frmPatients frm = new frmPatients();
            frm.ShowDialog();
            OdabraniPacijentRefresh();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            SetNewProcedureObject();
        }

        /// <summary>
        /// event koji se aktivira na tipku F1 i zove nasu wiki stranicu za pomoc korisniku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProcedures_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r16049/wiki/7.-Pomo%C4%87-korisnicima#zaprimi-pacijenta");
            }
        }
        #endregion
    }
}

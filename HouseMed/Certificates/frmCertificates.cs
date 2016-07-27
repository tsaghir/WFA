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
using HouseMed.Patients;
using HouseMed.Certificates;

namespace HouseMed.Utilities
{
    public partial class frmCertificates : Form
    {
        #region private variables
        private pacijenti trenutniPacijent;
        private PotvrdeBAL _potvrdeBAL;
        #endregion

        #region constructor
        public frmCertificates()
        {
            InitializeComponent();
            _potvrdeBAL = new PotvrdeBAL();
            trenutniPacijent = new pacijenti();
            OdabraniPacijentRefresh();
        }
        #endregion

        #region private methods
        /// <summary>
        /// Ispisuje koji je pacijent trenutno učitan
        /// </summary>
        private void OdabraniPacijentRefresh()
        {
            trenutniPacijent = frmMenu.trenutniPacijent;
            if (trenutniPacijent != null)
            {
                labelPacijentIspis.Text = "Pacijent: " + trenutniPacijent.ImePrezime;
                DataGridRefresh();
            }
            else
            {
                labelPacijentIspis.Text = "Pacijent: --->";
            }
        }

        /// <summary>
        /// Ponovo učitava podatke u DataGridView
        /// </summary>
        private void DataGridRefresh()
        {
            if (trenutniPacijent != null)
            {
                dgvCertificates.DataSource = _potvrdeBAL.GetAllPotvrdeByID(trenutniPacijent.pacijentiID);
            }
        }

        /// <summary>
        /// Briše potvrdu koja je odabrana u DataGridView-u
        /// </summary>
        private void DeleteSelectedPotvrda()
        {
            if (trenutniPacijent != null)
            {
                var selectedItem = dgvCertificates.CurrentRow.DataBoundItem as potvrdeCustom;
                if (selectedItem != null)
                {
                    _potvrdeBAL.RemovePotvrdaByID(selectedItem.PotvrdaID);
                }
            }
        }
        #endregion

        #region event handlers
        /// <summary>
        /// Pokreće formu za odabiranje pacijenta s kojim će se raditi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            frmPatients frm = new frmPatients();
            frm.ShowDialog();
            OdabraniPacijentRefresh();
        }

        /// <summary>
        /// Pokreće formu za dodavanje nove potvrde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void novaPotvrdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trenutniPacijent != null)
            {
                frmAddNewCertificate frm = new frmAddNewCertificate();
                frm.ShowDialog();
                OdabraniPacijentRefresh();
            }
        }

        /// <summary>
        /// Otvara formu za dodavanje nove potvrde i u nju učitava podatke odabrane potvrde u DataGridView-u
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UrediPotvrduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trenutniPacijent != null)
            {
                var selectedItem = dgvCertificates.CurrentRow.DataBoundItem as potvrdeCustom;
                if (selectedItem != null)
                {
                    frmAddNewCertificate frm = new frmAddNewCertificate(selectedItem);
                    frm.ShowDialog();
                    OdabraniPacijentRefresh();
                }

            }
        }

        /// <summary>
        /// Briše odabranu potvrdu u DataGridView-u
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void izbrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedPotvrda();
            OdabraniPacijentRefresh();
        }

        /// <summary>
        /// event koji se aktivira na tipku F1 i zove nasu wiki stranicu za pomoc korisniku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCertificates_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r16049/wiki/7.-Pomo%C4%87-korisnicima#potvrde");
            }
        }
        #endregion
    }
}

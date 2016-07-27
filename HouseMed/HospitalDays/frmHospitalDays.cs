using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using HouseMed.BAL;
using HouseMed.DAL;
using HouseMed.Patients;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseMed.HospitalDays
{
    public partial class frmHospitalDays : Form
    {
        #region private variables
        private HospitalizacijaBAL _hospitalizacijaBAL;
        private pacijenti trenutniPacijent;
        #endregion

        #region constructor
        public frmHospitalDays()
        {
            InitializeComponent();
            _hospitalizacijaBAL = new HospitalizacijaBAL();
            OdabraniPacijentRefresh();
            DataGridRefresh();
        }
        #endregion

        #region private methods
        /// <summary>
        /// Osvježava naziv pacijenta s kojim se trenutno radi
        /// </summary>
        private void OdabraniPacijentRefresh()
        {
            trenutniPacijent = frmMenu.trenutniPacijent;
            if (trenutniPacijent != null)
            {
                labelPacijentIspis.Text = "Pacijent: " + trenutniPacijent.ImePrezime;
                DataGridRefresh();
                foreach (Control c in this.Controls)
                {
                    if ((c is Button || c is TextBox) && c.Name.ToString() != "btnOdaberi")
                        c.Enabled = true;
                }
            }
            else
            {
                labelPacijentIspis.Text = "Pacijent: --->";
                foreach (Control c in this.Controls)
                {
                    if ((c is Button || c is TextBox) && c.Name.ToString() != "btnOdaberi")
                        c.Enabled = false;
                }
            }
        }

        private void cbPacijenti_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvHospitalDays.DataSource = _hospitalizacijaBAL.GetAllHospitalizacijaPropNamesById(trenutniPacijent.pacijentiID);
        }

        /// <summary>
        /// Otvara formu za dodavanje novog naloga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNoviNalog_Click(object sender, EventArgs e)
        {
            if (trenutniPacijent != null)
            {
                frmAddNewHospitalDay frm = new frmAddNewHospitalDay(trenutniPacijent.pacijentiID);
                frm.ShowDialog();
                DataGridRefresh();
            }
        }

        /// <summary>
        /// dobivanje naloga po selected id-u
        /// </summary>
        private void DeleteSelectedNalog()
        {
            if (trenutniPacijent != null)
            {
                var selectedItem = dgvHospitalDays.CurrentRow.DataBoundItem as hospitalizacijaCustom;

                if (selectedItem != null)
                {
                    _hospitalizacijaBAL.RemoveNalogByID(selectedItem.HospitalizacijaId.ToString());
                }
            }
        }

        /// <summary>
        /// Na klik gumba Brisi se poziva funkcija za brisanje selektiranog naloga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrisiBoravak_Click(object sender, EventArgs e)
        {
            if (trenutniPacijent != null)
            {
                DeleteSelectedNalog();
                DataGridRefresh();
            }
        }
        
        /// <summary>
        /// Osvježava DataGridView nakon mjenjanja podataka
        /// </summary>
        private void DataGridRefresh()
        {
            if (trenutniPacijent != null)
            {
                dgvHospitalDays.DataSource = _hospitalizacijaBAL.GetAllHospitalizacijaPropNamesById(trenutniPacijent.pacijentiID);
            }
        }

        /// <summary>
        /// Otvara se frmAddNewHospitalDay te se popunjava selektiranim nalogom iz DataGridView-a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUrediBoravak_Click(object sender, EventArgs e)
        {
            if (trenutniPacijent != null)
            {
                var selectedItem = dgvHospitalDays.CurrentRow.DataBoundItem as hospitalizacijaCustom;
                frmAddNewHospitalDay frm = new frmAddNewHospitalDay(selectedItem, trenutniPacijent.pacijentiID);
                frm.ShowDialog();
                DataGridRefresh();
            }
        }

        /// <summary>
        /// Upisivanjem teksta se pretrazuje DataGridView po svim stupcima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPretrazi_TextChanged(object sender, EventArgs e)
        {
            if (trenutniPacijent != null)
            {
                dgvHospitalDays.DataSource = _hospitalizacijaBAL.SearchHospitalizacija(tbPretrazi.Text, trenutniPacijent.pacijentiID);
            }
        }

        /// <summary>
        /// Odabire se pacijent s kojim se radi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            frmPatients frm = new frmPatients();
            frm.ShowDialog();
            OdabraniPacijentRefresh();

        }
        #endregion

        #region event handlers
        /// <summary>
        /// event koji se aktivira na tipku F1 i zove nasu wiki stranicu za pomoc korisniku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHospitalDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r16049/wiki/7.-Pomo%C4%87-korisnicima#boravci-u-bolnici");
            }
        }
        #endregion
    }
}

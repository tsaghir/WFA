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
using HouseMed.Patients;

namespace HouseMed.Patients
{
    public partial class frmPatients : Form
    {
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
        public frmPatients()
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

        #region event handlers

        /// <summary>
        /// event za load forme puni datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPatients_Load(object sender, EventArgs e)
        {
            RefreshDatagrid();
            btnObrisi.Enabled = false;
            btnUredi.Enabled = false;
        }
        /// <summary>
        /// klikom na novi pacijent se  otvara nova form i refresh datagrida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNoviPacijent_Click(object sender, EventArgs e)
        {
            frmAddNewPatients frm = new frmAddNewPatients();
            frm.ShowDialog();
            RefreshDatagrid();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            GetSelectedPatient();
            RefreshDatagrid();
        }
        /// <summary>
        /// uredi gumb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUredi_Click(object sender, EventArgs e)
        {
            var selectedItem = dgvPatients.CurrentRow.DataBoundItem as pacijenti;
            frmAddNewPatients frm = new frmAddNewPatients(selectedItem);
            frm.ShowDialog();
            RefreshDatagrid();
        }
        /// <summary>
        /// event za pisanje u textBoxPretrazi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPretrazi_TextChanged(object sender, EventArgs e)
        {
            dgvPatients.DataSource = _pacijentiBAL.GetAllPacijentiBy(textBoxPretrazi.Text);
            pacijentiBindingSource.DataSource = _pacijentiBAL.GetAllPacijentiBy(textBoxPretrazi.Text);
        }

        /// <summary>
        /// event za klik na data grid aktivira gumbe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPatients_SelectionChanged(object sender, EventArgs e)
        {
            btnObrisi.Enabled = true;
            btnUredi.Enabled = true;
        }

        /// <summary>
        /// event za pozivanje help stranice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPatients_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r16049/wiki/7.-Pomo%C4%87-korisnicima");
            }
        }
        #endregion


        #region private methods
        /// <summary>
        /// funkcija za refresh podataka u datagridu
        /// </summary>
        private void RefreshDatagrid()
        {
            dgvPatients.DataSource = _pacijentiBAL.GetAllPacijenti();
            dgvPatients.Columns[0].HeaderCell.Value = "ID";

        }
        /// <summary>
        /// dobivanje pacijenta po selected id
        /// </summary>
        private void GetSelectedPatient()
        {
            if (MessageBox.Show("Jeste li sigurni da želite obrisati", "Upozorenje!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var selectedItem = dgvPatients.CurrentRow.DataBoundItem as pacijenti;

                if (selectedItem != null)
                {

                    _pacijentiBAL.RemovePatientById(selectedItem.pacijentiID);
                    MessageBox.Show(string.Format("Pacijent je obrisan"), "Obavijest!");


                }
            }
        }




        /// <summary>
        /// Sprema trenutno odabranog pacijenta u frmMenu.cs -> trenutni_pacijent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPostavi_Click(object sender, EventArgs e)
        {
            var selectedItem = dgvPatients.CurrentRow.DataBoundItem as pacijenti;
            if (selectedItem != null)
            {
                frmMenu.trenutniPacijent = selectedItem;
            }
            else
            {
                frmMenu.trenutniPacijent = null;
            }
            this.Close();
        }

        #endregion

    }
}

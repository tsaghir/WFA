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

namespace HouseMed.Raspored
{
    public partial class frmRaspored : Form
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
        public frmRaspored()
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
        /// na promjenu datuma se pune datagridovi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerRaspored_ValueChanged(object sender, EventArgs e)
        {
            DateTime datum1 = dateTimePickerRaspored.Value;
            DateTime datum = datum1.Date;
            dgvRaspored.DataSource = _rasporedBAL.GetAllRasporedPropNamesByDate(datum);
            dgvCijepljenje.DataSource = _cijepljenjeBAL.GetAllRasporedPropNamesByDate(datum);
            dgvRaspored.Columns[0].HeaderCell.Value = "ID";
            dgvCijepljenje.Columns[0].HeaderCell.Value = "ID";
            dgvCijepljenje.Columns[3].HeaderCell.Value = "Vrsta";
            dgvCijepljenje.Columns[4].HeaderCell.Value = "Priprava";
            dgvCijepljenje.Columns[5].HeaderCell.Value = "Doza";
        }

        /// <summary>
        /// na klik novi pregled se otvara forma AddNewPregled i nakon toga se azurira datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnNoviPregled_Click(object sender, EventArgs e)
        {
            frmAddNewPregled frm = new frmAddNewPregled();
            frm.ShowDialog();
            DateTime datum1 = dateTimePickerRaspored.Value;
            DateTime datum = datum1.Date;
            dgvRaspored.DataSource = _rasporedBAL.GetAllRasporedPropNamesByDate(datum);
            dgvRaspored.Columns[0].HeaderCell.Value = "ID";
        }
        /// <summary>
        /// na klik novi pregled se otvara forma AddNewCijepljenje i nakon toga se azurira datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnosCijepljanja_Click(object sender, EventArgs e)
        {
            FrmAddNewCijepljenje frm = new FrmAddNewCijepljenje();
            frm.ShowDialog();
            DateTime datum1 = dateTimePickerRaspored.Value;
            DateTime datum = datum1.Date;
            dgvCijepljenje.DataSource = _cijepljenjeBAL.GetAllRasporedPropNamesByDate(datum);
            dgvCijepljenje.Columns[0].HeaderCell.Value = "ID";
            dgvCijepljenje.Columns[3].HeaderCell.Value = "Vrsta";
            dgvCijepljenje.Columns[4].HeaderCell.Value = "Priprava";
            dgvCijepljenje.Columns[5].HeaderCell.Value = "Doza";
        }

        /// <summary>
        /// event za pozivanje help stranice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRaspored_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r16049/wiki/7.-Pomo%C4%87-korisnicima");
            }

        }


        #endregion


    }
}

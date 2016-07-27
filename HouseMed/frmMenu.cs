using System;
using System.Windows.Forms;
using System.Diagnostics;
using HouseMed.Recipes;
using HouseMed.HospitalDays;
using HouseMed.E_Carton;
using HouseMed.Patients;
using HouseMed.Uputnice;
using HouseMed.Raspored;
using HouseMed.Procedures;

using HouseMed.DAL;
using HouseMed.Utilities;

namespace HouseMed
{
    public partial class frmMenu : Form
    {
        /// <summary>
        /// Trenutno postavljeni pacijent putam frmPatients
        /// </summary>
        public static pacijenti trenutniPacijent = null;
        public static djelatnici trenutniDjelatnik = null;
        #region constructor
        public frmMenu(djelatnici it)
        {
            InitializeComponent();
            trenutniDjelatnik = it;
        }
        #endregion

        #region event handlers

        /// <summary>
        /// event koji se aktivira na tipku F1 i zove nasu wiki stranicu za pomoc korisniku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r16049/wiki/7.-Pomo%C4%87-korisnicima");
            }
        }

        /// <summary>
        /// Postavlja natpis koji je trenutno odabrani pacijent u sustavu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenu_Activated(object sender, EventArgs e)
        {
            if (trenutniPacijent != null)
            {
                labelOdabraniPacijent.Text = trenutniPacijent.ImePrezime;
            }
        }

        /// <summary>
        /// Button[E-Karton] event handler: opent the 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEkarton_Click(object sender, EventArgs e)
        {
            frmECarton frm = new frmECarton();
            frm.ShowDialog();
        }
        /// <summary>
        /// Buttton[Recepti] event handler: open the "frmRecipe" form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecept_Click(object sender, EventArgs e)
        {
            Recipes.frmRecipe frm = new frmRecipe();
            frm.ShowDialog();
        }
        private void button1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "helpfile.chm", HelpNavigator.TopicId, "1234");
        }

        /// <summary>
        /// Button[Lijekovi] event handler: open the "frmMedicationSelect" form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLijekovi_Click(object sender, EventArgs e)
        {
            Recipes.frmMedicationSelect frm = new frmMedicationSelect();
            frm.ShowDialog();
        }



        /// <summary>
        /// Buttton[Bolnica] event handler: open the "frmHospitalDays" form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBolnica_Click(object sender, EventArgs e)
        {
            HospitalDays.frmHospitalDays frm = new frmHospitalDays();
            frm.ShowDialog();
        }
        /// <summary>
        /// Buttton[Pacijenti] event handler: open the "frmPatients" form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPatients_Click(object sender, EventArgs e)
        {
            frmPatients frm = new frmPatients();
            frm.ShowDialog();
        }
        /// <summary>
        /// Buttton[Pacijenti] event handler: open the "frmUputnice" form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUputnice_Click(object sender, EventArgs e)
        {
            frmUputnice frm = new frmUputnice();
            frm.ShowDialog();
        }

        /// <summary>
        ///  Buttton[Kalendar] event handler: open the "frmKalendar" form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKalendar_Click(object sender, EventArgs e)
        {
            frmRaspored frm = new frmRaspored();
            frm.ShowDialog();
        }

        /// <summary>
        /// Otvara formu za zaprimanje novog pacijenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZaprimi_Click(object sender, EventArgs e)
        {
            frmProcedures frm = new frmProcedures();
            frm.ShowDialog();
        }


        /// <summary>
        /// Otvara formu za dodavanje i ispis potvrda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPotvrde_Click(object sender, EventArgs e)
        {
            frmCertificates frm = new frmCertificates();
            frm.ShowDialog();
        }

        #endregion
    }
}

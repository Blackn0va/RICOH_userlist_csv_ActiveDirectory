#region    "Importdirektiven"
using System;
using System.Windows.Forms;
#endregion

namespace Admintools
{
    public partial class frmHauptprogramm : Form
    {
        #region "Initialize "
        public frmHauptprogramm()
        {
            InitializeComponent();
        }

        #endregion

        private void cmdDruckerliste_Click(object sender, EventArgs e)
        {

            //DruckerForm öffnen
            DruckerUserliste frmDrucker = new DruckerUserliste();
             frmDrucker.Show();

            //Form ausblennden
            this.Visible = false;

        }


        private void frmHauptprogramm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

 

        private void frmHauptprogramm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;


        }
 
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock.Presentacion
{
    public partial class FrmLauncher : Form
    {
        public FrmLauncher()
        {
            InitializeComponent();
            this.Load += FrmLauncher_Load;  
        }


        private void FrmLauncher_Load(object sender, EventArgs e)
        {
            var frm = new FrmEmpleados();

            frm.FormClosed += (s, args) =>
            {
                this.Close(); 
            };

            frm.Show();     
            this.Hide();    
        }

    }
}

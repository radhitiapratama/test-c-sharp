using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signUp1
{
    public partial class dialogBox : Form
    {
        public dialogBox()
        {
            InitializeComponent();
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            string info = "" +
                "1.Beli Visual Studio 2019 Proffesional (Press Yes) \n" +
                "2.Gunakan versi trial 30 hari (Press No) \n" +
                "3.Batalkan Installasi (Press Cancel)";

            lblResult.Text = "";

            DialogResult v_dialogResult = MessageBox.Show(info,
                "Pilih Jenis Installasi",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information);

            if(v_dialogResult == DialogResult.Yes)
            {
                lblResult.Text = "Anda membeli Visual Studio 2019 Proffesional !";
            }

            if(v_dialogResult == DialogResult.No)
            {
                lblResult.Text = "Anda menggunakan Visual Studio Trial";
            }

            if(v_dialogResult == DialogResult.Cancel)
            {
                lblResult.Text = "Installasi dibatalkan";
            }
        }
    }
}

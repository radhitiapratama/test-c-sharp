using System;
using System.Windows.Forms;

namespace signUp1
{
    public partial class signUp : Form
    {
        public static String nama;
        public static String umur;
        public static String email;
        public static Boolean sms = false;
        public static Boolean telfon = false;
        public static Boolean chatBot = false;

        Form1 form1 = new Form1();

        public signUp()
        {
            InitializeComponent();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
         
            nama = txtNama.Text;
            umur  =  txtUmur.Text;
            email = txtEmail.Text;

            if(nama == "" || umur == "" ||email == "")
            {
                MessageBox.Show("Semua input wajib di isi !");
                return;
            }
            
            this.Hide();
            form1.Show();
        }

        private void chkSms_CheckedChanged(object sender, EventArgs e)
        {
            lblSms.Text = ".....";
            if (chkSms.Checked)
            {
                sms = true;
                lblSms.Text = "Use SMS Sevice";
            }
        }

        private void chkTelfon_CheckedChanged(object sender, EventArgs e)
        {
            lblTelfon.Text = ".....";
            if (chkTelfon.Checked)
            {
                telfon = true;
                lblTelfon.Text = "Use Telfon Service";
            }

        }

        private void chkChatBot_CheckedChanged(object sender, EventArgs e)
        {
            lblChatBot.Text = ".....";
            if (chkChatBot.Checked)
            {
                chatBot = true;
                lblChatBot.Text = "Use Chat Bot Service";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtUmur.Text = "";
            txtEmail.Text = "";
            chkChatBot.Checked = false;
            chkSms.Checked = false;
            chkTelfon.Checked = false;
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNama.Text = signUp.nama;
            lblUmur.Text = signUp.umur;
            lblEmail.Text = signUp.email;

            if (signUp.sms)
            {
                lblSms.Text = "✓";
            }

            if (signUp.telfon)
            {
                lblTelfon.Text = "✓";
            }

            if (signUp.chatBot)
            {
                lblChatBot.Text = "✓";
            }
        }
    }
}

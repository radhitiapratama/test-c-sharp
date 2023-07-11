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
    public partial class datePicker : Form
    {
        public datePicker()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblDate1.Text = datepicker1.Value.ToString();
            lblDate2.Text = datepicker1.Value.ToShortTimeString();
            lblDate3.Text = datepicker1.Value.ToShortDateString();
            lblDate4.Text = datepicker1.Value.ToLongTimeString();
        }
    }
}

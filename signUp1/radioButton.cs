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
    public partial class radioButton : Form
    {
        public radioButton()
        {
            InitializeComponent();
        }

        private void btmSubmit_Click(object sender, EventArgs e)
        {
            string gender;

            if(!radioBtnFemale.Checked && !radioBtnMale.Checked)
            {
                MessageBox.Show("Please select your gender !");
                return;
            }

            if (radioBtnFemale.Checked)
            {
                gender = radioBtnFemale.Text;
                MessageBox.Show(gender);
            }

            if (radioBtnMale.Checked)
            {
                gender = radioBtnMale.Text;
                MessageBox.Show(gender);
            }
        }
    }
}

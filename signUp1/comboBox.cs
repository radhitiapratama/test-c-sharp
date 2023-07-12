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
    public partial class comboBox : Form
    {
        DataTable dtClinic = new DataTable();
        public comboBox()
        {
            InitializeComponent();
        }

        private void comboBox_Load(object sender, EventArgs e)
        {
            displayData();

            comboBox1.DataSource = dtClinic;
            //Isi dengan salah satu column di datatable 
            //di sini contohnya saya isi dengan column Clinic Name
            comboBox1.DisplayMember = "Clinic Name";
        }

        private void displayData()
        {
            //Default typeof adalah String
            dtClinic.Columns.Add("ID",typeof(int));
            dtClinic.Columns.Add("Clinic Name");
            dtClinic.Columns.Add("Clinic Address");
            dtClinic.Columns.Add("Clinic Rate");

            dtClinic.Rows.Add(1,"Clinic-1","Jln Clinic-1","9/10");
            dtClinic.Rows.Add(2, "Clinic-2", "Jln Clinic-2", "8/10");
            dtClinic.Rows.Add(3, "Clinic-3", "Jln Clinic-3", "7/10");
            dtClinic.Rows.Add(4, "Clinic-4", "Jln Clinic-4", "10/10");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblClinicName.Text = dtClinic.Rows[comboBox1.SelectedIndex]["Clinic Name"].ToString();
            lblClinicAddress.Text = dtClinic.Rows[comboBox1.SelectedIndex]["Clinic Address"].ToString();
            lblClinicRate.Text = dtClinic.Rows[comboBox1.SelectedIndex]["Clinic Rate"].ToString();
        }
    }
}

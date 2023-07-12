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
    public partial class gridView : Form
    {

        DataTable dtCourse = new DataTable();
        DataTable dtSelectedCourse = new DataTable();
        DataTable dtFinalizeCourse = new DataTable();

        public gridView()
        {
            InitializeComponent();
        }

        private void gridView_Load(object sender, EventArgs e)
        {
            displayCourse();
            displaySelectedCourse();
            displayFinalize();
            listBox1.DataSource = dtCourse;
            listBox1.DisplayMember = "Course Name";

            listBox2.DataSource = dtSelectedCourse;
            listBox2.DisplayMember = "Course Name";
        }

        private void displayCourse()
        {
            dtCourse.Columns.Add("ID",typeof(int));
            dtCourse.Columns.Add("Course Name");
            dtCourse.Columns.Add("Course Duration");

            dtCourse.Rows.Add(1,"Html","60 Minutes");
            dtCourse.Rows.Add(2, "CSS", "60 Minutes");
            dtCourse.Rows.Add(3, "JavaScript", "60 Minutes");
            dtCourse.Rows.Add(4, "PHP", "60 Minutes");
            dtCourse.Rows.Add(5, "C#", "60 Minutes");
            dtCourse.Rows.Add(6, "Kotlin", "60 Minutes");
            dtCourse.Rows.Add(7, "Java", "60 Minutes");
        }

        private void displaySelectedCourse()
        {
            dtSelectedCourse.Columns.Add("ID", typeof(int));
            dtSelectedCourse.Columns.Add("Course Name");
            dtSelectedCourse.Columns.Add("Course Duration");
        }

        private void displayFinalize()
        {
            dtFinalizeCourse.Columns.Add("ID", typeof(int));
            dtFinalizeCourse.Columns.Add("Course Name");
            dtFinalizeCourse.Columns.Add("Course Duration");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                return;
            }

            if (listBox1.Items.Count > 0)
            {
                dtSelectedCourse.ImportRow(dtCourse.Rows[listBox1.SelectedIndex]);
                dtCourse.Rows[listBox1.SelectedIndex].Delete();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                return;
            }

            if (listBox2.Items.Count > 0)
            {
                dtCourse.ImportRow(dtSelectedCourse.Rows[listBox2.SelectedIndex]);
                dtSelectedCourse.Rows[listBox2.SelectedIndex].Delete();
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                return;
            }

            if (listBox1.Items.Count > 0)
            {
                int count = listBox1.Items.Count;

                for(int i = 0; i < count; i++)
                {
                    dtSelectedCourse.ImportRow(dtCourse.Rows[listBox1.SelectedIndex]);
                    dtCourse.Rows[listBox1.SelectedIndex].Delete();
                }
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                return;
            }

            if(listBox2.Items.Count > 0)
            {
                int count = listBox2.Items.Count;
                for(int i = 0; i < count ; i++)
                {
                    dtCourse.ImportRow(dtSelectedCourse.Rows[listBox2.SelectedIndex]);
                    dtSelectedCourse.Rows[listBox2.SelectedIndex].Delete();
                }
            }
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                return;
            }

            if (listBox2.Items.Count < 0)
            {
                MessageBox.Show("Please selecet at least one course !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure to take all this course ?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {
                dataGridView1.DataSource = dtSelectedCourse;
                dataGridView1.ReadOnly = true;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 386;
                dataGridView1.Columns[2].Width = 386;
            }
        }
    }
}

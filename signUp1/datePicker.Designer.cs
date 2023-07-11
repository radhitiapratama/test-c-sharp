
namespace signUp1
{
    partial class datePicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datepicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.lblDate3 = new System.Windows.Forms.Label();
            this.lblDate4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datepicker1
            // 
            this.datepicker1.Location = new System.Drawing.Point(588, 12);
            this.datepicker1.Name = "datepicker1";
            this.datepicker1.Size = new System.Drawing.Size(200, 20);
            this.datepicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "date 4";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(203, 325);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(385, 50);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblDate1
            // 
            this.lblDate1.AutoSize = true;
            this.lblDate1.Location = new System.Drawing.Point(377, 66);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(35, 13);
            this.lblDate1.TabIndex = 6;
            this.lblDate1.Text = "label5";
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Location = new System.Drawing.Point(377, 124);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(35, 13);
            this.lblDate2.TabIndex = 7;
            this.lblDate2.Text = "label6";
            // 
            // lblDate3
            // 
            this.lblDate3.AutoSize = true;
            this.lblDate3.Location = new System.Drawing.Point(377, 183);
            this.lblDate3.Name = "lblDate3";
            this.lblDate3.Size = new System.Drawing.Size(35, 13);
            this.lblDate3.TabIndex = 8;
            this.lblDate3.Text = "label7";
            // 
            // lblDate4
            // 
            this.lblDate4.AutoSize = true;
            this.lblDate4.Location = new System.Drawing.Point(377, 245);
            this.lblDate4.Name = "lblDate4";
            this.lblDate4.Size = new System.Drawing.Size(35, 13);
            this.lblDate4.TabIndex = 9;
            this.lblDate4.Text = "label8";
            // 
            // datePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDate4);
            this.Controls.Add(this.lblDate3);
            this.Controls.Add(this.lblDate2);
            this.Controls.Add(this.lblDate1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datepicker1);
            this.Name = "datePicker";
            this.Text = "datePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datepicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblDate1;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Label lblDate3;
        private System.Windows.Forms.Label lblDate4;
    }
}
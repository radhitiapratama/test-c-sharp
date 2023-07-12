
namespace signUp1
{
    partial class comboBox
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClinicName = new System.Windows.Forms.Label();
            this.lblClinicAddress = new System.Windows.Forms.Label();
            this.lblClinicRate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Clinic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clinic Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Clinic Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Clinic Rate";
            // 
            // lblClinicName
            // 
            this.lblClinicName.AutoSize = true;
            this.lblClinicName.Location = new System.Drawing.Point(174, 89);
            this.lblClinicName.Name = "lblClinicName";
            this.lblClinicName.Size = new System.Drawing.Size(35, 13);
            this.lblClinicName.TabIndex = 5;
            this.lblClinicName.Text = "label5";
            // 
            // lblClinicAddress
            // 
            this.lblClinicAddress.AutoSize = true;
            this.lblClinicAddress.Location = new System.Drawing.Point(174, 138);
            this.lblClinicAddress.Name = "lblClinicAddress";
            this.lblClinicAddress.Size = new System.Drawing.Size(35, 13);
            this.lblClinicAddress.TabIndex = 6;
            this.lblClinicAddress.Text = "label6";
            // 
            // lblClinicRate
            // 
            this.lblClinicRate.AutoSize = true;
            this.lblClinicRate.Location = new System.Drawing.Point(174, 181);
            this.lblClinicRate.Name = "lblClinicRate";
            this.lblClinicRate.Size = new System.Drawing.Size(35, 13);
            this.lblClinicRate.TabIndex = 7;
            this.lblClinicRate.Text = "label7";
            // 
            // comboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblClinicRate);
            this.Controls.Add(this.lblClinicAddress);
            this.Controls.Add(this.lblClinicName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "comboBox";
            this.Text = "comboBOx";
            this.Load += new System.EventHandler(this.comboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClinicName;
        private System.Windows.Forms.Label lblClinicAddress;
        private System.Windows.Forms.Label lblClinicRate;
    }
}
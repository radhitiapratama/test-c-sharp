
namespace signUp1
{
    partial class signUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUmur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblChatBot = new System.Windows.Forms.Label();
            this.lblTelfon = new System.Windows.Forms.Label();
            this.lblSms = new System.Windows.Forms.Label();
            this.chkTelfon = new System.Windows.Forms.CheckBox();
            this.chkChatBot = new System.Windows.Forms.CheckBox();
            this.chkSms = new System.Windows.Forms.CheckBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(195, 68);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(339, 20);
            this.txtNama.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(195, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(339, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // txtUmur
            // 
            this.txtUmur.Location = new System.Drawing.Point(195, 105);
            this.txtUmur.Name = "txtUmur";
            this.txtUmur.Size = new System.Drawing.Size(339, 20);
            this.txtUmur.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Umur";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblChatBot);
            this.groupBox1.Controls.Add(this.lblTelfon);
            this.groupBox1.Controls.Add(this.lblSms);
            this.groupBox1.Controls.Add(this.chkTelfon);
            this.groupBox1.Controls.Add(this.chkChatBot);
            this.groupBox1.Controls.Add(this.chkSms);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(141, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 145);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service";
            // 
            // lblChatBot
            // 
            this.lblChatBot.AutoSize = true;
            this.lblChatBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChatBot.Location = new System.Drawing.Point(175, 115);
            this.lblChatBot.Name = "lblChatBot";
            this.lblChatBot.Size = new System.Drawing.Size(28, 13);
            this.lblChatBot.TabIndex = 5;
            this.lblChatBot.Text = ".......";
            // 
            // lblTelfon
            // 
            this.lblTelfon.AutoSize = true;
            this.lblTelfon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelfon.Location = new System.Drawing.Point(175, 84);
            this.lblTelfon.Name = "lblTelfon";
            this.lblTelfon.Size = new System.Drawing.Size(28, 13);
            this.lblTelfon.TabIndex = 4;
            this.lblTelfon.Text = ".......";
            this.lblTelfon.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblSms
            // 
            this.lblSms.AutoSize = true;
            this.lblSms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSms.Location = new System.Drawing.Point(175, 49);
            this.lblSms.Name = "lblSms";
            this.lblSms.Size = new System.Drawing.Size(28, 13);
            this.lblSms.TabIndex = 3;
            this.lblSms.Text = ".......";
            // 
            // chkTelfon
            // 
            this.chkTelfon.AutoSize = true;
            this.chkTelfon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTelfon.Location = new System.Drawing.Point(19, 75);
            this.chkTelfon.Name = "chkTelfon";
            this.chkTelfon.Size = new System.Drawing.Size(68, 22);
            this.chkTelfon.TabIndex = 5;
            this.chkTelfon.Text = "Telfon";
            this.chkTelfon.UseVisualStyleBackColor = true;
            this.chkTelfon.CheckedChanged += new System.EventHandler(this.chkTelfon_CheckedChanged);
            // 
            // chkChatBot
            // 
            this.chkChatBot.AutoSize = true;
            this.chkChatBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChatBot.Location = new System.Drawing.Point(19, 110);
            this.chkChatBot.Name = "chkChatBot";
            this.chkChatBot.Size = new System.Drawing.Size(85, 22);
            this.chkChatBot.TabIndex = 6;
            this.chkChatBot.Text = "Chat Bot";
            this.chkChatBot.UseVisualStyleBackColor = true;
            this.chkChatBot.CheckedChanged += new System.EventHandler(this.chkChatBot_CheckedChanged);
            // 
            // chkSms
            // 
            this.chkSms.AutoSize = true;
            this.chkSms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSms.Location = new System.Drawing.Point(19, 40);
            this.chkSms.Name = "chkSms";
            this.chkSms.Size = new System.Drawing.Size(60, 22);
            this.chkSms.TabIndex = 4;
            this.chkSms.Text = "SMS";
            this.chkSms.UseVisualStyleBackColor = true;
            this.chkSms.CheckedChanged += new System.EventHandler(this.chkSms_CheckedChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(141, 382);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(143, 38);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "Sing Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(319, 382);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(143, 38);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 486);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUmur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.Name = "signUp";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUmur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblChatBot;
        private System.Windows.Forms.Label lblTelfon;
        private System.Windows.Forms.Label lblSms;
        private System.Windows.Forms.CheckBox chkTelfon;
        private System.Windows.Forms.CheckBox chkChatBot;
        private System.Windows.Forms.CheckBox chkSms;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnReset;
    }
}


namespace Monitorizare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnLogin = new System.Windows.Forms.Panel();
            this.lbkForget = new System.Windows.Forms.LinkLabel();
            this.btConect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btGuest = new System.Windows.Forms.Button();
            this.cbPassword = new System.Windows.Forms.CheckBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.pnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLogin.Controls.Add(this.lbkForget);
            this.pnLogin.Controls.Add(this.btConect);
            this.pnLogin.Controls.Add(this.button1);
            this.pnLogin.Controls.Add(this.btGuest);
            this.pnLogin.Controls.Add(this.cbPassword);
            this.pnLogin.Controls.Add(this.tbPassword);
            this.pnLogin.Controls.Add(this.tbLogin);
            this.pnLogin.Controls.Add(this.lbPassword);
            this.pnLogin.Controls.Add(this.lbLogin);
            this.pnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnLogin.Location = new System.Drawing.Point(191, 101);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(400, 300);
            this.pnLogin.TabIndex = 2;
            // 
            // lbkForget
            // 
            this.lbkForget.AutoSize = true;
            this.lbkForget.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbkForget.Location = new System.Drawing.Point(43, 151);
            this.lbkForget.Name = "lbkForget";
            this.lbkForget.Size = new System.Drawing.Size(116, 20);
            this.lbkForget.TabIndex = 8;
            this.lbkForget.TabStop = true;
            this.lbkForget.Text = "Ați uitat parola?";
            this.lbkForget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbkForget_LinkClicked);
            // 
            // btConect
            // 
            this.btConect.BackColor = System.Drawing.Color.ForestGreen;
            this.btConect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btConect.FlatAppearance.BorderSize = 0;
            this.btConect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btConect.Location = new System.Drawing.Point(123, 190);
            this.btConect.Name = "btConect";
            this.btConect.Size = new System.Drawing.Size(157, 40);
            this.btConect.TabIndex = 7;
            this.btConect.Text = "Conectează-te";
            this.btConect.UseVisualStyleBackColor = false;
            this.btConect.Click += new System.EventHandler(this.btConect_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(257, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Înregistrează-te";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btGuest
            // 
            this.btGuest.BackColor = System.Drawing.Color.Gold;
            this.btGuest.FlatAppearance.BorderSize = 0;
            this.btGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btGuest.Location = new System.Drawing.Point(14, 251);
            this.btGuest.Name = "btGuest";
            this.btGuest.Size = new System.Drawing.Size(112, 40);
            this.btGuest.TabIndex = 5;
            this.btGuest.Text = "Oaspete";
            this.btGuest.UseVisualStyleBackColor = false;
            this.btGuest.Click += new System.EventHandler(this.btGuest_Click);
            // 
            // cbPassword
            // 
            this.cbPassword.AutoSize = true;
            this.cbPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPassword.Location = new System.Drawing.Point(222, 151);
            this.cbPassword.Name = "cbPassword";
            this.cbPassword.Size = new System.Drawing.Size(132, 24);
            this.cbPassword.TabIndex = 4;
            this.cbPassword.Text = "Afișează Parola";
            this.cbPassword.UseVisualStyleBackColor = true;
            this.cbPassword.CheckedChanged += new System.EventHandler(this.cbPassword_CheckedChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(160, 101);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(194, 34);
            this.tbPassword.TabIndex = 3;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(160, 39);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(194, 34);
            this.tbLogin.TabIndex = 2;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(43, 101);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(77, 28);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Parola:";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLogin.ForeColor = System.Drawing.Color.Black;
            this.lbLogin.Location = new System.Drawing.Point(43, 39);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(69, 28);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.pnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnLogin;
        private LinkLabel lbkForget;
        private Button btConect;
        private Button button1;
        private Button btGuest;
        private CheckBox cbPassword;
        private TextBox tbPassword;
        private TextBox tbLogin;
        private Label lbPassword;
        private Label lbLogin;
    }
}
namespace Monitorizare.Forms
{
    partial class RestoreForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestoreForm1));
            this.pnLogin = new System.Windows.Forms.Panel();
            this.cbConfirmPassword = new System.Windows.Forms.CheckBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.btRestore = new System.Windows.Forms.Button();
            this.cbPassword = new System.Windows.Forms.CheckBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.pnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLogin.Controls.Add(this.cbConfirmPassword);
            this.pnLogin.Controls.Add(this.tbConfirmPassword);
            this.pnLogin.Controls.Add(this.lbConfirmPassword);
            this.pnLogin.Controls.Add(this.btRestore);
            this.pnLogin.Controls.Add(this.cbPassword);
            this.pnLogin.Controls.Add(this.tbPassword);
            this.pnLogin.Controls.Add(this.lbPassword);
            this.pnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnLogin.Location = new System.Drawing.Point(191, 106);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(400, 275);
            this.pnLogin.TabIndex = 4;
            // 
            // cbConfirmPassword
            // 
            this.cbConfirmPassword.AutoSize = true;
            this.cbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbConfirmPassword.Location = new System.Drawing.Point(222, 167);
            this.cbConfirmPassword.Name = "cbConfirmPassword";
            this.cbConfirmPassword.Size = new System.Drawing.Size(132, 24);
            this.cbConfirmPassword.TabIndex = 10;
            this.cbConfirmPassword.Text = "Afișează Parola";
            this.cbConfirmPassword.UseVisualStyleBackColor = true;
            this.cbConfirmPassword.CheckedChanged += new System.EventHandler(this.cbConfirmPassword_CheckedChanged);
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(160, 127);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(194, 34);
            this.tbConfirmPassword.TabIndex = 9;
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbConfirmPassword.Location = new System.Drawing.Point(43, 113);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(99, 64);
            this.lbConfirmPassword.TabIndex = 8;
            this.lbConfirmPassword.Text = "Confirma Parola:";
            // 
            // btRestore
            // 
            this.btRestore.BackColor = System.Drawing.Color.ForestGreen;
            this.btRestore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btRestore.FlatAppearance.BorderSize = 0;
            this.btRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRestore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btRestore.Location = new System.Drawing.Point(123, 213);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(177, 40);
            this.btRestore.TabIndex = 7;
            this.btRestore.Text = "Recuperează";
            this.btRestore.UseVisualStyleBackColor = false;
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
            // 
            // cbPassword
            // 
            this.cbPassword.AutoSize = true;
            this.cbPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPassword.Location = new System.Drawing.Point(222, 84);
            this.cbPassword.Name = "cbPassword";
            this.cbPassword.Size = new System.Drawing.Size(132, 24);
            this.cbPassword.TabIndex = 4;
            this.cbPassword.Text = "Afișează Parola";
            this.cbPassword.UseVisualStyleBackColor = true;
            this.cbPassword.CheckedChanged += new System.EventHandler(this.cbPassword_CheckedChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(160, 44);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(194, 34);
            this.tbPassword.TabIndex = 3;
            // 
            // lbPassword
            // 
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(43, 35);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(77, 61);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Parola Nouă:";
            // 
            // RestoreForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.pnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RestoreForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resetare parolă";
            this.Load += new System.EventHandler(this.RestoreForm1_Load);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnLogin;
        private CheckBox cbConfirmPassword;
        private TextBox tbConfirmPassword;
        private Label lbConfirmPassword;
        private Button btRestore;
        private CheckBox cbPassword;
        private TextBox tbPassword;
        private Label lbPassword;
    }
}
namespace Monitorizare.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.pnLogin = new System.Windows.Forms.Panel();
            this.cbConfirmPassword = new System.Windows.Forms.CheckBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.btRegister = new System.Windows.Forms.Button();
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
            this.pnLogin.Controls.Add(this.cbConfirmPassword);
            this.pnLogin.Controls.Add(this.tbConfirmPassword);
            this.pnLogin.Controls.Add(this.lbConfirmPassword);
            this.pnLogin.Controls.Add(this.btRegister);
            this.pnLogin.Controls.Add(this.cbPassword);
            this.pnLogin.Controls.Add(this.tbPassword);
            this.pnLogin.Controls.Add(this.tbLogin);
            this.pnLogin.Controls.Add(this.lbPassword);
            this.pnLogin.Controls.Add(this.lbLogin);
            this.pnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnLogin.Location = new System.Drawing.Point(191, 101);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(400, 300);
            this.pnLogin.TabIndex = 3;
            // 
            // cbConfirmPassword
            // 
            this.cbConfirmPassword.AutoSize = true;
            this.cbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbConfirmPassword.Location = new System.Drawing.Point(222, 184);
            this.cbConfirmPassword.Name = "cbConfirmPassword";
            this.cbConfirmPassword.Size = new System.Drawing.Size(132, 24);
            this.cbConfirmPassword.TabIndex = 10;
            this.cbConfirmPassword.Text = "Afișează Parola";
            this.cbConfirmPassword.UseVisualStyleBackColor = true;
            this.cbConfirmPassword.CheckedChanged += new System.EventHandler(this.cbConfirmPassword_CheckedChanged);
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(160, 144);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(194, 34);
            this.tbConfirmPassword.TabIndex = 9;
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbConfirmPassword.Location = new System.Drawing.Point(43, 130);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(99, 64);
            this.lbConfirmPassword.TabIndex = 8;
            this.lbConfirmPassword.Text = "Confirma Parola:";
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.ForestGreen;
            this.btRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btRegister.FlatAppearance.BorderSize = 0;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btRegister.Location = new System.Drawing.Point(124, 241);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(177, 40);
            this.btRegister.TabIndex = 7;
            this.btRegister.Text = "Înregistrează-te";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // cbPassword
            // 
            this.cbPassword.AutoSize = true;
            this.cbPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPassword.Location = new System.Drawing.Point(222, 108);
            this.cbPassword.Name = "cbPassword";
            this.cbPassword.Size = new System.Drawing.Size(132, 24);
            this.cbPassword.TabIndex = 4;
            this.cbPassword.Text = "Afișează Parola";
            this.cbPassword.UseVisualStyleBackColor = true;
            this.cbPassword.CheckedChanged += new System.EventHandler(this.cbPassword_CheckedChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(160, 68);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(194, 34);
            this.tbPassword.TabIndex = 3;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(160, 19);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(194, 34);
            this.tbLogin.TabIndex = 2;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(43, 71);
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
            this.lbLogin.Location = new System.Drawing.Point(43, 19);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(69, 28);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.pnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Înregistrare";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnLogin;
        private Button btRegister;
        private CheckBox cbPassword;
        private TextBox tbPassword;
        private TextBox tbLogin;
        private Label lbPassword;
        private Label lbLogin;
        private CheckBox cbConfirmPassword;
        private TextBox tbConfirmPassword;
        private Label lbConfirmPassword;
    }
}
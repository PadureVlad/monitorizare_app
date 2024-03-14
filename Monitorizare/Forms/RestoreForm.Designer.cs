namespace Monitorizare.Forms
{
    partial class RestoreForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btRestore = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btRestore);
            this.panel1.Controls.Add(this.tbLogin);
            this.panel1.Controls.Add(this.lbLogin);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(170, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 250);
            this.panel1.TabIndex = 0;
            // 
            // btRestore
            // 
            this.btRestore.BackColor = System.Drawing.Color.RoyalBlue;
            this.btRestore.FlatAppearance.BorderSize = 0;
            this.btRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRestore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btRestore.ForeColor = System.Drawing.Color.White;
            this.btRestore.Location = new System.Drawing.Point(104, 170);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(141, 45);
            this.btRestore.TabIndex = 2;
            this.btRestore.Text = "Restore";
            this.btRestore.UseVisualStyleBackColor = false;
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(69, 102);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(214, 34);
            this.tbLogin.TabIndex = 1;
            // 
            // lbLogin
            // 
            this.lbLogin.Location = new System.Drawing.Point(83, 49);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(190, 37);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Introduceți login-ul:";
            // 
            // RestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(682, 403);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RestoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resetare parolă";
            this.Load += new System.EventHandler(this.RestoreForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btRestore;
        private TextBox tbLogin;
        private Label lbLogin;
    }
}
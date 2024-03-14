namespace Monitorizare.AdminForms
{
    partial class AddTimpSosireVehicol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTimpSosireVehicol));
            this.btAdauga = new System.Windows.Forms.Button();
            this.tbTimpSosire = new System.Windows.Forms.TextBox();
            this.lbTimpSosire = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAdauga
            // 
            this.btAdauga.BackColor = System.Drawing.Color.DimGray;
            this.btAdauga.FlatAppearance.BorderSize = 0;
            this.btAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdauga.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAdauga.ForeColor = System.Drawing.Color.White;
            this.btAdauga.Location = new System.Drawing.Point(370, 347);
            this.btAdauga.Name = "btAdauga";
            this.btAdauga.Size = new System.Drawing.Size(146, 43);
            this.btAdauga.TabIndex = 23;
            this.btAdauga.Text = "Adaugă";
            this.btAdauga.UseVisualStyleBackColor = false;
            this.btAdauga.Click += new System.EventHandler(this.btAdauga_Click);
            // 
            // tbTimpSosire
            // 
            this.tbTimpSosire.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbTimpSosire.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTimpSosire.ForeColor = System.Drawing.Color.White;
            this.tbTimpSosire.Location = new System.Drawing.Point(470, 261);
            this.tbTimpSosire.Name = "tbTimpSosire";
            this.tbTimpSosire.Size = new System.Drawing.Size(232, 36);
            this.tbTimpSosire.TabIndex = 22;
            // 
            // lbTimpSosire
            // 
            this.lbTimpSosire.BackColor = System.Drawing.Color.Transparent;
            this.lbTimpSosire.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTimpSosire.ForeColor = System.Drawing.Color.White;
            this.lbTimpSosire.Location = new System.Drawing.Point(98, 261);
            this.lbTimpSosire.Name = "lbTimpSosire";
            this.lbTimpSosire.Size = new System.Drawing.Size(350, 38);
            this.lbTimpSosire.TabIndex = 21;
            this.lbTimpSosire.Text = "Introduceți timpul de sosire:";
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbId.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbId.ForeColor = System.Drawing.Color.White;
            this.tbId.Location = new System.Drawing.Point(470, 147);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(232, 36);
            this.tbId.TabIndex = 20;
            this.tbId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbId_KeyPress);
            // 
            // lbId
            // 
            this.lbId.BackColor = System.Drawing.Color.Transparent;
            this.lbId.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbId.ForeColor = System.Drawing.Color.White;
            this.lbId.Location = new System.Drawing.Point(98, 147);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(321, 38);
            this.lbId.TabIndex = 19;
            this.lbId.Text = "Introduceți id-ul vehiculului:";
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(294, 62);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(257, 47);
            this.lbTitle.TabIndex = 18;
            this.lbTitle.Text = "Timpul de sosire";
            // 
            // AddTimpSosireVehicol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAdauga);
            this.Controls.Add(this.tbTimpSosire);
            this.Controls.Add(this.lbTimpSosire);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddTimpSosireVehicol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timpul de Sosire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btAdauga;
        private TextBox tbTimpSosire;
        private Label lbTimpSosire;
        private TextBox tbId;
        private Label lbId;
        private Label lbTitle;
    }
}
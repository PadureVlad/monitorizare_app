namespace Monitorizare.AdminForms
{
    partial class AddNrCalatori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNrCalatori));
            this.btAdauga = new System.Windows.Forms.Button();
            this.tbNrCalatori = new System.Windows.Forms.TextBox();
            this.lbNrCalatori = new System.Windows.Forms.Label();
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
            this.btAdauga.Location = new System.Drawing.Point(364, 348);
            this.btAdauga.Name = "btAdauga";
            this.btAdauga.Size = new System.Drawing.Size(146, 43);
            this.btAdauga.TabIndex = 17;
            this.btAdauga.Text = "Adaugă";
            this.btAdauga.UseVisualStyleBackColor = false;
            this.btAdauga.Click += new System.EventHandler(this.btAdauga_Click);
            // 
            // tbNrCalatori
            // 
            this.tbNrCalatori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNrCalatori.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNrCalatori.ForeColor = System.Drawing.Color.White;
            this.tbNrCalatori.Location = new System.Drawing.Point(464, 262);
            this.tbNrCalatori.Name = "tbNrCalatori";
            this.tbNrCalatori.Size = new System.Drawing.Size(232, 36);
            this.tbNrCalatori.TabIndex = 16;
            this.tbNrCalatori.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbId_KeyPress);
            // 
            // lbNrCalatori
            // 
            this.lbNrCalatori.BackColor = System.Drawing.Color.Transparent;
            this.lbNrCalatori.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNrCalatori.ForeColor = System.Drawing.Color.White;
            this.lbNrCalatori.Location = new System.Drawing.Point(92, 262);
            this.lbNrCalatori.Name = "lbNrCalatori";
            this.lbNrCalatori.Size = new System.Drawing.Size(350, 38);
            this.lbNrCalatori.TabIndex = 15;
            this.lbNrCalatori.Text = "Introduceți numarul de calatori:";
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbId.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbId.ForeColor = System.Drawing.Color.White;
            this.tbId.Location = new System.Drawing.Point(464, 148);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(232, 36);
            this.tbId.TabIndex = 14;
            this.tbId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbId_KeyPress);
            // 
            // lbId
            // 
            this.lbId.BackColor = System.Drawing.Color.Transparent;
            this.lbId.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbId.ForeColor = System.Drawing.Color.White;
            this.lbId.Location = new System.Drawing.Point(92, 148);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(321, 38);
            this.lbId.TabIndex = 13;
            this.lbId.Text = "Introduceți id-ul vehiculului:";
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(253, 62);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(299, 47);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "Numarul de calatori";
            // 
            // AddNrCalatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAdauga);
            this.Controls.Add(this.tbNrCalatori);
            this.Controls.Add(this.lbNrCalatori);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddNrCalatori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numar de Calatori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btAdauga;
        private TextBox tbNrCalatori;
        private Label lbNrCalatori;
        private TextBox tbId;
        private Label lbId;
        private Label lbTitle;
    }
}
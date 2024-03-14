namespace Monitorizare.AdminForms
{
    partial class AddVehiculeProblem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVehiculeProblem));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbProblema = new System.Windows.Forms.TextBox();
            this.lbProblema = new System.Windows.Forms.Label();
            this.btAdauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(102, 65);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(443, 47);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Problema tehnica a vehiculului";
            // 
            // lbId
            // 
            this.lbId.BackColor = System.Drawing.Color.Transparent;
            this.lbId.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbId.Location = new System.Drawing.Point(30, 155);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(321, 38);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "Introduceți id-ul vehiculului:";
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.Aquamarine;
            this.tbId.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbId.Location = new System.Drawing.Point(357, 155);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(232, 36);
            this.tbId.TabIndex = 2;
            this.tbId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbId_KeyPress);
            // 
            // tbProblema
            // 
            this.tbProblema.BackColor = System.Drawing.Color.Aquamarine;
            this.tbProblema.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbProblema.Location = new System.Drawing.Point(357, 269);
            this.tbProblema.Name = "tbProblema";
            this.tbProblema.Size = new System.Drawing.Size(232, 36);
            this.tbProblema.TabIndex = 4;
            // 
            // lbProblema
            // 
            this.lbProblema.BackColor = System.Drawing.Color.Transparent;
            this.lbProblema.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProblema.Location = new System.Drawing.Point(30, 269);
            this.lbProblema.Name = "lbProblema";
            this.lbProblema.Size = new System.Drawing.Size(332, 38);
            this.lbProblema.TabIndex = 3;
            this.lbProblema.Text = "Introduceți problema tehnica:";
            // 
            // btAdauga
            // 
            this.btAdauga.BackColor = System.Drawing.Color.Firebrick;
            this.btAdauga.FlatAppearance.BorderSize = 0;
            this.btAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdauga.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAdauga.ForeColor = System.Drawing.Color.White;
            this.btAdauga.Location = new System.Drawing.Point(257, 355);
            this.btAdauga.Name = "btAdauga";
            this.btAdauga.Size = new System.Drawing.Size(146, 43);
            this.btAdauga.TabIndex = 5;
            this.btAdauga.Text = "Adaugă";
            this.btAdauga.UseVisualStyleBackColor = false;
            this.btAdauga.Click += new System.EventHandler(this.btAdauga_Click);
            // 
            // AddVehiculeProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 437);
            this.Controls.Add(this.btAdauga);
            this.Controls.Add(this.tbProblema);
            this.Controls.Add(this.lbProblema);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddVehiculeProblem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Probleme tehnice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitle;
        private Label lbId;
        private TextBox tbId;
        private TextBox tbProblema;
        private Label lbProblema;
        private Button btAdauga;
    }
}
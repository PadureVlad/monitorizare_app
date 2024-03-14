namespace Monitorizare.AdminForms
{
    partial class AddNivelCombustibil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNivelCombustibil));
            this.tbNivel = new System.Windows.Forms.TextBox();
            this.lbNivel = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btAdauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNivel
            // 
            this.tbNivel.BackColor = System.Drawing.Color.Aquamarine;
            this.tbNivel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNivel.Location = new System.Drawing.Point(415, 271);
            this.tbNivel.Name = "tbNivel";
            this.tbNivel.Size = new System.Drawing.Size(232, 36);
            this.tbNivel.TabIndex = 10;
            this.tbNivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNivel_KeyPress);
            // 
            // lbNivel
            // 
            this.lbNivel.BackColor = System.Drawing.Color.Transparent;
            this.lbNivel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNivel.Location = new System.Drawing.Point(37, 271);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(372, 38);
            this.lbNivel.TabIndex = 9;
            this.lbNivel.Text = "Introduceți nivelul de combustibil:";
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.Aquamarine;
            this.tbId.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbId.Location = new System.Drawing.Point(415, 157);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(232, 36);
            this.tbId.TabIndex = 8;
            this.tbId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbId_KeyPress);
            // 
            // lbId
            // 
            this.lbId.BackColor = System.Drawing.Color.Transparent;
            this.lbId.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbId.Location = new System.Drawing.Point(37, 157);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(321, 38);
            this.lbId.TabIndex = 7;
            this.lbId.Text = "Introduceți id-ul vehiculului:";
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(109, 69);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(516, 47);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Nivelul de combustibil al vehiculului";
            // 
            // btAdauga
            // 
            this.btAdauga.BackColor = System.Drawing.Color.Firebrick;
            this.btAdauga.FlatAppearance.BorderSize = 0;
            this.btAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdauga.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAdauga.ForeColor = System.Drawing.Color.White;
            this.btAdauga.Location = new System.Drawing.Point(292, 373);
            this.btAdauga.Name = "btAdauga";
            this.btAdauga.Size = new System.Drawing.Size(146, 43);
            this.btAdauga.TabIndex = 11;
            this.btAdauga.Text = "Adaugă";
            this.btAdauga.UseVisualStyleBackColor = false;
            this.btAdauga.Click += new System.EventHandler(this.btAdauga_Click);
            // 
            // AddNivelCombustibil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 466);
            this.Controls.Add(this.btAdauga);
            this.Controls.Add(this.tbNivel);
            this.Controls.Add(this.lbNivel);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddNivelCombustibil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nivel Combustibil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbNivel;
        private Label lbNivel;
        private TextBox tbId;
        private Label lbId;
        private Label lbTitle;
        private Button btAdauga;
    }
}
namespace Monitorizare.UserForms
{
    partial class ViewNumarPasageri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewNumarPasageri));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lvVehicule = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.tipulVehiculului = new System.Windows.Forms.ColumnHeader();
            this.nrRutei = new System.Windows.Forms.ColumnHeader();
            this.locatia = new System.Windows.Forms.ColumnHeader();
            this.disponibil = new System.Windows.Forms.ColumnHeader();
            this.functionare = new System.Windows.Forms.ColumnHeader();
            this.nrCalatori = new System.Windows.Forms.ColumnHeader();
            this.gradOcupare = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lbTitle.Location = new System.Drawing.Point(236, 21);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(400, 38);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Numărul de călători a rutelor";
            // 
            // lvVehicule
            // 
            this.lvVehicule.BackColor = System.Drawing.SystemColors.Menu;
            this.lvVehicule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvVehicule.BackgroundImage")));
            this.lvVehicule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvVehicule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.tipulVehiculului,
            this.nrRutei,
            this.locatia,
            this.disponibil,
            this.functionare,
            this.nrCalatori,
            this.gradOcupare});
            this.lvVehicule.ForeColor = System.Drawing.Color.Black;
            this.lvVehicule.Location = new System.Drawing.Point(5, 84);
            this.lvVehicule.Name = "lvVehicule";
            this.lvVehicule.Size = new System.Drawing.Size(872, 457);
            this.lvVehicule.TabIndex = 5;
            this.lvVehicule.UseCompatibleStateImageBehavior = false;
            this.lvVehicule.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.Width = 40;
            // 
            // tipulVehiculului
            // 
            this.tipulVehiculului.Text = "Tipul Vehiculului";
            this.tipulVehiculului.Width = 120;
            // 
            // nrRutei
            // 
            this.nrRutei.Text = "Nr. Rutei";
            this.nrRutei.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nrRutei.Width = 80;
            // 
            // locatia
            // 
            this.locatia.Text = "Locatia";
            this.locatia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.locatia.Width = 100;
            // 
            // disponibil
            // 
            this.disponibil.Text = "Disponibil";
            this.disponibil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.disponibil.Width = 120;
            // 
            // functionare
            // 
            this.functionare.Text = "Functionare";
            this.functionare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.functionare.Width = 120;
            // 
            // nrCalatori
            // 
            this.nrCalatori.Text = "Nr. de calatori";
            this.nrCalatori.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nrCalatori.Width = 120;
            // 
            // gradOcupare
            // 
            this.gradOcupare.Text = "Gradul de ocupare";
            this.gradOcupare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gradOcupare.Width = 140;
            // 
            // ViewNumarPasageri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.lvVehicule);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewNumarPasageri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numar de Pasageri";
            this.Load += new System.EventHandler(this.ViewNumarPasageri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitle;
        private ListView lvVehicule;
        private ColumnHeader id;
        private ColumnHeader tipulVehiculului;
        private ColumnHeader nrRutei;
        private ColumnHeader locatia;
        private ColumnHeader disponibil;
        private ColumnHeader functionare;
        private ColumnHeader nrCalatori;
        private ColumnHeader gradOcupare;
    }
}
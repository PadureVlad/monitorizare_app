namespace Monitorizare.UserForms
{
    partial class ViewTraseuUtilizat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTraseuUtilizat));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lvVehicule = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.tipulVehiculului = new System.Windows.Forms.ColumnHeader();
            this.nrRutei = new System.Windows.Forms.ColumnHeader();
            this.locatia = new System.Windows.Forms.ColumnHeader();
            this.disponibil = new System.Windows.Forms.ColumnHeader();
            this.utilizat = new System.Windows.Forms.ColumnHeader();
            this.functionare = new System.Windows.Forms.ColumnHeader();
            this.punctInteres = new System.Windows.Forms.ColumnHeader();
            this.nrCalatori = new System.Windows.Forms.ColumnHeader();
            this.lbTitle1 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lbTitle.Location = new System.Drawing.Point(255, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(352, 38);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Traseele cele mai utilizate";
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
            this.utilizat,
            this.functionare,
            this.punctInteres,
            this.nrCalatori});
            this.lvVehicule.ForeColor = System.Drawing.Color.White;
            this.lvVehicule.Location = new System.Drawing.Point(12, 99);
            this.lvVehicule.Name = "lvVehicule";
            this.lvVehicule.Size = new System.Drawing.Size(858, 442);
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
            this.disponibil.Width = 80;
            // 
            // utilizat
            // 
            this.utilizat.Text = "Utilizat";
            this.utilizat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // functionare
            // 
            this.functionare.Text = "Functionare";
            this.functionare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.functionare.Width = 100;
            // 
            // punctInteres
            // 
            this.punctInteres.Text = "Punctul de interes";
            this.punctInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.punctInteres.Width = 140;
            // 
            // nrCalatori
            // 
            this.nrCalatori.Text = "Nr. de calatori";
            this.nrCalatori.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nrCalatori.Width = 140;
            // 
            // lbTitle1
            // 
            this.lbTitle1.AutoSize = true;
            this.lbTitle1.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle1.ForeColor = System.Drawing.Color.Maroon;
            this.lbTitle1.Location = new System.Drawing.Point(196, 58);
            this.lbTitle1.Name = "lbTitle1";
            this.lbTitle1.Size = new System.Drawing.Size(485, 28);
            this.lbTitle1.TabIndex = 6;
            this.lbTitle1.Text = "(de la cele mai utilizate până la cele mai puțin utilizate)";
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.Transparent;
            this.lbResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResult.ForeColor = System.Drawing.Color.White;
            this.lbResult.Location = new System.Drawing.Point(12, 555);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(858, 59);
            this.lbResult.TabIndex = 7;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ViewTraseuUtilizat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 623);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbTitle1);
            this.Controls.Add(this.lvVehicule);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewTraseuUtilizat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trasee utilizate";
            this.Load += new System.EventHandler(this.ViewTraseuUtilizat_Load);
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
        private ColumnHeader utilizat;
        private ColumnHeader functionare;
        private ColumnHeader punctInteres;
        private ColumnHeader nrCalatori;
        private Label lbTitle1;
        private Label lbResult;
    }
}
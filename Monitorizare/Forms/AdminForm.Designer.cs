namespace Monitorizare.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.vehiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugăVehiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugăVehiculeCuProblemeTehniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugăNivelulDeCombustibilPentruVehiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugăVitezaFiecăruiVehiculToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traseeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugăPuncteleDeInteresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugăNumărulDeCălătoriPentruFiecareTraseuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugăZoneleCuRiscDeAccidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timpulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugăTimpulTraseuluiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ștergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ștergereVehiculToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btRefresh = new System.Windows.Forms.Button();
            this.lbTitlu = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.tipulVehiculului = new System.Windows.Forms.ColumnHeader();
            this.nrRutei = new System.Windows.Forms.ColumnHeader();
            this.locatia = new System.Windows.Forms.ColumnHeader();
            this.disponibil = new System.Windows.Forms.ColumnHeader();
            this.utilizat = new System.Windows.Forms.ColumnHeader();
            this.functionare = new System.Windows.Forms.ColumnHeader();
            this.timpulSosire = new System.Windows.Forms.ColumnHeader();
            this.problemeTehnice = new System.Windows.Forms.ColumnHeader();
            this.nivelCombustibil = new System.Windows.Forms.ColumnHeader();
            this.punctInteres = new System.Windows.Forms.ColumnHeader();
            this.nrCalatori = new System.Windows.Forms.ColumnHeader();
            this.zonaRisc = new System.Windows.Forms.ColumnHeader();
            this.viteza = new System.Windows.Forms.ColumnHeader();
            this.lvVehicule = new System.Windows.Forms.ListView();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("msPrincipal.BackgroundImage")));
            this.msPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculeToolStripMenuItem,
            this.traseeToolStripMenuItem,
            this.timpulToolStripMenuItem,
            this.ștergereToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(1212, 34);
            this.msPrincipal.TabIndex = 0;
            // 
            // vehiculeToolStripMenuItem
            // 
            this.vehiculeToolStripMenuItem.AutoSize = false;
            this.vehiculeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugăVehiculeToolStripMenuItem,
            this.adaugăVehiculeCuProblemeTehniceToolStripMenuItem,
            this.adaugăNivelulDeCombustibilPentruVehiculeToolStripMenuItem,
            this.adaugăVitezaFiecăruiVehiculToolStripMenuItem});
            this.vehiculeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vehiculeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vehiculeToolStripMenuItem.Name = "vehiculeToolStripMenuItem";
            this.vehiculeToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.vehiculeToolStripMenuItem.Text = "Vehicule";
            // 
            // adaugăVehiculeToolStripMenuItem
            // 
            this.adaugăVehiculeToolStripMenuItem.Name = "adaugăVehiculeToolStripMenuItem";
            this.adaugăVehiculeToolStripMenuItem.Size = new System.Drawing.Size(407, 26);
            this.adaugăVehiculeToolStripMenuItem.Text = "Adaugă vehicule";
            this.adaugăVehiculeToolStripMenuItem.Click += new System.EventHandler(this.adaugăVehiculeToolStripMenuItem_Click);
            // 
            // adaugăVehiculeCuProblemeTehniceToolStripMenuItem
            // 
            this.adaugăVehiculeCuProblemeTehniceToolStripMenuItem.Name = "adaugăVehiculeCuProblemeTehniceToolStripMenuItem";
            this.adaugăVehiculeCuProblemeTehniceToolStripMenuItem.Size = new System.Drawing.Size(407, 26);
            this.adaugăVehiculeCuProblemeTehniceToolStripMenuItem.Text = "Adaugă problemele tehnice ale vehiculului";
            this.adaugăVehiculeCuProblemeTehniceToolStripMenuItem.Click += new System.EventHandler(this.adaugăVehiculeCuProblemeTehniceToolStripMenuItem_Click);
            // 
            // adaugăNivelulDeCombustibilPentruVehiculeToolStripMenuItem
            // 
            this.adaugăNivelulDeCombustibilPentruVehiculeToolStripMenuItem.Name = "adaugăNivelulDeCombustibilPentruVehiculeToolStripMenuItem";
            this.adaugăNivelulDeCombustibilPentruVehiculeToolStripMenuItem.Size = new System.Drawing.Size(407, 26);
            this.adaugăNivelulDeCombustibilPentruVehiculeToolStripMenuItem.Text = "Adaugă nivelul de combustibil pentru vehicul";
            this.adaugăNivelulDeCombustibilPentruVehiculeToolStripMenuItem.Click += new System.EventHandler(this.adaugăNivelulDeCombustibilPentruVehiculeToolStripMenuItem_Click);
            // 
            // adaugăVitezaFiecăruiVehiculToolStripMenuItem
            // 
            this.adaugăVitezaFiecăruiVehiculToolStripMenuItem.Name = "adaugăVitezaFiecăruiVehiculToolStripMenuItem";
            this.adaugăVitezaFiecăruiVehiculToolStripMenuItem.Size = new System.Drawing.Size(407, 26);
            this.adaugăVitezaFiecăruiVehiculToolStripMenuItem.Text = "Adaugă viteza vehicul";
            this.adaugăVitezaFiecăruiVehiculToolStripMenuItem.Click += new System.EventHandler(this.adaugăVitezaFiecăruiVehiculToolStripMenuItem_Click);
            // 
            // traseeToolStripMenuItem
            // 
            this.traseeToolStripMenuItem.AutoSize = false;
            this.traseeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugăPuncteleDeInteresToolStripMenuItem,
            this.adaugăNumărulDeCălătoriPentruFiecareTraseuToolStripMenuItem,
            this.adaugăZoneleCuRiscDeAccidenteToolStripMenuItem});
            this.traseeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.traseeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.traseeToolStripMenuItem.Name = "traseeToolStripMenuItem";
            this.traseeToolStripMenuItem.Size = new System.Drawing.Size(100, 30);
            this.traseeToolStripMenuItem.Text = "Trasee";
            // 
            // adaugăPuncteleDeInteresToolStripMenuItem
            // 
            this.adaugăPuncteleDeInteresToolStripMenuItem.Name = "adaugăPuncteleDeInteresToolStripMenuItem";
            this.adaugăPuncteleDeInteresToolStripMenuItem.Size = new System.Drawing.Size(436, 26);
            this.adaugăPuncteleDeInteresToolStripMenuItem.Text = "Adaugă punctele de interes";
            this.adaugăPuncteleDeInteresToolStripMenuItem.Click += new System.EventHandler(this.adaugăPuncteleDeInteresToolStripMenuItem_Click);
            // 
            // adaugăNumărulDeCălătoriPentruFiecareTraseuToolStripMenuItem
            // 
            this.adaugăNumărulDeCălătoriPentruFiecareTraseuToolStripMenuItem.Name = "adaugăNumărulDeCălătoriPentruFiecareTraseuToolStripMenuItem";
            this.adaugăNumărulDeCălătoriPentruFiecareTraseuToolStripMenuItem.Size = new System.Drawing.Size(436, 26);
            this.adaugăNumărulDeCălătoriPentruFiecareTraseuToolStripMenuItem.Text = "Adaugă numărul de călători pentru fiecare traseu";
            this.adaugăNumărulDeCălătoriPentruFiecareTraseuToolStripMenuItem.Click += new System.EventHandler(this.adaugăNumărulDeCălătoriPentruFiecareTraseuToolStripMenuItem_Click);
            // 
            // adaugăZoneleCuRiscDeAccidenteToolStripMenuItem
            // 
            this.adaugăZoneleCuRiscDeAccidenteToolStripMenuItem.Name = "adaugăZoneleCuRiscDeAccidenteToolStripMenuItem";
            this.adaugăZoneleCuRiscDeAccidenteToolStripMenuItem.Size = new System.Drawing.Size(436, 26);
            this.adaugăZoneleCuRiscDeAccidenteToolStripMenuItem.Text = "Adaugă zonele cu risc de accidente";
            this.adaugăZoneleCuRiscDeAccidenteToolStripMenuItem.Click += new System.EventHandler(this.adaugăZoneleCuRiscDeAccidenteToolStripMenuItem_Click);
            // 
            // timpulToolStripMenuItem
            // 
            this.timpulToolStripMenuItem.AutoSize = false;
            this.timpulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugăTimpulTraseuluiToolStripMenuItem});
            this.timpulToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timpulToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.timpulToolStripMenuItem.Name = "timpulToolStripMenuItem";
            this.timpulToolStripMenuItem.Size = new System.Drawing.Size(100, 30);
            this.timpulToolStripMenuItem.Text = "Timpul";
            // 
            // adaugăTimpulTraseuluiToolStripMenuItem
            // 
            this.adaugăTimpulTraseuluiToolStripMenuItem.Name = "adaugăTimpulTraseuluiToolStripMenuItem";
            this.adaugăTimpulTraseuluiToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.adaugăTimpulTraseuluiToolStripMenuItem.Text = "Adaugă timpul de sosire traseului";
            this.adaugăTimpulTraseuluiToolStripMenuItem.Click += new System.EventHandler(this.adaugăTimpulTraseuluiToolStripMenuItem_Click);
            // 
            // ștergereToolStripMenuItem
            // 
            this.ștergereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ștergereVehiculToolStripMenuItem});
            this.ștergereToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ștergereToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ștergereToolStripMenuItem.Name = "ștergereToolStripMenuItem";
            this.ștergereToolStripMenuItem.Size = new System.Drawing.Size(68, 30);
            this.ștergereToolStripMenuItem.Text = "Șterge";
            // 
            // ștergereVehiculToolStripMenuItem
            // 
            this.ștergereVehiculToolStripMenuItem.Name = "ștergereVehiculToolStripMenuItem";
            this.ștergereVehiculToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.ștergereVehiculToolStripMenuItem.Text = "Șterge Vehicul";
            this.ștergereVehiculToolStripMenuItem.Click += new System.EventHandler(this.ștergereVehiculToolStripMenuItem_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRefresh.BackgroundImage")));
            this.btRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRefresh.FlatAppearance.BorderSize = 0;
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Location = new System.Drawing.Point(1163, 67);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(35, 35);
            this.btRefresh.TabIndex = 3;
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // lbTitlu
            // 
            this.lbTitlu.AutoSize = true;
            this.lbTitlu.BackColor = System.Drawing.Color.Transparent;
            this.lbTitlu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitlu.ForeColor = System.Drawing.Color.White;
            this.lbTitlu.Location = new System.Drawing.Point(515, 71);
            this.lbTitlu.Name = "lbTitlu";
            this.lbTitlu.Size = new System.Drawing.Size(199, 32);
            this.lbTitlu.TabIndex = 1;
            this.lbTitlu.Text = "Lista vehiculelor";
            // 
            // id
            // 
            this.id.Text = "Id";
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
            this.functionare.Width = 80;
            // 
            // timpulSosire
            // 
            this.timpulSosire.Text = "Timpul de sosire";
            this.timpulSosire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timpulSosire.Width = 100;
            // 
            // problemeTehnice
            // 
            this.problemeTehnice.Text = "Probleme Tehnice";
            this.problemeTehnice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.problemeTehnice.Width = 100;
            // 
            // nivelCombustibil
            // 
            this.nivelCombustibil.Text = "Nivelul de Combustibil";
            this.nivelCombustibil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nivelCombustibil.Width = 100;
            // 
            // punctInteres
            // 
            this.punctInteres.Text = "Punctul de interes";
            this.punctInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.punctInteres.Width = 100;
            // 
            // nrCalatori
            // 
            this.nrCalatori.Text = "Nr. de calatori";
            this.nrCalatori.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nrCalatori.Width = 90;
            // 
            // zonaRisc
            // 
            this.zonaRisc.Text = "Zona de risc";
            this.zonaRisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zonaRisc.Width = 100;
            // 
            // viteza
            // 
            this.viteza.Text = "Viteza";
            this.viteza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.viteza.Width = 80;
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
            this.timpulSosire,
            this.problemeTehnice,
            this.nivelCombustibil,
            this.punctInteres,
            this.nrCalatori,
            this.zonaRisc,
            this.viteza});
            this.lvVehicule.ForeColor = System.Drawing.Color.White;
            this.lvVehicule.Location = new System.Drawing.Point(7, 109);
            this.lvVehicule.Name = "lvVehicule";
            this.lvVehicule.Size = new System.Drawing.Size(1194, 515);
            this.lvVehicule.TabIndex = 2;
            this.lvVehicule.UseCompatibleStateImageBehavior = false;
            this.lvVehicule.View = System.Windows.Forms.View.Details;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1212, 643);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.lvVehicule);
            this.Controls.Add(this.lbTitlu);
            this.Controls.Add(this.msPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msPrincipal;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip msPrincipal;
        private ToolStripMenuItem vehiculeToolStripMenuItem;
        private ToolStripMenuItem adaugăVehiculeToolStripMenuItem;
        private ToolStripMenuItem adaugăVehiculeCuProblemeTehniceToolStripMenuItem;
        private ToolStripMenuItem adaugăNivelulDeCombustibilPentruVehiculeToolStripMenuItem;
        private ToolStripMenuItem adaugăVitezaFiecăruiVehiculToolStripMenuItem;
        private ToolStripMenuItem traseeToolStripMenuItem;
        private ToolStripMenuItem adaugăPuncteleDeInteresToolStripMenuItem;
        private ToolStripMenuItem adaugăNumărulDeCălătoriPentruFiecareTraseuToolStripMenuItem;
        private ToolStripMenuItem adaugăZoneleCuRiscDeAccidenteToolStripMenuItem;
        private ToolStripMenuItem timpulToolStripMenuItem;
        private ToolStripMenuItem adaugăTimpulTraseuluiToolStripMenuItem;
        private Button btRefresh;
        private ToolStripMenuItem ștergereToolStripMenuItem;
        private ToolStripMenuItem ștergereVehiculToolStripMenuItem;
        private Label lbTitlu;
        private ColumnHeader id;
        private ColumnHeader tipulVehiculului;
        private ColumnHeader nrRutei;
        private ColumnHeader locatia;
        private ColumnHeader disponibil;
        private ColumnHeader utilizat;
        private ColumnHeader functionare;
        private ColumnHeader timpulSosire;
        private ColumnHeader problemeTehnice;
        private ColumnHeader nivelCombustibil;
        private ColumnHeader punctInteres;
        private ColumnHeader nrCalatori;
        private ColumnHeader zonaRisc;
        private ColumnHeader viteza;
        private ListView lvVehicule;
    }
}
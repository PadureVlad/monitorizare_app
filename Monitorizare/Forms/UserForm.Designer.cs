namespace Monitorizare.Forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.vehiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afișeazăListaDeVehiculeDisponibileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afișeazăVehiculeleCeAuProblemeTehniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afișeazăNivelulDeCombustibilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afișeazăVitezaVehiculelorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traseeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afișeazăTraseeleCeleMaiUtilizateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afișeazăPuncteleDeInteresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afișeazăZoneleDeRiscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timpulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afișeazăTimpulDeSosireAVehiculelorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasageriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afișeazăNumărulDePasageriPentruFiecareTraseuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvVehicule = new System.Windows.Forms.ListView();
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
            this.lbTitlu = new System.Windows.Forms.Label();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("msPrincipal.BackgroundImage")));
            this.msPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.msPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculeToolStripMenuItem,
            this.traseeToolStripMenuItem,
            this.timpulToolStripMenuItem,
            this.pasageriToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(1212, 34);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // vehiculeToolStripMenuItem
            // 
            this.vehiculeToolStripMenuItem.AutoSize = false;
            this.vehiculeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afișeazăListaDeVehiculeDisponibileToolStripMenuItem,
            this.afișeazăVehiculeleCeAuProblemeTehniceToolStripMenuItem,
            this.afișeazăNivelulDeCombustibilToolStripMenuItem,
            this.afișeazăVitezaVehiculelorToolStripMenuItem});
            this.vehiculeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vehiculeToolStripMenuItem.Name = "vehiculeToolStripMenuItem";
            this.vehiculeToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.vehiculeToolStripMenuItem.Text = "Vehicule";
            // 
            // afișeazăListaDeVehiculeDisponibileToolStripMenuItem
            // 
            this.afișeazăListaDeVehiculeDisponibileToolStripMenuItem.Name = "afișeazăListaDeVehiculeDisponibileToolStripMenuItem";
            this.afișeazăListaDeVehiculeDisponibileToolStripMenuItem.Size = new System.Drawing.Size(440, 26);
            this.afișeazăListaDeVehiculeDisponibileToolStripMenuItem.Text = "Afișează lista de vehicule disponibile";
            this.afișeazăListaDeVehiculeDisponibileToolStripMenuItem.Click += new System.EventHandler(this.afișeazăListaDeVehiculeDisponibileToolStripMenuItem_Click);
            // 
            // afișeazăVehiculeleCeAuProblemeTehniceToolStripMenuItem
            // 
            this.afișeazăVehiculeleCeAuProblemeTehniceToolStripMenuItem.Name = "afișeazăVehiculeleCeAuProblemeTehniceToolStripMenuItem";
            this.afișeazăVehiculeleCeAuProblemeTehniceToolStripMenuItem.Size = new System.Drawing.Size(440, 26);
            this.afișeazăVehiculeleCeAuProblemeTehniceToolStripMenuItem.Text = "Afișează vehiculele ce au probleme tehnice";
            this.afișeazăVehiculeleCeAuProblemeTehniceToolStripMenuItem.Click += new System.EventHandler(this.afișeazăVehiculeleCeAuProblemeTehniceToolStripMenuItem_Click);
            // 
            // afișeazăNivelulDeCombustibilToolStripMenuItem
            // 
            this.afișeazăNivelulDeCombustibilToolStripMenuItem.Name = "afișeazăNivelulDeCombustibilToolStripMenuItem";
            this.afișeazăNivelulDeCombustibilToolStripMenuItem.Size = new System.Drawing.Size(440, 26);
            this.afișeazăNivelulDeCombustibilToolStripMenuItem.Text = "Monitorizează nivelul de combustibil a vehiculelor";
            this.afișeazăNivelulDeCombustibilToolStripMenuItem.Click += new System.EventHandler(this.afișeazăNivelulDeCombustibilToolStripMenuItem_Click);
            // 
            // afișeazăVitezaVehiculelorToolStripMenuItem
            // 
            this.afișeazăVitezaVehiculelorToolStripMenuItem.Name = "afișeazăVitezaVehiculelorToolStripMenuItem";
            this.afișeazăVitezaVehiculelorToolStripMenuItem.Size = new System.Drawing.Size(440, 26);
            this.afișeazăVitezaVehiculelorToolStripMenuItem.Text = "Monitorizează viteza vehiculelor";
            this.afișeazăVitezaVehiculelorToolStripMenuItem.Click += new System.EventHandler(this.afișeazăVitezaVehiculelorToolStripMenuItem_Click);
            // 
            // traseeToolStripMenuItem
            // 
            this.traseeToolStripMenuItem.AutoSize = false;
            this.traseeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afișeazăTraseeleCeleMaiUtilizateToolStripMenuItem,
            this.afișeazăPuncteleDeInteresToolStripMenuItem,
            this.afișeazăZoneleDeRiscToolStripMenuItem});
            this.traseeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.traseeToolStripMenuItem.Name = "traseeToolStripMenuItem";
            this.traseeToolStripMenuItem.Size = new System.Drawing.Size(130, 30);
            this.traseeToolStripMenuItem.Text = "Trasee";
            // 
            // afișeazăTraseeleCeleMaiUtilizateToolStripMenuItem
            // 
            this.afișeazăTraseeleCeleMaiUtilizateToolStripMenuItem.Name = "afișeazăTraseeleCeleMaiUtilizateToolStripMenuItem";
            this.afișeazăTraseeleCeleMaiUtilizateToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.afișeazăTraseeleCeleMaiUtilizateToolStripMenuItem.Text = "Afișează traseele cele mai utilizate";
            this.afișeazăTraseeleCeleMaiUtilizateToolStripMenuItem.Click += new System.EventHandler(this.afișeazăTraseeleCeleMaiUtilizateToolStripMenuItem_Click);
            // 
            // afișeazăPuncteleDeInteresToolStripMenuItem
            // 
            this.afișeazăPuncteleDeInteresToolStripMenuItem.Name = "afișeazăPuncteleDeInteresToolStripMenuItem";
            this.afișeazăPuncteleDeInteresToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.afișeazăPuncteleDeInteresToolStripMenuItem.Text = "Afișează punctele de interes";
            this.afișeazăPuncteleDeInteresToolStripMenuItem.Click += new System.EventHandler(this.afișeazăPuncteleDeInteresToolStripMenuItem_Click);
            // 
            // afișeazăZoneleDeRiscToolStripMenuItem
            // 
            this.afișeazăZoneleDeRiscToolStripMenuItem.Name = "afișeazăZoneleDeRiscToolStripMenuItem";
            this.afișeazăZoneleDeRiscToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.afișeazăZoneleDeRiscToolStripMenuItem.Text = "Afișează zonele de risc";
            this.afișeazăZoneleDeRiscToolStripMenuItem.Click += new System.EventHandler(this.afișeazăZoneleDeRiscToolStripMenuItem_Click);
            // 
            // timpulToolStripMenuItem
            // 
            this.timpulToolStripMenuItem.AutoSize = false;
            this.timpulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afișeazăTimpulDeSosireAVehiculelorToolStripMenuItem});
            this.timpulToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.timpulToolStripMenuItem.Name = "timpulToolStripMenuItem";
            this.timpulToolStripMenuItem.Size = new System.Drawing.Size(130, 30);
            this.timpulToolStripMenuItem.Text = "Timpul";
            // 
            // afișeazăTimpulDeSosireAVehiculelorToolStripMenuItem
            // 
            this.afișeazăTimpulDeSosireAVehiculelorToolStripMenuItem.Name = "afișeazăTimpulDeSosireAVehiculelorToolStripMenuItem";
            this.afișeazăTimpulDeSosireAVehiculelorToolStripMenuItem.Size = new System.Drawing.Size(359, 26);
            this.afișeazăTimpulDeSosireAVehiculelorToolStripMenuItem.Text = "Afișează timpul de sosire a vehiculelor";
            this.afișeazăTimpulDeSosireAVehiculelorToolStripMenuItem.Click += new System.EventHandler(this.afișeazăTimpulDeSosireAVehiculelorToolStripMenuItem_Click);
            // 
            // pasageriToolStripMenuItem
            // 
            this.pasageriToolStripMenuItem.AutoSize = false;
            this.pasageriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afișeazăNumărulDePasageriPentruFiecareTraseuToolStripMenuItem});
            this.pasageriToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pasageriToolStripMenuItem.Name = "pasageriToolStripMenuItem";
            this.pasageriToolStripMenuItem.Size = new System.Drawing.Size(130, 30);
            this.pasageriToolStripMenuItem.Text = "Pasageri";
            // 
            // afișeazăNumărulDePasageriPentruFiecareTraseuToolStripMenuItem
            // 
            this.afișeazăNumărulDePasageriPentruFiecareTraseuToolStripMenuItem.Name = "afișeazăNumărulDePasageriPentruFiecareTraseuToolStripMenuItem";
            this.afișeazăNumărulDePasageriPentruFiecareTraseuToolStripMenuItem.Size = new System.Drawing.Size(448, 26);
            this.afișeazăNumărulDePasageriPentruFiecareTraseuToolStripMenuItem.Text = "Afișează numărul de pasageri pentru fiecare traseu";
            this.afișeazăNumărulDePasageriPentruFiecareTraseuToolStripMenuItem.Click += new System.EventHandler(this.afișeazăNumărulDePasageriPentruFiecareTraseuToolStripMenuItem_Click);
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
            this.lvVehicule.Location = new System.Drawing.Point(9, 83);
            this.lvVehicule.Name = "lvVehicule";
            this.lvVehicule.Size = new System.Drawing.Size(1194, 515);
            this.lvVehicule.TabIndex = 4;
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
            // lbTitlu
            // 
            this.lbTitlu.AutoSize = true;
            this.lbTitlu.BackColor = System.Drawing.Color.Transparent;
            this.lbTitlu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitlu.ForeColor = System.Drawing.Color.White;
            this.lbTitlu.Location = new System.Drawing.Point(517, 45);
            this.lbTitlu.Name = "lbTitlu";
            this.lbTitlu.Size = new System.Drawing.Size(199, 32);
            this.lbTitlu.TabIndex = 3;
            this.lbTitlu.Text = "Lista vehiculelor";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1212, 643);
            this.Controls.Add(this.lvVehicule);
            this.Controls.Add(this.lbTitlu);
            this.Controls.Add(this.msPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msPrincipal;
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilizator";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip msPrincipal;
        private ToolStripMenuItem vehiculeToolStripMenuItem;
        private ToolStripMenuItem traseeToolStripMenuItem;
        private ToolStripMenuItem timpulToolStripMenuItem;
        private ListView lvVehicule;
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
        private Label lbTitlu;
        private ToolStripMenuItem afișeazăListaDeVehiculeDisponibileToolStripMenuItem;
        private ToolStripMenuItem afișeazăTraseeleCeleMaiUtilizateToolStripMenuItem;
        private ToolStripMenuItem afișeazăTimpulDeSosireAVehiculelorToolStripMenuItem;
        private ToolStripMenuItem afișeazăVehiculeleCeAuProblemeTehniceToolStripMenuItem;
        private ToolStripMenuItem afișeazăNivelulDeCombustibilToolStripMenuItem;
        private ToolStripMenuItem afișeazăPuncteleDeInteresToolStripMenuItem;
        private ToolStripMenuItem afișeazăZoneleDeRiscToolStripMenuItem;
        private ToolStripMenuItem pasageriToolStripMenuItem;
        private ToolStripMenuItem afișeazăNumărulDePasageriPentruFiecareTraseuToolStripMenuItem;
        private ToolStripMenuItem afișeazăVitezaVehiculelorToolStripMenuItem;
    }
}
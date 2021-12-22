namespace mapei
{
    partial class FrmIzmeniObrisi
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
            this.cbJedinicaMere = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbAmbalaza = new System.Windows.Forms.ComboBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.lblAmbalaza = new System.Windows.Forms.Label();
            this.lblTara = new System.Windows.Forms.Label();
            this.lblBruto = new System.Windows.Forms.Label();
            this.lblNeto = new System.Windows.Forms.Label();
            this.lblJedinicaMere = new System.Windows.Forms.Label();
            this.lblNazivProizvoda = new System.Windows.Forms.Label();
            this.lblIDProzvoda = new System.Windows.Forms.Label();
            this.txtTara = new System.Windows.Forms.TextBox();
            this.txtBruto = new System.Windows.Forms.TextBox();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.txtNazivProizvoda = new System.Windows.Forms.TextBox();
            this.txtIdProizvoda = new System.Windows.Forms.TextBox();
            this.lblDodajNoviProizvod = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbJedinicaMere
            // 
            this.cbJedinicaMere.FormattingEnabled = true;
            this.cbJedinicaMere.Location = new System.Drawing.Point(193, 184);
            this.cbJedinicaMere.Name = "cbJedinicaMere";
            this.cbJedinicaMere.Size = new System.Drawing.Size(164, 21);
            this.cbJedinicaMere.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(662, 376);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 38);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbAmbalaza
            // 
            this.cbAmbalaza.FormattingEnabled = true;
            this.cbAmbalaza.Location = new System.Drawing.Point(193, 393);
            this.cbAmbalaza.Name = "cbAmbalaza";
            this.cbAmbalaza.Size = new System.Drawing.Size(164, 21);
            this.cbAmbalaza.TabIndex = 3;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(398, 376);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(104, 38);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // lblAmbalaza
            // 
            this.lblAmbalaza.AutoSize = true;
            this.lblAmbalaza.Location = new System.Drawing.Point(131, 396);
            this.lblAmbalaza.Name = "lblAmbalaza";
            this.lblAmbalaza.Size = new System.Drawing.Size(56, 13);
            this.lblAmbalaza.TabIndex = 31;
            this.lblAmbalaza.Text = "Ambalaza:";
            // 
            // lblTara
            // 
            this.lblTara.AutoSize = true;
            this.lblTara.Location = new System.Drawing.Point(155, 348);
            this.lblTara.Name = "lblTara";
            this.lblTara.Size = new System.Drawing.Size(32, 13);
            this.lblTara.TabIndex = 30;
            this.lblTara.Text = "Tare:";
            // 
            // lblBruto
            // 
            this.lblBruto.AutoSize = true;
            this.lblBruto.Location = new System.Drawing.Point(152, 295);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(35, 13);
            this.lblBruto.TabIndex = 29;
            this.lblBruto.Text = "Bruto:";
            // 
            // lblNeto
            // 
            this.lblNeto.AutoSize = true;
            this.lblNeto.Location = new System.Drawing.Point(154, 240);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(33, 13);
            this.lblNeto.TabIndex = 28;
            this.lblNeto.Text = "Neto:";
            // 
            // lblJedinicaMere
            // 
            this.lblJedinicaMere.AutoSize = true;
            this.lblJedinicaMere.Location = new System.Drawing.Point(112, 187);
            this.lblJedinicaMere.Name = "lblJedinicaMere";
            this.lblJedinicaMere.Size = new System.Drawing.Size(75, 13);
            this.lblJedinicaMere.TabIndex = 27;
            this.lblJedinicaMere.Text = "Jedinica mere:";
            // 
            // lblNazivProizvoda
            // 
            this.lblNazivProizvoda.AutoSize = true;
            this.lblNazivProizvoda.Location = new System.Drawing.Point(101, 137);
            this.lblNazivProizvoda.Name = "lblNazivProizvoda";
            this.lblNazivProizvoda.Size = new System.Drawing.Size(86, 13);
            this.lblNazivProizvoda.TabIndex = 26;
            this.lblNazivProizvoda.Text = "Naziv proizvoda:";
            // 
            // lblIDProzvoda
            // 
            this.lblIDProzvoda.AutoSize = true;
            this.lblIDProzvoda.Location = new System.Drawing.Point(117, 90);
            this.lblIDProzvoda.Name = "lblIDProzvoda";
            this.lblIDProzvoda.Size = new System.Drawing.Size(70, 13);
            this.lblIDProzvoda.TabIndex = 25;
            this.lblIDProzvoda.Text = "ID proizvoda:";
            // 
            // txtTara
            // 
            this.txtTara.Location = new System.Drawing.Point(193, 345);
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(164, 20);
            this.txtTara.TabIndex = 2;
            // 
            // txtBruto
            // 
            this.txtBruto.Location = new System.Drawing.Point(193, 292);
            this.txtBruto.Name = "txtBruto";
            this.txtBruto.Size = new System.Drawing.Size(164, 20);
            this.txtBruto.TabIndex = 23;
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(193, 237);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(164, 20);
            this.txtNeto.TabIndex = 22;
            // 
            // txtNazivProizvoda
            // 
            this.txtNazivProizvoda.Location = new System.Drawing.Point(193, 134);
            this.txtNazivProizvoda.Name = "txtNazivProizvoda";
            this.txtNazivProizvoda.Size = new System.Drawing.Size(164, 20);
            this.txtNazivProizvoda.TabIndex = 0;
            // 
            // txtIdProizvoda
            // 
            this.txtIdProizvoda.Location = new System.Drawing.Point(193, 87);
            this.txtIdProizvoda.Name = "txtIdProizvoda";
            this.txtIdProizvoda.Size = new System.Drawing.Size(164, 20);
            this.txtIdProizvoda.TabIndex = 20;
            // 
            // lblDodajNoviProizvod
            // 
            this.lblDodajNoviProizvod.AutoSize = true;
            this.lblDodajNoviProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodajNoviProizvod.Location = new System.Drawing.Point(195, 36);
            this.lblDodajNoviProizvod.Name = "lblDodajNoviProizvod";
            this.lblDodajNoviProizvod.Size = new System.Drawing.Size(111, 25);
            this.lblDodajNoviProizvod.TabIndex = 19;
            this.lblDodajNoviProizvod.Text = "Proizvod:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(540, 377);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(88, 37);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // FrmIzmeniObrisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.cbJedinicaMere);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbAmbalaza);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.lblAmbalaza);
            this.Controls.Add(this.lblTara);
            this.Controls.Add(this.lblBruto);
            this.Controls.Add(this.lblNeto);
            this.Controls.Add(this.lblJedinicaMere);
            this.Controls.Add(this.lblNazivProizvoda);
            this.Controls.Add(this.lblIDProzvoda);
            this.Controls.Add(this.txtTara);
            this.Controls.Add(this.txtBruto);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.txtNazivProizvoda);
            this.Controls.Add(this.txtIdProizvoda);
            this.Controls.Add(this.lblDodajNoviProizvod);
            this.Name = "FrmIzmeniObrisi";
            this.Text = "Izmeni/obrisi Proizvod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbJedinicaMere;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbAmbalaza;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Label lblAmbalaza;
        private System.Windows.Forms.Label lblTara;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Label lblNeto;
        private System.Windows.Forms.Label lblJedinicaMere;
        private System.Windows.Forms.Label lblNazivProizvoda;
        private System.Windows.Forms.Label lblIDProzvoda;
        private System.Windows.Forms.TextBox txtTara;
        private System.Windows.Forms.TextBox txtBruto;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.TextBox txtNazivProizvoda;
        private System.Windows.Forms.TextBox txtIdProizvoda;
        private System.Windows.Forms.Label lblDodajNoviProizvod;
        private System.Windows.Forms.Button btnObrisi;
    }
}
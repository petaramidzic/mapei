namespace mapei
{
    partial class FrmDodaj
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
            this.lblDodajNoviProizvod = new System.Windows.Forms.Label();
            this.txtIdProizvoda = new System.Windows.Forms.TextBox();
            this.txtNazivProizvoda = new System.Windows.Forms.TextBox();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.txtBruto = new System.Windows.Forms.TextBox();
            this.txtTara = new System.Windows.Forms.TextBox();
            this.lblIDProzvoda = new System.Windows.Forms.Label();
            this.lblNazivProizvoda = new System.Windows.Forms.Label();
            this.lblJedinicaMere = new System.Windows.Forms.Label();
            this.lblNeto = new System.Windows.Forms.Label();
            this.lblBruto = new System.Windows.Forms.Label();
            this.lblTara = new System.Windows.Forms.Label();
            this.lblAmbalaza = new System.Windows.Forms.Label();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.cbAmbalaza = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbJedinicaMere = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDodajNoviProizvod
            // 
            this.lblDodajNoviProizvod.AutoSize = true;
            this.lblDodajNoviProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodajNoviProizvod.Location = new System.Drawing.Point(244, 59);
            this.lblDodajNoviProizvod.Name = "lblDodajNoviProizvod";
            this.lblDodajNoviProizvod.Size = new System.Drawing.Size(158, 25);
            this.lblDodajNoviProizvod.TabIndex = 0;
            this.lblDodajNoviProizvod.Text = "Novi Proizvod";
            // 
            // txtIdProizvoda
            // 
            this.txtIdProizvoda.Location = new System.Drawing.Point(249, 124);
            this.txtIdProizvoda.Name = "txtIdProizvoda";
            this.txtIdProizvoda.Size = new System.Drawing.Size(164, 20);
            this.txtIdProizvoda.TabIndex = 0;
            // 
            // txtNazivProizvoda
            // 
            this.txtNazivProizvoda.Location = new System.Drawing.Point(249, 171);
            this.txtNazivProizvoda.Name = "txtNazivProizvoda";
            this.txtNazivProizvoda.Size = new System.Drawing.Size(164, 20);
            this.txtNazivProizvoda.TabIndex = 1;
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(544, 220);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(164, 20);
            this.txtNeto.TabIndex = 4;
            // 
            // txtBruto
            // 
            this.txtBruto.Location = new System.Drawing.Point(544, 275);
            this.txtBruto.Name = "txtBruto";
            this.txtBruto.Size = new System.Drawing.Size(164, 20);
            this.txtBruto.TabIndex = 5;
            // 
            // txtTara
            // 
            this.txtTara.Location = new System.Drawing.Point(249, 280);
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(164, 20);
            this.txtTara.TabIndex = 3;
            // 
            // lblIDProzvoda
            // 
            this.lblIDProzvoda.AutoSize = true;
            this.lblIDProzvoda.Location = new System.Drawing.Point(173, 127);
            this.lblIDProzvoda.Name = "lblIDProzvoda";
            this.lblIDProzvoda.Size = new System.Drawing.Size(70, 13);
            this.lblIDProzvoda.TabIndex = 8;
            this.lblIDProzvoda.Text = "ID proizvoda:";
            // 
            // lblNazivProizvoda
            // 
            this.lblNazivProizvoda.AutoSize = true;
            this.lblNazivProizvoda.Location = new System.Drawing.Point(157, 174);
            this.lblNazivProizvoda.Name = "lblNazivProizvoda";
            this.lblNazivProizvoda.Size = new System.Drawing.Size(86, 13);
            this.lblNazivProizvoda.TabIndex = 9;
            this.lblNazivProizvoda.Text = "Naziv proizvoda:";
            // 
            // lblJedinicaMere
            // 
            this.lblJedinicaMere.AutoSize = true;
            this.lblJedinicaMere.Location = new System.Drawing.Point(168, 224);
            this.lblJedinicaMere.Name = "lblJedinicaMere";
            this.lblJedinicaMere.Size = new System.Drawing.Size(75, 13);
            this.lblJedinicaMere.TabIndex = 10;
            this.lblJedinicaMere.Text = "Jedinica mere:";
            // 
            // lblNeto
            // 
            this.lblNeto.AutoSize = true;
            this.lblNeto.Location = new System.Drawing.Point(505, 223);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(33, 13);
            this.lblNeto.TabIndex = 11;
            this.lblNeto.Text = "Neto:";
            // 
            // lblBruto
            // 
            this.lblBruto.AutoSize = true;
            this.lblBruto.Location = new System.Drawing.Point(503, 278);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(35, 13);
            this.lblBruto.TabIndex = 12;
            this.lblBruto.Text = "Bruto:";
            // 
            // lblTara
            // 
            this.lblTara.AutoSize = true;
            this.lblTara.Location = new System.Drawing.Point(211, 283);
            this.lblTara.Name = "lblTara";
            this.lblTara.Size = new System.Drawing.Size(32, 13);
            this.lblTara.TabIndex = 13;
            this.lblTara.Text = "Tare:";
            // 
            // lblAmbalaza
            // 
            this.lblAmbalaza.AutoSize = true;
            this.lblAmbalaza.Location = new System.Drawing.Point(187, 331);
            this.lblAmbalaza.Name = "lblAmbalaza";
            this.lblAmbalaza.Size = new System.Drawing.Size(56, 13);
            this.lblAmbalaza.TabIndex = 14;
            this.lblAmbalaza.Text = "Ambalaza:";
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProizvod.Location = new System.Drawing.Point(476, 379);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(112, 29);
            this.btnDodajProizvod.TabIndex = 5;
            this.btnDodajProizvod.Text = "Dodaj";
            this.btnDodajProizvod.UseVisualStyleBackColor = true;
            this.btnDodajProizvod.Click += new System.EventHandler(this.btnDodajProizvod_Click);
            // 
            // cbAmbalaza
            // 
            this.cbAmbalaza.FormattingEnabled = true;
            this.cbAmbalaza.Location = new System.Drawing.Point(249, 328);
            this.cbAmbalaza.Name = "cbAmbalaza";
            this.cbAmbalaza.Size = new System.Drawing.Size(164, 21);
            this.cbAmbalaza.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(647, 379);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 29);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbJedinicaMere
            // 
            this.cbJedinicaMere.FormattingEnabled = true;
            this.cbJedinicaMere.Location = new System.Drawing.Point(249, 221);
            this.cbJedinicaMere.Name = "cbJedinicaMere";
            this.cbJedinicaMere.Size = new System.Drawing.Size(164, 21);
            this.cbJedinicaMere.TabIndex = 2;
            // 
            // FrmDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbJedinicaMere);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbAmbalaza);
            this.Controls.Add(this.btnDodajProizvod);
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
            this.Name = "FrmDodaj";
            this.Text = "Novi Proizvod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDodajNoviProizvod;
        private System.Windows.Forms.TextBox txtIdProizvoda;
        private System.Windows.Forms.TextBox txtNazivProizvoda;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.TextBox txtBruto;
        private System.Windows.Forms.TextBox txtTara;
        private System.Windows.Forms.Label lblIDProzvoda;
        private System.Windows.Forms.Label lblNazivProizvoda;
        private System.Windows.Forms.Label lblJedinicaMere;
        private System.Windows.Forms.Label lblNeto;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Label lblTara;
        private System.Windows.Forms.Label lblAmbalaza;
        private System.Windows.Forms.Button btnDodajProizvod;
        private System.Windows.Forms.ComboBox cbAmbalaza;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbJedinicaMere;
    }
}
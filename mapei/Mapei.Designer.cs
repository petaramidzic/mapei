namespace mapei
{
    partial class Mapei
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
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProzivodIzmeni = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFilterObrisi = new System.Windows.Forms.Button();
            this.btnFilterPrimeni = new System.Windows.Forms.Button();
            this.txtFilterAmbalaza = new System.Windows.Forms.TextBox();
            this.txtFilterID = new System.Windows.Forms.TextBox();
            this.lblAmbalazaFilter = new System.Windows.Forms.Label();
            this.lblIDFilter = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPregledIzvestaja = new System.Windows.Forms.Button();
            this.btnIzvestajNapravi = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            this.dgvProizvodi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(12, 189);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.Size = new System.Drawing.Size(765, 231);
            this.dgvProizvodi.TabIndex = 0;
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProizvod.Location = new System.Drawing.Point(28, 43);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(139, 22);
            this.btnDodajProizvod.TabIndex = 1;
            this.btnDodajProizvod.Text = "Dodaj";
            this.btnDodajProizvod.UseVisualStyleBackColor = true;
            this.btnDodajProizvod.Click += new System.EventHandler(this.btnDodajProizvod_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProzivodIzmeni);
            this.groupBox1.Controls.Add(this.btnDodajProizvod);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 149);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proizvodi";
            // 
            // btnProzivodIzmeni
            // 
            this.btnProzivodIzmeni.Location = new System.Drawing.Point(28, 80);
            this.btnProzivodIzmeni.Name = "btnProzivodIzmeni";
            this.btnProzivodIzmeni.Size = new System.Drawing.Size(139, 23);
            this.btnProzivodIzmeni.TabIndex = 3;
            this.btnProzivodIzmeni.Text = "Izmeni/Obrisi";
            this.btnProzivodIzmeni.UseVisualStyleBackColor = true;
            this.btnProzivodIzmeni.Click += new System.EventHandler(this.btnProzivodIzmeni_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFilterObrisi);
            this.groupBox2.Controls.Add(this.btnFilterPrimeni);
            this.groupBox2.Controls.Add(this.txtFilterAmbalaza);
            this.groupBox2.Controls.Add(this.txtFilterID);
            this.groupBox2.Controls.Add(this.lblAmbalazaFilter);
            this.groupBox2.Controls.Add(this.lblIDFilter);
            this.groupBox2.Location = new System.Drawing.Point(290, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 149);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // btnFilterObrisi
            // 
            this.btnFilterObrisi.Location = new System.Drawing.Point(15, 117);
            this.btnFilterObrisi.Name = "btnFilterObrisi";
            this.btnFilterObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnFilterObrisi.TabIndex = 5;
            this.btnFilterObrisi.Text = "Resetuj";
            this.btnFilterObrisi.UseVisualStyleBackColor = true;
            this.btnFilterObrisi.Click += new System.EventHandler(this.btnFilterObrisi_Click);
            // 
            // btnFilterPrimeni
            // 
            this.btnFilterPrimeni.Location = new System.Drawing.Point(113, 117);
            this.btnFilterPrimeni.Name = "btnFilterPrimeni";
            this.btnFilterPrimeni.Size = new System.Drawing.Size(75, 23);
            this.btnFilterPrimeni.TabIndex = 4;
            this.btnFilterPrimeni.Text = "Primeni";
            this.btnFilterPrimeni.UseVisualStyleBackColor = true;
            this.btnFilterPrimeni.Click += new System.EventHandler(this.btnFilterPrimeni_Click);
            // 
            // txtFilterAmbalaza
            // 
            this.txtFilterAmbalaza.Location = new System.Drawing.Point(88, 77);
            this.txtFilterAmbalaza.Name = "txtFilterAmbalaza";
            this.txtFilterAmbalaza.Size = new System.Drawing.Size(100, 20);
            this.txtFilterAmbalaza.TabIndex = 3;
            // 
            // txtFilterID
            // 
            this.txtFilterID.Location = new System.Drawing.Point(88, 39);
            this.txtFilterID.Name = "txtFilterID";
            this.txtFilterID.Size = new System.Drawing.Size(100, 20);
            this.txtFilterID.TabIndex = 2;
            // 
            // lblAmbalazaFilter
            // 
            this.lblAmbalazaFilter.AutoSize = true;
            this.lblAmbalazaFilter.Location = new System.Drawing.Point(26, 80);
            this.lblAmbalazaFilter.Name = "lblAmbalazaFilter";
            this.lblAmbalazaFilter.Size = new System.Drawing.Size(56, 13);
            this.lblAmbalazaFilter.TabIndex = 1;
            this.lblAmbalazaFilter.Text = "Ambalaza:";
            // 
            // lblIDFilter
            // 
            this.lblIDFilter.AutoSize = true;
            this.lblIDFilter.Location = new System.Drawing.Point(12, 42);
            this.lblIDFilter.Name = "lblIDFilter";
            this.lblIDFilter.Size = new System.Drawing.Size(70, 13);
            this.lblIDFilter.TabIndex = 0;
            this.lblIDFilter.Text = "ID proizvoda:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPregledIzvestaja);
            this.groupBox3.Controls.Add(this.btnIzvestajNapravi);
            this.groupBox3.Location = new System.Drawing.Point(606, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 149);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Izvestaj";
            // 
            // btnPregledIzvestaja
            // 
            this.btnPregledIzvestaja.Location = new System.Drawing.Point(37, 90);
            this.btnPregledIzvestaja.Name = "btnPregledIzvestaja";
            this.btnPregledIzvestaja.Size = new System.Drawing.Size(114, 23);
            this.btnPregledIzvestaja.TabIndex = 1;
            this.btnPregledIzvestaja.Text = "Pregled izvestaja";
            this.btnPregledIzvestaja.UseVisualStyleBackColor = true;
            this.btnPregledIzvestaja.Click += new System.EventHandler(this.btnPregledIzvestaja_Click);
            // 
            // btnIzvestajNapravi
            // 
            this.btnIzvestajNapravi.Location = new System.Drawing.Point(37, 42);
            this.btnIzvestajNapravi.Name = "btnIzvestajNapravi";
            this.btnIzvestajNapravi.Size = new System.Drawing.Size(114, 23);
            this.btnIzvestajNapravi.TabIndex = 0;
            this.btnIzvestajNapravi.Text = "Napravi novi izvestaj";
            this.btnIzvestajNapravi.UseVisualStyleBackColor = true;
            this.btnIzvestajNapravi.Click += new System.EventHandler(this.btnIzvestajNapravi_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(516, 46);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "osvezi bazu";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(702, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Izadji";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Mapei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProizvodi);
            this.Name = "Mapei";
            this.Text = "Mapei";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Button btnDodajProizvod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProzivodIzmeni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFilterObrisi;
        private System.Windows.Forms.Button btnFilterPrimeni;
        private System.Windows.Forms.TextBox txtFilterAmbalaza;
        private System.Windows.Forms.TextBox txtFilterID;
        private System.Windows.Forms.Label lblAmbalazaFilter;
        private System.Windows.Forms.Label lblIDFilter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPregledIzvestaja;
        private System.Windows.Forms.Button btnIzvestajNapravi;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btnClose;
    }
}


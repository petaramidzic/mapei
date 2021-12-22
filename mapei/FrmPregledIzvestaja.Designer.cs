namespace mapei
{
    partial class FrmPregledIzvestaja
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
            this.dgvPregledIzvestaja = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiIzvestaj = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledIzvestaja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPregledIzvestaja
            // 
            this.dgvPregledIzvestaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPregledIzvestaja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPregledIzvestaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledIzvestaja.Location = new System.Drawing.Point(36, 112);
            this.dgvPregledIzvestaja.Name = "dgvPregledIzvestaja";
            this.dgvPregledIzvestaja.Size = new System.Drawing.Size(731, 210);
            this.dgvPregledIzvestaja.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pregled kreiranih izvestaja";
            // 
            // btnObrisiIzvestaj
            // 
            this.btnObrisiIzvestaj.Location = new System.Drawing.Point(692, 350);
            this.btnObrisiIzvestaj.Name = "btnObrisiIzvestaj";
            this.btnObrisiIzvestaj.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiIzvestaj.TabIndex = 2;
            this.btnObrisiIzvestaj.Text = "Obrisi";
            this.btnObrisiIzvestaj.UseVisualStyleBackColor = true;
            this.btnObrisiIzvestaj.Click += new System.EventHandler(this.btnObrisiIzvestaj_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(692, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Izadji";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmPregledIzvestaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnObrisiIzvestaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPregledIzvestaja);
            this.Name = "FrmPregledIzvestaja";
            this.Text = "FrmPregledIzvestaja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledIzvestaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregledIzvestaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiIzvestaj;
        private System.Windows.Forms.Button btnClose;
    }
}
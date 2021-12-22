namespace mapei
{
    partial class Baza
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
            this.dgvBazaID = new System.Windows.Forms.DataGridView();
            this.btnProveriIDImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseImportFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddMissingID = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIzvestaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBazaID)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBazaID
            // 
            this.dgvBazaID.AllowUserToAddRows = false;
            this.dgvBazaID.AllowUserToDeleteRows = false;
            this.dgvBazaID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBazaID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBazaID.Location = new System.Drawing.Point(72, 215);
            this.dgvBazaID.Name = "dgvBazaID";
            this.dgvBazaID.Size = new System.Drawing.Size(522, 124);
            this.dgvBazaID.TabIndex = 0;
            // 
            // btnProveriIDImport
            // 
            this.btnProveriIDImport.Location = new System.Drawing.Point(122, 103);
            this.btnProveriIDImport.Name = "btnProveriIDImport";
            this.btnProveriIDImport.Size = new System.Drawing.Size(137, 23);
            this.btnProveriIDImport.TabIndex = 2;
            this.btnProveriIDImport.Text = "Proveri ID u import tabeli";
            this.btnProveriIDImport.UseVisualStyleBackColor = true;
            this.btnProveriIDImport.Click += new System.EventHandler(this.btnProveriIDImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID iz import tabele koji nedostaje u bazi";
            // 
            // btnChooseImportFile
            // 
            this.btnChooseImportFile.Location = new System.Drawing.Point(122, 28);
            this.btnChooseImportFile.Name = "btnChooseImportFile";
            this.btnChooseImportFile.Size = new System.Drawing.Size(137, 23);
            this.btnChooseImportFile.TabIndex = 4;
            this.btnChooseImportFile.Text = "Izaberi fajl za import";
            this.btnChooseImportFile.UseVisualStyleBackColor = true;
            this.btnChooseImportFile.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(284, 31);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(187, 20);
            this.txtFileName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "1.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "2.";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(122, 67);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(137, 23);
            this.btnImport.TabIndex = 8;
            this.btnImport.Text = "Importuj podatke iz fajla";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "3.";
            // 
            // btnAddMissingID
            // 
            this.btnAddMissingID.Location = new System.Drawing.Point(122, 142);
            this.btnAddMissingID.Name = "btnAddMissingID";
            this.btnAddMissingID.Size = new System.Drawing.Size(137, 23);
            this.btnAddMissingID.TabIndex = 10;
            this.btnAddMissingID.Text = "Dodaj ID koji nedostaje";
            this.btnAddMissingID.UseVisualStyleBackColor = true;
            this.btnAddMissingID.Click += new System.EventHandler(this.btnAddMissingID_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "4.";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "5.";
            // 
            // btnIzvestaj
            // 
            this.btnIzvestaj.Location = new System.Drawing.Point(123, 180);
            this.btnIzvestaj.Name = "btnIzvestaj";
            this.btnIzvestaj.Size = new System.Drawing.Size(136, 23);
            this.btnIzvestaj.TabIndex = 14;
            this.btnIzvestaj.Text = "Izvestaj";
            this.btnIzvestaj.UseVisualStyleBackColor = true;
            this.btnIzvestaj.Click += new System.EventHandler(this.btnIzvestaj_Click);
            // 
            // Baza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.btnIzvestaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddMissingID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnChooseImportFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProveriIDImport);
            this.Controls.Add(this.dgvBazaID);
            this.Name = "Baza";
            this.Text = "Baza";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBazaID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBazaID;
        private System.Windows.Forms.Button btnProveriIDImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseImportFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddMissingID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIzvestaj;
    }
}
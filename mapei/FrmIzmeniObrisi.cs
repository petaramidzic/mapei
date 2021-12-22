using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mapei
{
    public partial class FrmIzmeniObrisi : Form
    {
        DataSet ds;
        OleDbDataAdapter adapter_proizvod;
        DataGridView dgv;
        DataGridViewRow selected_row;

        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = c:\\mapei\\mapei.mdb");
        
        //NumberFormatInfo provider = new NumberFormatInfo();

        public FrmIzmeniObrisi(DataGridView _dgv, DataSet _ds, OleDbDataAdapter _da)
        {
            InitializeComponent();

            //provider.NumberDecimalSeparator = ",";
            //provider.NumberGroupSeparator = ".";

            ds = _ds;
            dgv = _dgv;
            adapter_proizvod = _da;
            PopuniPolja();            
        }
        private int PopuniPolja()
        {
            var jedinica_mere = Enum.GetValues(typeof(jedinica_mere));
            int index_reda = dgv.CurrentCell.RowIndex;// index selektovanog reda

            DataGridViewRow selected_row = dgv.Rows[index_reda]; // kreiranje novog reda sa istim indexom            

            cbAmbalaza.DataSource = ds.Tables["Ambalaza"];
            cbAmbalaza.DisplayMember = "Naziv";
            cbAmbalaza.ValueMember = "id_ambalaza";
            cbAmbalaza.Text = Convert.ToString(selected_row.Cells[4].Value);
            cbJedinicaMere.DataSource = jedinica_mere;

            txtNeto.Enabled = false;
            txtBruto.Enabled = false;

            txtIdProizvoda.Text = Convert.ToString(selected_row.Cells[0].Value);

            OleDbCommand cmd = new OleDbCommand("SELECT  * FROM Proizvodi WHERE id_proizvoda = @id_proizvoda", conn);
            cmd.Parameters.AddWithValue("@id_proizvoda", txtIdProizvoda.Text);
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            ds.Tables["Selektovano"].Clear();
            adapter.Fill(ds, "Selektovano");            
            conn.Close(); 

            txtIdProizvoda.Enabled = false;
            
            txtNazivProizvoda.Text = ds.Tables["Selektovano"].Rows[0].ItemArray[1].ToString();
            cbJedinicaMere.Text = ds.Tables["Selektovano"].Rows[0].ItemArray[2].ToString();
            
            txtTara.Text = ds.Tables["Selektovano"].Rows[0].ItemArray[3].ToString();
            cbAmbalaza.Text = ds.Tables["Selektovano"].Rows[0].ItemArray[4].ToString();
            return index_reda;            
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int index_reda = dgv.CurrentRow.Index;
            DataGridViewRow selected_row = dgv.Rows[index_reda]; // kreiranje novog reda sa istim indexom

            txtIdProizvoda.Text = Convert.ToString(selected_row.Cells[0].Value);

            OleDbCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = ("DELETE FROM Proizvodi WHERE id_proizvoda = @obrisi_id");
            cmd.Parameters.AddWithValue("@obrisi_id", txtIdProizvoda.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Uspesno obrisan proizvod iz baze!");
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
        private void BrisanjePoljaUnosa()
        {
            txtIdProizvoda.Clear();
            txtNazivProizvoda.Clear();
            txtNeto.Clear();
            txtBruto.Clear();
            txtTara.Clear();
            cbAmbalaza.SelectedIndex = -1;
            cbJedinicaMere.SelectedIndex = -1;
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            int index_reda = dgv.CurrentRow.Index;
            

            DataGridViewRow selected_row = dgv.Rows[index_reda]; // kreiranje novog reda sa istim indexom

            cbAmbalaza.DataSource = ds.Tables["Ambalaza"];
            cbAmbalaza.DisplayMember = "Naziv";
            cbAmbalaza.ValueMember = "id_ambalaza";

            string txtIdProizvoda = Convert.ToString(selected_row.Cells[0].Value);

            OleDbCommand cmd = conn.CreateCommand();
            OleDbCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = ("DELETE FROM Proizvodi WHERE id_proizvoda = '" + txtIdProizvoda + "'");

            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
            //cmd.Parameters.AddWithValue("@id_proizvoda", txtIdProizvoda);
            //cmd.Parameters.AddWithValue("@Naziv", txtNazivProizvoda.Text);
            //cmd.Parameters.AddWithValue("@jm", cbJedinicaMere.Text);
            
            //decimal tara = Convert.ToDecimal(txtTara.Text.ToString());
            //cmd.Parameters.AddWithValue("@tare", tara);
            //cmd.Parameters.AddWithValue("@id_ambalaza", cbAmbalaza.SelectedValue);
            cmd.CommandText = ("INSERT INTO Proizvodi (id_proizvoda, Naziv, jm, tare, id_ambalaza) VALUES ('" + txtIdProizvoda + "','" + txtNazivProizvoda.Text + "','" + cbJedinicaMere.Text + "','" + txtTara.Text + "','" + cbAmbalaza.SelectedValue + "');");
            //cmd.CommandText = ("UPDATE Proizvodi SET (Naziv, jm, tare, id_ambalaza) VALUES ('" + txtNazivProizvoda.Text + "', '" + cbJedinicaMere.SelectedValue + "', '" + txtTara.Text + "', '" + cbAmbalaza.SelectedValue + "', '" + "' WHERE id_proizvoda = '" + txtIdProizvoda+ "'");
            //cmd.CommandText = ("UPDATE Proizvodi SET Naziv=@Naziv,jm = @jm, tare = @tare,id_ambalaza = @id_ambalaza WHERE id_proizvoda = '" + txtIdProizvoda + "'");
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Uspesno izmenjeni podaci proizvoda u bazi!");
            this.Close();
        }
    }
}

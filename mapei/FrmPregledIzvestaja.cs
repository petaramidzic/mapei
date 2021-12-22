using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mapei
{
    public partial class FrmPregledIzvestaja : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = c:\\mapei\\mapei.mdb");
        DataSet ds;
        public FrmPregledIzvestaja(DataSet _ds)
        {
            InitializeComponent();
            ds = _ds;
            
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Izvestaj", conn);
            conn.Open();
            OleDbDataAdapter adapter_izvestaj = new OleDbDataAdapter(cmd);

            if (ds.Tables["Izvestaj"] == null)
            {
                adapter_izvestaj.Fill(ds, "Izvestaj");
            }
            else
            {
                ds.Tables["Izvestaj"].Clear();
                adapter_izvestaj.Fill(ds, "Izvestaj");
            }
            conn.Close();

            dgvPregledIzvestaja.DataSource = ds.Tables["Izvestaj"];

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObrisiIzvestaj_Click(object sender, EventArgs e)
        {
            int index_reda = dgvPregledIzvestaja.CurrentRow.Index;
            DataGridViewRow selektovano = new DataGridViewRow();
            selektovano = dgvPregledIzvestaja.Rows[index_reda];

            int id = Convert.ToInt32(selektovano.Cells[0].Value);

            OleDbCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = ("DELETE FROM Izvestaj WHERE ID = @id");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Uspesno obrisan izvestaj iz baze");

            OleDbCommand cmd1 = new OleDbCommand("SELECT * FROM Izvestaj", conn);
            conn.Open();
            OleDbDataAdapter adapter_izvestaj = new OleDbDataAdapter(cmd1);

            if (ds.Tables["Izvestaj"] == null)
            {
                adapter_izvestaj.Fill(ds, "Izvestaj");
            }
            else
            {
                ds.Tables["Izvestaj"].Clear();
                adapter_izvestaj.Fill(ds, "Izvestaj");
            }
            conn.Close();

            dgvPregledIzvestaja.DataSource = ds.Tables["Izvestaj"];

        }
    }
}

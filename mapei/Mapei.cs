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
    public partial class Mapei : Form
    {
        OleDbDataAdapter adapter_proizvodi;
        OleDbDataAdapter adapter_ambalaza;
        OleDbDataAdapter adapter_izvestaj;
        OleDbDataAdapter adapter_proizvodi_iz_baze;        
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = c:\\mapei\\mapei.mdb");
        DataTable proizvodi;
        DataSet ds;
        DataGridViewRow dgv;

        public Mapei()
        {
            InitializeComponent();

            adapter_ambalaza = new OleDbDataAdapter("select * from Ambalaza", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\mapei\mapei.mdb");
            //adapter_izvestaj = new OleDbDataAdapter("select * from Izvestaj", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\mapei\mapei.mdb");
            adapter_proizvodi_iz_baze = new OleDbDataAdapter("SELECT Proizvodi.id_proizvoda, Proizvodi.Naziv AS Naziv,Proizvodi.jm, Proizvodi.tare, Ambalaza.naziv AS Ambalaza FROM Ambalaza INNER JOIN Proizvodi ON Ambalaza.[id_ambalaza] = Proizvodi.[id_ambalaza];", @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\mapei\mapei.mdb");
            
            ds = new DataSet();
            
            adapter_ambalaza.Fill(ds, "Ambalaza");
            //adapter_izvestaj.Fill(ds, "Izvestaj");
            adapter_proizvodi_iz_baze.Fill(ds, "Proizvodi_iz_baze");

            DataTable selektovano = ds.Tables.Add("Selektovano");
            selektovano.Columns.Add("id_proizvoda", typeof(String));
            selektovano.Columns.Add("Naziv", typeof(String));
            selektovano.Columns.Add("jm", typeof(String));
            selektovano.Columns.Add("tare", typeof(Double));
            selektovano.Columns.Add("id_ambalaza", typeof(Int32));

            dgvProizvodi.DataSource = ds.Tables["Proizvodi_iz_baze"];
            dgvProizvodi.Columns["tare"].DefaultCellStyle.Format = "N4";

            //trenutno nema pretrage po ambalazi
            txtFilterAmbalaza.Enabled = false;

            //popunjavanje tatbele izvestaja
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

        }
        private void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            FrmDodaj n = new FrmDodaj(ds, adapter_proizvodi);
            n.Show();            
        }
        private void btnProzivodIzmeni_Click(object sender, EventArgs e)
        {
            int index = dgvProizvodi.CurrentCell.RowIndex;
            DataGridViewRow selectedrow = dgvProizvodi.Rows[index];

            if (selectedrow !=null)
            {
                FrmIzmeniObrisi n = new FrmIzmeniObrisi(dgvProizvodi, ds, adapter_proizvodi);
                n.Show();                
            }
            else
            {
                MessageBox.Show("Morate izabrati stavku iz tabele proizvoda");                
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ds.Tables["Proizvodi_iz_baze"].Clear();
            adapter_proizvodi_iz_baze.Fill(ds, "Proizvodi_iz_baze");
            dgvProizvodi.DataSource = ds.Tables["Proizvodi_iz_baze"];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFilterPrimeni_Click(object sender, EventArgs e)
        {
            string trazeni_id = txtFilterID.Text;            

            OleDbCommand cmd = new OleDbCommand("SELECT Proizvodi.id_proizvoda, Proizvodi.Naziv AS Naziv,Proizvodi.jm, Proizvodi.tare, Ambalaza.naziv AS Ambalaza FROM Ambalaza INNER JOIN Proizvodi ON Ambalaza.[id_ambalaza] = Proizvodi.[id_ambalaza] WHERE Proizvodi.id_proizvoda = @trazeni_id", conn);
            cmd.Parameters.AddWithValue("@trazeni_id", trazeni_id);
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            ds.Tables["Proizvodi_iz_baze"].Clear();
            adapter.Fill(ds, "Proizvodi_iz_baze");
            conn.Close();
            
            dgvProizvodi.DataSource = ds.Tables["Proizvodi_iz_baze"];
        }

        private void btnFilterObrisi_Click(object sender, EventArgs e)
        {
            txtFilterID.Clear();
            ds.Tables["Proizvodi_iz_baze"].Clear();
            adapter_proizvodi_iz_baze.Fill(ds, "Proizvodi_iz_baze");
            dgvProizvodi.DataSource = ds.Tables["Proizvodi_iz_baze"];
        }

        private void btnIzvestajNapravi_Click(object sender, EventArgs e)
        { 
            Baza b = new Baza(ds);
            b.Show();
        }

        private void btnPregledIzvestaja_Click(object sender, EventArgs e)
        {
            FrmPregledIzvestaja p = new FrmPregledIzvestaja(ds);
            p.Show();
        }
    }
}

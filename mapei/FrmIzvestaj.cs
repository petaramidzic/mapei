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
    public partial class FrmIzvestaj : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = c:\\mapei\\mapei.mdb");
        DataSet ds;        
        
        public FrmIzvestaj( DataSet _ds)
        {
            InitializeComponent();
            ds = _ds;
            dgvIzvestaj.DataSource = ds.Tables["Izvestaj"];
            
        }

        private void btnKreirajIzvestaj_Click(object sender, EventArgs e)
        {
            double plastika;
            double papir;
            double celik;
            double aluminijum;
            
            

            OleDbCommand cmd1 = conn.CreateCommand();
            OleDbCommand cmd2 = conn.CreateCommand();            
            conn.Open();            
            cmd1.CommandText = ("SELECT Naziv_ambalaze, SUM(Kolicina_otpadnog_materijala) AS Kolicina FROM (SELECT Proizvodi.id_proizvoda, Proizvodi.Naziv AS Naziv, Proizvodi.jm, Proizvodi.tare, Proizvodi.id_ambalaza, Ambalaza.naziv AS Naziv_ambalaze, Import.kolicina, Proizvodi.tare * Import.kolicina AS Kolicina_otpadnog_materijala FROM(Ambalaza INNER JOIN Proizvodi ON Ambalaza.[id_ambalaza] = Proizvodi.[id_ambalaza]) INNER JOIN Import ON Proizvodi.[id_proizvoda] = Import.[id_proizvoda]) GROUP BY Naziv_ambalaze");
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd1);

            if (ds.Tables["Otpad"] == null)
            {
                adapter.Fill(ds, "Otpad");
            }
            else
            {
                ds.Tables["Otpad"].Clear();
                adapter.Fill(ds, "Otpad");
            }            
            conn.Close();

            aluminijum = Convert.ToDouble(ds.Tables["Otpad"].Rows[0]["Kolicina"]);
            papir = Convert.ToDouble(ds.Tables["Otpad"].Rows[1]["Kolicina"]);
            celik = Convert.ToDouble(ds.Tables["Otpad"].Rows[2]["Kolicina"]);
            plastika = Convert.ToDouble(ds.Tables["Otpad"].Rows[3]["Kolicina"]);

            cmd2.CommandText = ("INSERT INTO Izvestaj (naziv_import_tabele, datum_kreiranja_izvestaja, datum_od, datum_do, plastika, papir, celik, aluminijum) VALUES ('" + txtNaziv.Text + "','" + DateTime.Now + "','" + dtpOd.Value.ToShortDateString() + "','" + dtpDo.Value.ToShortDateString() + "','" + plastika + "','" + celik + "','" + papir + "','" + aluminijum + "');");
            conn.Open();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Uspesno dodati podaci u bazu");
            conn.Close();
            dgvIzvestaj.DataSource = null;
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

            dgvIzvestaj.DataSource = ds.Tables["Izvestaj"];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

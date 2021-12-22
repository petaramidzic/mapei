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
using System.Data.SqlClient;

namespace mapei
{
    public partial class FrmDodaj : Form
    {
        DataSet ds;
        OleDbDataAdapter da;
        Mapei forma;

        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = c:\\mapei\\mapei.mdb");
        
        double neto;
        double bruto;
        double tare;  

        public FrmDodaj(DataSet _ds, OleDbDataAdapter _da)
        {
            InitializeComponent();
            ds=_ds;
            da =_da;
            
            var jedinica_mere = Enum.GetValues(typeof(jedinica_mere));
            
            cbAmbalaza.DataSource = ds.Tables["Ambalaza"];
            cbAmbalaza.DisplayMember = "Naziv";
            cbAmbalaza.ValueMember = "id_ambalaza";

            txtBruto.Enabled = false;
            txtNeto.Enabled = false;
            txtBruto.Hide();
            lblBruto.Hide();
            lblNeto.Hide();
            txtNeto.Hide();

            txtNazivProizvoda.Focus();


            cbJedinicaMere.DataSource = jedinica_mere;
            cbJedinicaMere.SelectedIndex = -1;
            cbAmbalaza.SelectedIndex = -1;
        }

        private bool ProveraPoljaUnosa()
        {
            if(String.IsNullOrEmpty(txtIdProizvoda.Text) && String.IsNullOrWhiteSpace(txtIdProizvoda.Text))
             {
                MessageBox.Show("Morate uneti polje ID proizvoda!");
                return false;
            }
            if (String.IsNullOrEmpty(txtNazivProizvoda.Text) && String.IsNullOrWhiteSpace(txtNazivProizvoda.Text))
            {
                MessageBox.Show("Morate uneti polje Naziv proizvoda!");
                return false;
            }
            if (cbJedinicaMere.SelectedItem == null && cbJedinicaMere.SelectedIndex == -1)
            {
                MessageBox.Show("Morate uneti polje Jedinica mere!");
                return false;
            }

            //Ostavljena mogucnost da se radi provera i bruto i neto ako ima potrebe za time 
            //if (!Double.TryParse(txtNeto.Text,out neto))
            //{
            //    MessageBox.Show("Polje Neto mora biti numericko!");
            //    return false;
            //}
            //if (!Double.TryParse(txtBruto.Text, out bruto))
            //{
             //   MessageBox.Show("Polje Bruto mora biti numericko!");
            //    return false;
            //}



            if (!Double.TryParse(txtTara.Text, out tare))
            {
                MessageBox.Show("Polje Tare mora biti numericko!");
                return false;
            }
            if (cbAmbalaza.SelectedItem == null && cbAmbalaza.SelectedIndex == -1)
            {
                MessageBox.Show("Morate uneti polje Ambalaza!");
                return false;
            }
            return true;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            if (ProveraPoljaUnosa())
            {
                OleDbCommand cmd = conn.CreateCommand();
                conn.Open();                
                decimal tare = Convert.ToDecimal(txtTara.Text);
                cmd.CommandText = ("INSERT INTO Proizvodi (id_proizvoda, Naziv, jm, tare, id_ambalaza) VALUES ('" + txtIdProizvoda.Text + "','" + txtNazivProizvoda.Text + "','" + cbJedinicaMere.Text + "','" + tare + "','" + cbAmbalaza.SelectedValue + "');");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Uspesno dodati podaci u bazu");
                conn.Close();
                BrisanjePoljaUnosa();               
            }
        }
    }
}

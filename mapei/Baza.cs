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
    public partial class Baza : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = c:\\mapei\\mapei.mdb");
        DataSet ds;
        OleDbDataAdapter adapter_proizvodi;
        string fileNameExcel;
        string fileNameAccess = @"C:\mapei\mapei.mdb";


        public Baza(DataSet _ds)
        {
            InitializeComponent();
            ds = _ds;
            
        }        

        private void btnProveriIDImport_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = conn.CreateCommand();
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            cmd.CommandText = ("SELECT Import.id_proizvoda, Import.Naziv FROM Import LEFT OUTER JOIN Proizvodi ON Import.id_proizvoda = Proizvodi.id_proizvoda WHERE Proizvodi.id_proizvoda IS NULL");
            //

            if(ds.Tables["Import_razlika_ID"] == null)
            {                
                adapter.Fill(ds, "Import_razlika_ID");
            }
            else
            {
                ds.Tables["Import_razlika_ID"].Clear();
                adapter.Fill(ds, "Import_razlika_ID");
            }            
            conn.Close();
            dgvBazaID.DataSource = ds.Tables["Import_razlika_ID"];            
        }

        private void btnImport_Click(object sender, EventArgs e)
        {            
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.Filter = "Excel files | *.xls;";
                openfile.Title = "Izaberite import datoteku";

            if (openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openfile.FileName.Equals("") == false)
                {
                    txtFileName.Text = openfile.FileName;
                    fileNameExcel = openfile.FileName;
                }

            }  
        }

        private void btnImport_Click_1(object sender, EventArgs e)
        {
            //here is a sample code which reads an Excel file Sheet1 which has 2 columns
            //And inserts the same into an access table
            //Change the file names, sheet name, table names and column names as per your requirements
            //File Names, replae with your file names



            //Connection string for Excel
            //string connectionStringExcel =
            //string.Format("Data Source= {0};Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties="Excel 8.0; HDR=YES "", fileNameExcel);
            string strConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source="+ fileNameExcel +";Extended Properties='Excel 8.0;HDR=YES; IMEX=1;'";

            //Connection string for Access

            string ConnectionStringAccess =
                string.Format("Data Source= {0}; Provider=Microsoft.Jet.OLEDB.4.0; Persist security Info = false", fileNameAccess);

            //Connection object for Excel

            //string connStr = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + fileNameExcel + ";Extended Properties='Excel 12.0;IMEX=1;'";
            OleDbConnection connExcel = new OleDbConnection(strConnectionString);
            //Connection object for Access
            OleDbConnection connAccess = new OleDbConnection(ConnectionStringAccess);
            //Command object for Excel
            OleDbCommand cmdExcel = connExcel.CreateCommand();
            cmdExcel.CommandType = CommandType.Text;
            cmdExcel.CommandText = "SELECT * FROM [Sheet1$]";

            try
            {
                //Brisanje sadrzaja tabele import_privremeno 
                OleDbCommand cmd = conn.CreateCommand();
                conn.Open();
                cmd.CommandText = ("DELETE FROM import_privremeno");
                cmd.ExecuteNonQuery();
                conn.Close();

                //Command object for Access            

                OleDbCommand cmdAccess = connAccess.CreateCommand();
                cmdAccess.CommandType = CommandType.Text;
                cmdAccess.CommandText = "INSERT INTO import_privremeno (id_proizvoda, Naziv, kolicina, jm) VALUES(@column0, @column1, @column2, @column3)";
                //Add parameter to Access command object
                OleDbParameter param0 = new OleDbParameter("@column0", OleDbType.VarChar);
                cmdAccess.Parameters.Add(param0);
                OleDbParameter param1 = new OleDbParameter("@column1", OleDbType.VarChar);
                cmdAccess.Parameters.Add(param1);
                OleDbParameter param2 = new OleDbParameter("@column2", OleDbType.Double);
                cmdAccess.Parameters.Add(param2);
                OleDbParameter param3 = new OleDbParameter("@column3", OleDbType.VarChar);
                cmdAccess.Parameters.Add(param3);

                //Open connections
                connExcel.Open();
                connAccess.Open();
                //Read Excel
                OleDbDataReader drExcel = cmdExcel.ExecuteReader();

                while (drExcel.Read())
                {
                    //Assign values to access command parameters
                    param0.Value = drExcel[0].ToString();
                    param1.Value = drExcel[1].ToString();
                    param2.Value = drExcel[2].ToString();
                    param3.Value = drExcel[3].ToString();

                    //Insert values in access
                    cmdAccess.ExecuteNonQuery();
                }

                //close connections
                connAccess.Close();
                connExcel.Close();

                OleDbCommand cmd1 = conn.CreateCommand();
                conn.Open();

                //sumiranje iz import_privremeno tabele u Import tabelu
                cmd1.CommandText = ("DELETE FROM Import");
                cmd1.ExecuteNonQuery();
                cmd1.CommandText = ("INSERT INTO Import SELECT import_privremeno.id_proizvoda, import_privremeno.Naziv, import_privremeno.jm, Sum(import_privremeno.kolicina) AS kolicina FROM import_privremeno GROUP BY import_privremeno.id_proizvoda, import_privremeno.Naziv, import_privremeno.jm;");
                cmd1.ExecuteNonQuery();
                conn.Close();

                OleDbCommand cmd2 = conn.CreateCommand();
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd2);
                cmd2.CommandText = ("SELECT Import.id_proizvoda, Import.Naziv FROM Import LEFT OUTER JOIN Proizvodi ON Import.id_proizvoda = Proizvodi.id_proizvoda WHERE Proizvodi.id_proizvoda IS NULL");

                if (ds.Tables["Import_razlika_ID"] == null)
                {
                    adapter.Fill(ds, "Import_razlika_ID");
                }
                else
                {
                    ds.Tables["Import_razlika_ID"].Clear();
                    adapter.Fill(ds, "Import_razlika_ID");
                }
                conn.Close();
                dgvBazaID.DataSource = ds.Tables["Import_razlika_ID"];
                MessageBox.Show("Uspesan import podataka!");
            }
            catch(Exception)
            {
                MessageBox.Show("Neusesan import podataka!");
            }
        }

        private void btnAddMissingID_Click(object sender, EventArgs e)
        {
            FrmDodaj d = new FrmDodaj(ds, adapter_proizvodi);
            d.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzvestaj_Click(object sender, EventArgs e)
        {
            FrmIzvestaj i = new FrmIzvestaj(ds);
            i.Show();
        }
    }
} 
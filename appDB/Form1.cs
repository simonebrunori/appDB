using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace appDB
{
   
    public partial class frmDB : Form
    {
        public frmDB()
        {
            InitializeComponent();
        }

        private void frmDB_Load(object sender, EventArgs e)
        {

        }
        
        OpenFileDialog ofd = new OpenFileDialog();

        private void btnPath_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Microsoft DataBase(.accdb, .mdb)|*.accdb;*.mdb";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofd.FileName;
                Program.path = ofd.FileName;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            Program.l.Clear();
            string conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Program.path;
            string sql = txtCmd.Text;
            OleDbConnection connessione = new OleDbConnection(conn);
            OleDbDataReader reader;
            OleDbCommand cmd;
            try
            {
                connessione.Open();
                cmd = new OleDbCommand(sql, connessione);
                reader = cmd.ExecuteReader();
                while (reader.Read())    //finchè riesce a leggere
                {
                    Tlibro libro = new Tlibro(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetValue(5).ToString(), Convert.ToBoolean(reader.GetValue(6)), Convert.ToInt32(reader.GetValue(7)));
                    Program.l.Add(libro);
                }
                reader.Close();
                cmd.Dispose(); //cancello il comando
                connessione.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
            dataGridView1.DataSource = Program.l;
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            txtCmd.Clear();
        }
    }
}

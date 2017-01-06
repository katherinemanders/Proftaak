using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class Inlogscherm : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Katherine Manders\Downloads\SmartParking Versie 5\SmartParking Versie 5\SmartParking\Database1.mdf';Integrated Security=True");

        public Inlogscherm()
        {
            InitializeComponent();
        }

        private void Inlogscherm_Load(object sender, EventArgs e)
        {
            sqlCon.Open();

           // SqlCommand sqlCom = new SqlCommand("SELECT Voornaam FROM Persoon WHERE " , sqlCon);
            //SqlDataReader sqlRdr = sqlCom.ExecuteReader();
            //label zetten op welkom + voornaam
            lblWelkom.Text = "Welkom ";

            sqlCon.Close();

        }
    }
}

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
        // rekening houden met dat de data vanuit de tabel niet geupdate wordt
        // deze moet ook in de debug folder worden geupdate (dat zal dan dus handmatig moeten gebeuren)
        // goed in de gaten houden. 
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Database1.mdf';Integrated Security=True");
        public string gebruikersnaam;

        public Inlogscherm()
        {
            InitializeComponent();
        }

        private void Inlogscherm_Load(object sender, EventArgs e)
        {
            sqlCon.Open();

            SqlCommand sqlcom = new SqlCommand("SELECT Voornaam FROM Persoon WHERE Gebruikersnaam = '" + + "'", sqlCon);

            using (SqlDataReader sqlReader = sqlcom.ExecuteReader())
            {
                while (sqlReader.Read())
                {
                    lblWelkom.Text = "Welkom " + (sqlReader["Voornaam"].ToString());
                }
            }
            
            sqlCon.Close();

        }
    }
}

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
    public partial class Form1 : Form
    {
        private SerialMessenger serialMessenger;
        private Timer readMessageTimer;
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Database1.mdf';Integrated Security=True");
        InlogGevens Inlog;

        public Form1()
        {
            InitializeComponent();
            MessageBuilder messageBuilder = new MessageBuilder('#', '%');
            serialMessenger = new SerialMessenger("COM5", 115200, messageBuilder);

            readMessageTimer = new Timer();
            readMessageTimer.Interval = 10;
            readMessageTimer.Tick += new EventHandler(ReadMessageTimer_Tick);
        }

        private void btnParkeerplaats_Click(object sender, EventArgs e)
        {
            if (pictureBoxParkeerplaats.Visible == false)
            {
                pictureBoxParkeerplaats.Visible = true;
            }
            else
            {
                pictureBoxParkeerplaats.Visible = false;
            }

        }

        private void pictureBoxParkeerplaats_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen w = new Pen(Color.White);
            SolidBrush gray = new SolidBrush(Color.Gray);
            SolidBrush r = new SolidBrush(Color.Red);
            SolidBrush green = new SolidBrush(Color.LawnGreen);

            g.FillRectangle(gray, 2, 2, 295, 200);
            g.DrawRectangle(w, 2, 2, 295, 200);
            g.DrawRectangle(w, 2, 2, 99, 65);
            g.DrawRectangle(w, 100, 2, 99, 65);
            g.DrawRectangle(w, 198, 2, 99, 65);
            g.DrawRectangle(w, 100, 137, 99, 65);
            g.DrawRectangle(w, 198, 137, 99, 65);

            // niet beschikbaar
            //g.FillEllipse(r, 49, 54, 10, 10);
            //g.FillEllipse(r, 147, 54, 10, 10);
            //g.FillEllipse(r, 246, 54, 10, 10);
            //g.FillEllipse(r, 147, 140, 10, 10);
            //g.FillEllipse(r, 246, 140, 10, 10);
            // wel beschikbaar
            //g.FillEllipse(green, 49, 54, 10, 10);
            //g.FillEllipse(green, 147, 54, 10, 10);
            //g.FillEllipse(green, 246, 54, 10, 10);
            //g.FillEllipse(green, 147, 140, 10, 10);
            //g.FillEllipse(green, 246, 140, 10, 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OntvangenBericht(string message)
        {
            if (message.StartsWith("NFC:………"))
            {
                MessageBox.Show("Student/ Medewerker");
                //SELECT ParkeerOmschrijving
                //FROM ParkeerPlaats
                //inner join ParkeerVoorkeur
                //on ParkeerPlaats.Parkeerplaats_ID = ParkeerVoorkeur.Parkeerplaats_ID
                //inner join NFC
                //on NFC.Persoon_ID = ParkeerVoorkeur.Persoon_ID
                //WHERE ParkeerVoorkeur.Persoon_ID = (select NFC.Persoon_ID
                //from NFC
                //where NFCTag like '%#NFC:693196147%%')
            }
            else if (message.StartsWith("BUSY:…"))
            {
                MessageBox.Show("Parkeerplaats bezet");
            }
            else if (message.StartsWith("FREE:…"))
            {
                MessageBox.Show("Parkeerplaats vrijgekomen");
            }
        }
        private void R1(object sender, EventArgs e)
        {
            serialMessenger.SendMessage("ACCES_R1");
        }

        private void R2(object sender, EventArgs e)
        {
            serialMessenger.SendMessage("ACCES_R2");
        }

        private void BUSY(object sender, EventArgs e)
        {
            serialMessenger.SendMessage("NO_ACCES");
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialMessenger.Connect();
                readMessageTimer.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void disconnect()
        {
            try
            {
                readMessageTimer.Enabled = false;
                serialMessenger.Disconnect();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void ReadMessageTimer_Tick(object sender, EventArgs e)
        {
            string[] messages = serialMessenger.ReadMessages();
            if (messages != null)
            {
                foreach (string message in messages)
                {
                    OntvangenBericht(message);
                }
            }
        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            Inlog = new InlogGevens(tbGebruikersnaam.Text.ToString(), tbWachtwoord.Text.ToString());
            string password = string.Empty;
            sqlCon.Open();

            SqlCommand sqlcom = new SqlCommand("SELECT Wachtwoord FROM Persoon WHERE Gebruikersnaam = '" + Inlog.Gebruikersnaam + "'", sqlCon);
            
            using (SqlDataReader sqlReader = sqlcom.ExecuteReader())
            {
                while (sqlReader.Read())
                {
                    password = sqlReader.GetString(0); //The 0 stands for "the 0'th column", so the first column of the result.
                                                           // Do somthing with this rows string, for example to put them in to a list
                    Console.WriteLine("Password: " + password);
                }
            }

            sqlCon.Close();

            Console.WriteLine("Password: " + password);

            if (Inlog.Wachtwoord == password)
            {
                var Inlogscherm = new Inlogscherm();
                Inlogscherm.Show();
                using (Inlogscherm inlogscherm = new Inlogscherm())
                {
                    if (inlogscherm.ShowDialog() == DialogResult.OK)
                    {
                        Inlog.Gebruikersnaam.ToString();
                    }
                }
            }
            else if (Inlog.Wachtwoord != password)
            {
                MessageBox.Show("Wachtwoord en of gebruikersnaam onjuist. Probeer opnieuw.");
            }
           

        }
    }
}

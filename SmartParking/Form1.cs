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
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\Katherine Manders\Desktop\SmartParking\SmartParking\Database1.mdf';Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
          }

        private void btnParkeerplaats_Click(object sender, EventArgs e)
        {
            if (pictureBoxParkeerplaats.Visible == false)
            {
                pictureBoxParkeerplaats.Visible = true;
            } else {
                pictureBoxParkeerplaats.Visible = false;
            }

            sqlCon.Open();
            Console.WriteLine("hoi");
            sqlCon.Close();
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class Form26 : Form
    {
      //  SqlForm1.connection Form1.con = new SqlForm1.connection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + System.IO.Path.GetFullPath("PROIECTed.mdf") + ";Integrated Security=True;User Instance=True");
        public Form26()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void Form26_Load(object sender, EventArgs e)
        {
            
           
        }

        private void schimbareImagineDeProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Alege o imagine de profil!";
            
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string insimg = "update elevi set img='" + openFileDialog1.FileName.ToString() + "' where Nume='" + Form4.a + "'";
                
                SqlDataAdapter sda = new SqlDataAdapter(insimg, Form1.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                pictureBox2.ImageLocation = openFileDialog1.FileName.ToString();
                
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bunifuTileButton2.Visible = true;
            bunifuTileButton1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            pictureBox2.Visible = false;
            bunifuThinButton21.Visible = false;
            bunifuThinButton22.Visible = false;
            Form31 f31 = new Form31();
            SqlDataAdapter sda = new SqlDataAdapter("select img from elevi where Nume='" + Form4.a + "'", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            f31.pictureBox1.ImageLocation = dt.Rows[0][0].ToString();
            f31.pictureBox1.Refresh();
            
        }

        private void schimbarePINToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            bunifuTileButton1.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            bunifuThinButton23.Visible = true;
            label4.Text = "in interfata de schimbare a Parolei";
            
            label2.Text = Form4.a + "," + " ";
            bunifuMetroTextbox1.Visible = true;
            bunifuMetroTextbox2.Visible = true;
           
        }

      
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {

            if (bunifuMetroTextbox1.Text != Form4.
                b)
            {
                MessageBox.Show("Acesta parola nu corespunde cu numele utilizat la logare!");
                bunifuMetroTextbox1.Text = "";
                bunifuMetroTextbox2.Text = "";
            }
            else
            {
                string inspin = "update elevi set parola='" + bunifuMetroTextbox2.Text + "'where Nume='" + Form4.a + "'";
                SqlDataAdapter sda = new SqlDataAdapter(inspin, Form1.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                bunifuTileButton1.Visible = true;
                bunifuTileButton2.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label4.Text = "in interfata de schimbare a imaginii de profil";
                bunifuMetroTextbox1.Visible = false;
                bunifuMetroTextbox2.Visible = false;
                bunifuThinButton23.Visible = false;
                pictureBox2.Visible = false;
                bunifuThinButton21.Visible = false;
                bunifuThinButton22.Visible = false;
            
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void acasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            bunifuTileButton2.Visible = false;
            bunifuTileButton1.Visible = false;
            bunifuImageButton1.Visible = false;
            bunifuImageButton3.Visible = true;

            this.StartPosition = FormStartPosition.CenterScreen;
            bunifuTileButton2.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            pictureBox2.Visible = true;
            bunifuThinButton21.Visible = true;
            bunifuThinButton22.Visible = true;
            label2.Text = Form4.a + "," + " ";
            string sel = "select img from elevi where Nume='" + Form4.a + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sel, Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string path = dt.Rows[0][0].ToString();
            pictureBox2.ImageLocation = path;
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            
            bunifuTileButton2.Visible = false;
            bunifuImageButton1.Visible = false;
            bunifuImageButton3.Visible = true;

            bunifuTileButton1.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            bunifuThinButton23.Visible = true;
            label4.Text = "in interfata de schimbare a Parolei";
            
            label2.Text = Form4.a + "," + " ";
            bunifuMetroTextbox1.Visible = true;
            bunifuMetroTextbox2.Visible = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form31 f31 = new Form31();
           
            this.Close();
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Visible = false;
            bunifuMetroTextbox2.Visible = false;
            label3.Visible = false;
            bunifuTileButton2.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            bunifuThinButton23.Visible = false;
            bunifuImageButton1.Visible = true;
            bunifuImageButton3.Visible = false;
            bunifuTileButton2.Visible = true;
            bunifuTileButton1.Visible = true;

            bunifuThinButton23.Visible = false;
            pictureBox2.Visible = false;
            bunifuThinButton21.Visible = false;
            bunifuThinButton22.Visible = false;
      
            bunifuThinButton21.Visible = false;
            bunifuThinButton22.Visible = false;
        }
    }
}

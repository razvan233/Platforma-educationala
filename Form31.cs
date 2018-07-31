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
    public partial class Form31 : Form
    {
     //   SqlForm1.connection Form1.con = new SqlForm1.connection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + System.IO.Path.GetFullPath("PROIECTed.mdf") + ";Integrated Security=True;User Instance=True");
        public Form31()
        { 
            InitializeComponent();
        }

        private void Form31_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Form29 lectii = new Form29();
            
            lectii.ShowDialog();
           
          
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            Form27 f25 = new Form27();
            f25.ShowDialog();
            
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            Form25 f25 = new Form25();
            f25.ShowDialog();
          
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            Form26 f25 = new Form26();
            f25.ShowDialog();
            

        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            Form28 f25 = new Form28();
            f25.ShowDialog();

        }

    

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 log = new Form4();
            log.Show();
            this.Hide();
       
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versiunea curenta : Versiunea 1, inca in teste \nRealizator: Cristea Razvan");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            Form4.a = "";
            Form4.b = "";
            f4.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();

        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            Form29 lec =new Form29();
            lec.bunifuTileButton11.Visible = true;
            lec.bunifuTileButton15.Visible = true;
            lec.ShowDialog();
        }

        private void bunifuTileButton9_Click(object sender, EventArgs e)
        {
            Form5  lec = new Form5();
            lec.ShowDialog();
        }

        
      
        
    }
}

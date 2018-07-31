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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void Form23_Load(object sender, EventArgs e)
        {
            
        
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Form29 f29=new  Form29();
            
            this.Hide();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void b1(object sender, EventArgs e)
        {
            
        }
        private void b2(object sender, EventArgs e)
        {
            
            SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (Form29.i == 0)
            {
                pictureBox1.ImageLocation = @"poze lectii\1\" + dt.Rows[Form29.i][4].ToString() + ".png";
            }
            if (Form29.i == 1)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][4].ToString();
            }
            if (Form29.i == 2)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][4].ToString();
            }
            if (Form29.i == 3)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][4].ToString();
            }
            if (Form29.i == 4)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][4].ToString();
            }
            if (Form29.i == 5)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][4].ToString();
            }
            if (Form29.i == 6)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][4].ToString();
            }
            if (Form29.i == 7)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][4].ToString();
            }
            if (Form29.i == 8)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][4].ToString();
            } 
            if (Form29.i == 9)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][4].ToString();
            }
        }
     private void b3(object sender, EventArgs e)
        {
           
            SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (Form29.i == 1)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][5].ToString();
            }
            if (Form29.i == 2)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][5].ToString();
            }
            if (Form29.i == 3)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][5].ToString();
            }
            if (Form29.i == 4)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][5].ToString();
            }
            if (Form29.i == 5)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][5].ToString();
            }
            if (Form29.i == 6)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][5].ToString();
            }
            if (Form29.i == 7)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][5].ToString();
            }
            if (Form29.i == 8)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][5].ToString();
            }
            if (Form29.i == 9)
            {
                pictureBox1.ImageLocation = dt.Rows[Form29.i][5].ToString();
            }
        }
     private void b4(object sender, EventArgs e)
        {
         
            SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (Form29.i == 1)
            {

                pictureBox1.ImageLocation = dt.Rows[Form29.i][6].ToString();
            }
            if (Form29.i == 2)
            {

                pictureBox1.ImageLocation = dt.Rows[Form29.i][6].ToString();
            }
            if (Form29.i == 3)
            {

                pictureBox1.ImageLocation = dt.Rows[Form29.i][6].ToString();
            }
            if (Form29.i == 4)
            {

                pictureBox1.ImageLocation = dt.Rows[Form29.i][6].ToString();
            }
            if (Form29.i == 5)
            {

                pictureBox1.ImageLocation = dt.Rows[Form29.i][6].ToString();
            }
            if (Form29.i == 6)
            {

                pictureBox1.ImageLocation = dt.Rows[Form29.i][6].ToString();
            }
            if (Form29.i == 7)
            {

                pictureBox1.ImageLocation = dt.Rows[Form29.i][6].ToString();
            }
            if (Form29.i == 8)
            {

                pictureBox1.ImageLocation = dt.Rows[Form29.i][6].ToString();
            }
            if (Form29.i == 9)
            {

                pictureBox1.ImageLocation = dt.Rows[Form29.i][6].ToString();
            }
        }

     private void bunifuImageButton1_Click(object sender, EventArgs e)
     { 
         SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ", Form1.con);
         DataTable dt = new DataTable();
         sda.Fill(dt);
       
        
         if (Form29.i == 0)
         {
             
             pictureBox1.ImageLocation = @"poze lectii\1\" + dt.Rows[Form29.i][3].ToString() + ".png";
         }
         if (Form29.i == 1)
         {
            
            pictureBox1.ImageLocation = dt.Rows[Form29.i][3].ToString();
        }
         if (Form29.i == 2)
         {

             pictureBox1.ImageLocation = dt.Rows[Form29.i][3].ToString();
         }
         if (Form29.i == 3)
         {

             pictureBox1.ImageLocation = dt.Rows[Form29.i][3].ToString();
         }
         if (Form29.i == 4)
         {

             pictureBox1.ImageLocation = dt.Rows[Form29.i][3].ToString();
         }
         if (Form29.i == 5)
         {

             pictureBox1.ImageLocation = dt.Rows[Form29.i][3].ToString();
         }
         if (Form29.i == 6)
         {

             pictureBox1.ImageLocation = dt.Rows[Form29.i][3].ToString();
         }
         if (Form29.i == 7)
         {

             pictureBox1.ImageLocation = dt.Rows[Form29.i][3].ToString();
         }
         if (Form29.i == 8)
         {

             pictureBox1.ImageLocation = dt.Rows[Form29.i][3].ToString();
         }
         if (Form29.i == 9)
         {

             pictureBox1.ImageLocation = dt.Rows[Form29.i][3].ToString();
         }
       
             
     }

        

      
    }
}

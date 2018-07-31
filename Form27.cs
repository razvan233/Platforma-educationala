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
    public partial class Form27 : Form
    {//SqlForm1.connection Form1.con = new SqlForm1.connection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + System.IO.Path.GetFullPath("PROIECTed.mdf") + ";Integrated Security=True;User Instance=True");
    public static int i = 0;
    public static string reg;
        public Form27()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void Form27_Load(object sender, EventArgs e)
        {
            string selet = "select NrElev,Materia,Clasa,An,Liceul from catalog ";
            string select = "select Nume,Test1,img,Test2,Average,Liceul from elevi";
            SqlDataAdapter sda = new SqlDataAdapter(selet, Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataAdapter ssda = new SqlDataAdapter(select, Form1.con);
            DataTable ddt = new DataTable();
            ssda.Fill(ddt);
            label14.Text = i + 1 + "." + " " + ddt.Rows[i][0].ToString() + "\n" + "Clasa:" + dt.Rows[i][2].ToString() + "\n" + "Anul:" + dt.Rows[i][3].ToString() + "\n" + "Liceul:" + ddt.Rows[i][5].ToString();
            for (int j = 0; j < ddt.Rows.Count; j++)
            {
                comboBox1.Items.Add(ddt.Rows[j][5].ToString());
            }
            }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            
            
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

            string selet = "select NrElev,Materia,Clasa,An,Liceul from catalog ";
            string select = "select Nume,Test1,img,Test2,Average,Liceul from elevi";
            SqlDataAdapter sda = new SqlDataAdapter(selet, Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataAdapter ssda = new SqlDataAdapter(select, Form1.con);
            DataTable ddt = new DataTable();
            ssda.Fill(ddt);
            i++; string select2 = "select Nume,Test1,img,Test2,Average from elevi where Liceul='"+reg+"'";
                SqlDataAdapter sda3 = new SqlDataAdapter(select2, Form1.con);
                DataTable dt3 = new DataTable();
                sda3.Fill(dt3);
            if (i < dt3.Rows.Count)   
            {
                label14.Text = i + 1 + "." + " " + ddt.Rows[i][0].ToString()+"\n"+"Clasa:"+dt.Rows[i][2].ToString()+"\n"+"Anul:"+dt.Rows[i][3].ToString()+"\n"+"Liceul:"+ddt.Rows[i][5].ToString();
               
                pictureBox1.ImageLocation = dt3.Rows[i][2].ToString();
                label7.Text = "Note elev";
                label1.Text = "Materia";
                label2.Text = "Biologie";
                label3.Text = "Fizica";
                label4.Text = "Chimie";
                label5.Text = "Informatica";
                label8.Text = dt3.Rows[i][1].ToString();
                label9.Text = dt3.Rows[i][2].ToString();
                label10.Text = dt3.Rows[i][3].ToString();
                label11.Text = dt3.Rows[i][4].ToString();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {reg = comboBox1.Text;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label14.Visible = true;
            pictureBox1.Visible = true;
            tableLayoutPanel1.Visible = true;
            bunifuThinButton21.Visible = true;
            
           // MessageBox.Show(reg);
            string selet = "select NrElev,Materia,Clasa,An,Liceul from catalog ";
            string select = "select Nume,Test1,img,Test2,Average,Liceul from elevi";
            SqlDataAdapter sda = new SqlDataAdapter(selet, Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataAdapter ssda = new SqlDataAdapter(select, Form1.con);
            DataTable ddt = new DataTable();
            string select2 = "select Nume,Test1,img,Test2,Average from elevi where Liceul='" + reg + "'";
            SqlDataAdapter sda3 = new SqlDataAdapter(select2, Form1.con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            ssda.Fill(ddt); if (i < dt3.Rows.Count)
            {
                 label14.Text = i + 1 + "." + " " + ddt.Rows[i][0].ToString() + "\n" + "Clasa:" + dt.Rows[i][2].ToString() + "\n" + "Anul:" + dt.Rows[i][3].ToString() + "\n" + "Liceul:" + ddt.Rows[i][5].ToString();
                pictureBox1.ImageLocation = dt3.Rows[i][2].ToString();
                label7.Text = "Note elev";
                label1.Text = "Materia";
                label2.Text = "Biologie";
                label3.Text = "Fizica";
                label4.Text = "Chimie";
                label5.Text = "Informatica";
                label8.Text = dt3.Rows[i][1].ToString();
                label9.Text = dt3.Rows[i][2].ToString();
                label10.Text = dt3.Rows[i][3].ToString();
                label11.Text = dt3.Rows[i][4].ToString();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            Form31 f31 = new Form31();
            f31.Show();
            this.Hide();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Form31 f31 = new Form31();
          
           
            this.Hide();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        
    }
}

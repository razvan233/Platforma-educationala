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
    public partial class Form4 : Form
    {
       /// <summary>
       /// 
       /// </summary>
        public static string a,b;
        public Form4()
        {
            InitializeComponent();
        }

        

        
        
      

        

      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 inreg=new Form1();
            inreg.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form31 log = new Form31();
            a = bunifuTextbox1.text;
            b = bunifuTextbox2.text;
            SqlDataAdapter sda = new SqlDataAdapter("select count(*)  from elevi where Nume='" + bunifuTextbox1.text + "'and parola='" + bunifuTextbox2.text + "'", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                
                
                log.bunifuTileButton1.Enabled=true;
                log.bunifuTileButton2.Enabled=true;
                log.bunifuTileButton3.Enabled=true;
                log.bunifuTileButton4.Enabled=true;
                log.bunifuTileButton6.Enabled = true;
                log.pictureBox1.Enabled = true;
                log.logoutToolStripMenuItem.Visible = true;
                log.loginToolStripMenuItem.Visible = false;
                log.label1.Visible = true;
                log.label2.Visible = true;
                SqlDataAdapter sdq = new SqlDataAdapter("select img, Admin from elevi where Nume='" + Form4.a + "'", Form1.con);
                DataTable dt2 = new DataTable();
                sdq.Fill(dt2);
                log.pictureBox1.ImageLocation = dt2.Rows[0][0].ToString();
                log.label1.Text = "Bine ai venit, " + Form4.a;
                if (dt2.Rows[0][1].ToString() == "1")
                {
                    log.label2.Text = "Rang: " + "★ Admin";
                    
                }
                else
                {
                    log.bunifuTileButton5.Enabled = false;
                    string select = "select img,elevPROF from elevi where Nume='"+Form4.a+"'";
                    SqlDataAdapter sda3 = new SqlDataAdapter(select,Form1.con);
                    DataTable dt3 = new DataTable();
                    sda3.Fill(dt3);
                    if (dt3.Rows[0][1].ToString() == "1")
                    {
                        log.label2.Text = "Rang: " + "웃 Profesor";
                        log.bunifuTileButton7.Visible = true;
                        log.bunifuTileButton9.Visible = true;
                        log.bunifuTileButton3.Visible = false;
                        log.bunifuTileButton1.Visible = false;
                        log.bunifuTileButton7.Location = new Point(14, 293);
                        log.bunifuTileButton9.Location = new Point(304, 293);
                        Form29 f29 = new Form29();
                        f29.bunifuTileButton11.Visible = true;
                        f29.bunifuTileButton15.Visible = true;
                    }
                    else
                    {
                        log.label2.Text = "Rang: " + "웃 Elev";
                    }
                }
                log.Size = new Size(876, 454);
                    log.Text = "                                                                                                                                     Pla" +
                    "tformă Educatională";
                    log.Show();
                    this.Hide();
            }
            else {
                MessageBox.Show("Datele introduse nu corespund!");
                bunifuTextbox1.text = "";
                bunifuTextbox2.text = "";
            }
           
           
        }

      

        private void bunifuTextbox1_Enter(object sender, EventArgs e)
        {
            bunifuTextbox1.text = "";
        }

        private void bunifuTextbox2_Enter(object sender, EventArgs e)
        {
            bunifuTextbox2.text = ""; bunifuTextbox2._TextBox.PasswordChar = '●';
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                bunifuTextbox2._TextBox.UseSystemPasswordChar = true;
            }
            else
            {
                bunifuTextbox2._TextBox.UseSystemPasswordChar = false;
            }

        }

        private void bunifuTextbox2_OnTextChange(object sender, EventArgs e)
        {

        }

       
        

    }
}

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
    public partial class Form28 : Form
    {
        public static string user;
        public Form28()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void Form28_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            bunifuThinButton22.Visible = false;
            bunifuThinButton23.Visible = false;
            bunifuThinButton24.Visible = false;
            
            string sel = "select Nume from elevi";
            SqlDataAdapter sda = new SqlDataAdapter(sel, Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int k = 0; k < dt.Rows.Count; k++)
            {
                comboBox1.Items.Add(dt.Rows[k][0].ToString().TrimEnd(' '));
            }
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            string select = "select  count(*) from elevi where Nume='" + comboBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(select, Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                user = comboBox1.Text;
                label2.Visible = true;
                bunifuThinButton22.Visible = true;
                bunifuThinButton23.Visible = true;
                bunifuThinButton24.Visible = true;
                bunifuThinButton21.Visible = false;
                label2.Text = "Sunteti selectat pe user-ul" +" "+ user + ", avem urmatoare modificari posibile.";
                bunifuImageButton1.Visible = true;
                comboBox1.Visible = false;
                label1.Visible = false;
                
            }else
            {
                MessageBox.Show("User-ul nu exista!");
                comboBox1.Text = "";
            }

            
            

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            bunifuThinButton22.Visible = false;
            bunifuThinButton23.Visible = false;
            bunifuThinButton24.Visible = false;
            bunifuThinButton26.Visible = true;
            bunifuThinButton21.Visible = false;
           
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            bunifuMetroTextbox2.Visible = true;
            bunifuMetroTextbox3.Visible = true;
            label5.Text = user;

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form1.con.Open();
            string del = "delete  from elevi where Nume='"+user+"'";
            SqlCommand cmd = new SqlCommand(del, Form1.con);
            cmd.ExecuteNonQuery();
            Form1.con.Close();
            MessageBox.Show("Cont sters cu succes!");
            label2.Visible = false;
            bunifuThinButton22.Visible = false;
            bunifuThinButton23.Visible = false;
            bunifuThinButton24.Visible = false;
            bunifuThinButton21.Visible = true;
            comboBox1.Visible = true;
            label1.Visible = true;

            comboBox1.Text = "";
            bunifuImageButton1.Visible = false;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            int n = 1;
            string upd = "update elevi set Admin='"+n+"'where Nume='"+user+"'";
            SqlDataAdapter sda = new SqlDataAdapter(upd, Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MessageBox.Show(user +" "+ "a fost ridicat la rang-ul de admin!");
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            string pin = "select parola from elevi where Nume='"+user+"'";
            SqlDataAdapter sda = new SqlDataAdapter(pin, Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (bunifuMetroTextbox3.Text != dt.Rows[0][0].ToString())
            {
                MessageBox.Show("Acest parola nu corespunde cu cea din baza de date!");
                bunifuMetroTextbox3.Text = "";
                bunifuMetroTextbox2.Text = "";
            }
            else
            {
                string inspin = "update elevi set parola='" + bunifuMetroTextbox2.Text + "'where Nume='" + user + "'";
                SqlDataAdapter sda2 = new SqlDataAdapter(inspin, Form1.con);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                MessageBox.Show("Pin-ul a fost schimbat cu succes!");
                label2.Visible = true;
                bunifuThinButton22.Visible = true;
                bunifuThinButton23.Visible = true;
                bunifuThinButton24.Visible = true;
                bunifuThinButton21.Visible = false;
                label2.Text = "Sunteti selectat pe user-ul" + " " + user + ", avem urmatoare modificari posibile.";
                bunifuImageButton1.Visible = true;
                comboBox1.Visible = false;
                label1.Visible = false;
                bunifuMetroTextbox2.Visible = false;
                bunifuMetroTextbox3.Visible = false;
                bunifuThinButton26.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form31 f31 = new Form31();
            //f31.Show();Form31 f31 = new Form31();
        
            this.Hide();

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {

        }
    }
}

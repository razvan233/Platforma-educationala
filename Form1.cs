using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
   public static     SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + System.IO.Path.GetFullPath("PROIECTed.mdf") + ";Integrated Security=True;User Instance=True");
      //  public static SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\crist\OneDrive\Desktop\Platforma Educationala\quizz\PROIECTed.mdf;Integrated Security=True;User Instance=True");
   public static int rang = 0;
   string email =
              @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
              @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string select = "select Liceul from licee";

            SqlDataAdapter sda = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                
                comboBox1.Items.Add(dt.Rows[j][0].ToString());
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (bunifuTextbox4.text == bunifuTextbox2.text)
            {
                errorProvider2.Clear();
                if (Regex.IsMatch(bunifuTextbox1.text, email))
                {
                    errorProvider1.Clear();
                    if (checkBox1.Checked == true)
                    {

                        SqlDataAdapter sel = new SqlDataAdapter("select count(*) from elevi where Nume='" + bunifuTextbox3.text + "'", Form1.con);
                        DataTable seldt = new DataTable();
                        sel.Fill(seldt);

                        if (seldt.Rows[0][0].ToString() == "1")
                        {
                            MessageBox.Show("User-ul deja exista!");
                        }
                        else
                        {
                            SqlDataAdapter sdains = new SqlDataAdapter("insert into elevi(Nume,Liceul,Email,parola,elevPROF)values('" + bunifuTextbox3.text + "','" + comboBox1.Text + "','" + bunifuTextbox1.text + "','" + bunifuTextbox2.text + "','" + rang + "')", con);
                            DataTable dt = new DataTable();
                            sdains.Fill(dt);
                            this.Close();
                            Form4 f4 = new Form4();
                            f4.Show();
                        }
                    }
                    else
                    {
                        rang = 1;
                        SqlDataAdapter sel = new SqlDataAdapter("select count(*) from elevi where Nume='" + bunifuTextbox3.text + "'", con);
                        DataTable seldt = new DataTable();
                        sel.Fill(seldt);

                        if (seldt.Rows[0][0].ToString() == "1")
                        {
                            MessageBox.Show("User-ul deja exista!");
                        }
                        else
                        {
                            SqlDataAdapter sdains = new SqlDataAdapter("insert into elevi(Nume,Liceul,Email,parola,elevPROF)values('" + bunifuTextbox3.text + "','" + comboBox1.Text + "','" + bunifuTextbox1.text + "','" + bunifuTextbox2.text + "','" + rang + "')", con);
                            DataTable dt = new DataTable();
                            sdains.Fill(dt);
                            this.Close();
                            Form4 f4 = new Form4();
                            f4.Show();
                        }
                    }
                }
                else
                {
                    errorProvider1.SetError(bunifuTextbox1, "Introduceti un e-mail");
                }
            }
            else
            {
                errorProvider2.SetError(bunifuTextbox2, "Parolele nu corespund!");
                errorProvider2.SetError(bunifuTextbox4, "Parolele nu corespund!");
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void bunifuTextbox3_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox3_Enter(object sender, EventArgs e)
        {

            bunifuTextbox3.text = "";
        }

        private void bunifuTextbox1_Enter(object sender, EventArgs e)
        {
            bunifuTextbox1.text = "";
        }

        private void bunifuTextbox2_Enter(object sender, EventArgs e)
        {
            bunifuTextbox2.text = "";
            bunifuTextbox2._TextBox.PasswordChar = '●';
        }

        private void bunifuTextbox4_Enter(object sender, EventArgs e)
        {
            bunifuTextbox4.text = "";
            bunifuTextbox4._TextBox.PasswordChar = '●';
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                bunifuTextbox2._TextBox.UseSystemPasswordChar = true;
                bunifuTextbox4._TextBox.UseSystemPasswordChar = true;
            }
            else
            {
                bunifuTextbox2._TextBox.UseSystemPasswordChar = false;
                bunifuTextbox4._TextBox.UseSystemPasswordChar = false;
            }
        }


       
    }
}

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
    public partial class Form5 : Form
    {
        public static int rc = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
            
        }

        private void bunifuTextbox2_Enter(object sender, EventArgs e)
        {
            bunifuTextbox2.text = "";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            bool t1 = false, t2 = false, t3 = false, t4 = false, intr = false;
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Introduceti raspuns!");
            }
            else
            {
                errorProvider1.Clear();
                t1 = true;
            }
            if (textBox2.Text == "")
            {
                errorProvider2.SetError(textBox2, "Introduceti raspuns!");
            }
            else
            {
                errorProvider2.Clear();
                t2 = true;
            }
            if (textBox3.Text == "")
            {
                errorProvider3.SetError(textBox3, "Introduceti raspuns!");
            }
            else
            {
                errorProvider3.Clear();
                t3 = true;
            }
            if (textBox4.Text == "")
            {
                errorProvider4.SetError(textBox4, "Introduceti raspuns!");
            }
            else
            {
                errorProvider4.Clear();
                t4 = true;
            }
            if (bunifuTextbox2.text == "")
            {
                errorProvider5.SetError(bunifuTextbox2, "Introduceti intrebarea!");

            }
            else {
                errorProvider5
                .Clear();
                intr = true;
            }
            if (t1 == true && t2 == true && t3 == true && t4 == true && intr == true)
            {
               
                SqlDataAdapter ins = new SqlDataAdapter("insert into test1(Intrebare,r1,r2,r3,r4,rc)values('" + bunifuTextbox2.text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+textBox6.Text+"')", Form1.con);
                DataTable dt = new DataTable();
                ins.Fill(dt);
                bunifuThinButton21.Visible = false;
                bunifuThinButton22.Visible = true;
                textBox6.Visible = false;
                textBox4.Visible = false;
                textBox3.Visible = false;
                textBox3.Visible = false;
                textBox2.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                bunifuTextbox2.Visible = false;
                bunifuThinButton23.Visible = true;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox6.Clear();
                bunifuTextbox2.text = "Intrebarea";



            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
          
            bunifuThinButton23.Visible = false;
            bunifuThinButton21.Visible = true;
            bunifuThinButton22.Visible = false;
            textBox6.Visible = true;
            textBox4.Visible = true;
            textBox3.Visible = true;
            textBox3.Visible = true;
            textBox2.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            bunifuTextbox2.Visible = true;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bunifuThinButton22.Visible = false;
            bunifuThinButton23.Visible = false;
            comboBox1.Visible = true;
            label5.Visible = true;
            bunifuThinButton24.Visible = true;
            SqlDataAdapter sda = new SqlDataAdapter("select Intrebare from test1", Form1.con);
            DataTable dt=new DataTable();
            sda.Fill(dt);
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                comboBox1.Items.Add(dt.Rows[j][0].ToString());
            }

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            label5.Visible = false;
            bunifuThinButton24.Visible = false;
            bunifuThinButton23.Visible = true;
            bunifuThinButton22.Visible = true;
            if (comboBox1.Text == "")
            {
                errorProvider6.SetError(comboBox1, "Alegeti intrebare pe care doriti sa o stergeti!");
            }
            else
            {
                errorProvider6.Clear();
                SqlDataAdapter del = new SqlDataAdapter("delete from test1 where Intrebare='" + comboBox1.Text.ToString()+ "'", Form1.con);
                DataTable dt = new DataTable();
                del.Fill(dt);
                comboBox1.Items.Clear();
                comboBox1.Text = "";
            }
            }

    }
}

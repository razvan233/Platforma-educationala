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
    public partial class Form29 : Form
    {   
        public static int i = 0,nrlec=0;
        string pp="", p2="", p3="", p4="";
        public Form29()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form31 f31 = new Form31();
   
            this.Hide();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            i = 0;
            Form23 lec = new Form23();
            SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lec.pictureBox1.ImageLocation = @"poze lectii\1\" + dt.Rows[i][2].ToString() + ".png";

            lec.richTextBox1.Text ="                                     "+dt.Rows[i][0].ToString()+"\n"+"     "+dt.Rows[i][1].ToString().Trim(' ');
            lec.bunifuImageButton1.ImageLocation = @"poze lectii\1\" + dt.Rows[i][2].ToString() + ".png";
             if (dt.Rows[i][4].ToString() != "")
             {
                
                 lec.bunifuImageButton2.ImageLocation = @"poze lectii\1\" + dt.Rows[i][4].ToString() + ".png";
             }
             else
             {
                 lec.bunifuImageButton2.Visible = false;
             }
            if (dt.Rows[i][5].ToString() != "")
            {
                
                lec.bunifuImageButton3.ImageLocation = @"poze lectii\1\" + dt.Rows[i][5].ToString() + ".png";
            }
            else
            {
                lec.bunifuImageButton3.Visible = false;    
            }

            if (dt.Rows[i][6].ToString() != "")
            {
                lec.bunifuImageButton4.ImageLocation = @"poze lectii\1\" + dt.Rows[i][6].ToString() + ".png";
            }
            else
            {
                lec.bunifuImageButton4.Visible = false;
            }
            
            lec.ShowDialog();
           
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            Form24 f24 = new Form24();
            f24.ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form29_Load(object sender, EventArgs e)
        {
            i = 0;
            Form23 lec = new Form23();
            SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ",Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            
                if (i<dt.Rows.Count)
                {

                    bunifuTileButton1.LabelText = dt.Rows[i][0].ToString();i++;

                }
                if (i < dt.Rows.Count)
                {

                    bunifuTileButton2.LabelText = dt.Rows[i][0].ToString();i++;

                } if (i < dt.Rows.Count)
                {

                    bunifuTileButton9.LabelText = dt.Rows[i][0].ToString();i++;

                } if (i < dt.Rows.Count)
                {

                    bunifuTileButton8.LabelText = dt.Rows[i][0].ToString();i++;

                } if (i < dt.Rows.Count)
                {

                    bunifuTileButton7.LabelText = dt.Rows[i][0].ToString();i++;

                } if (i<dt.Rows.Count)
                {
          
                    bunifuTileButton10.LabelText = dt.Rows[i][0].ToString(); i++;
           
                } if (i < dt.Rows.Count)
                {
                   
                    bunifuTileButton3.LabelText = dt.Rows[i][0].ToString();i++;
                 
                } if (i < dt.Rows.Count)
                {
                
                    bunifuTileButton4.LabelText = dt.Rows[i][0].ToString();i++;
                    
                } if (i < dt.Rows.Count)
                {
                   
                    bunifuTileButton6.LabelText = dt.Rows[i][0].ToString(); i++;
                    
                } if (i < dt.Rows.Count)
                {
                    
                    bunifuTileButton5.LabelText = dt.Rows[i][0].ToString();
                    
                }
                i = 0;
                if (bunifuTileButton9.LabelText != "")
                {
                    bunifuTileButton9.Visible = true;
                }
                if (bunifuTileButton8.LabelText != "")
                {
                    bunifuTileButton8.Visible = true;
                }
                if (bunifuTileButton7.LabelText != "")
                {
                    bunifuTileButton7.Visible = true;
                }
                if (bunifuTileButton10.LabelText != "")
                {
                    bunifuTileButton10.Visible = true;
                }
                if (bunifuTileButton3.LabelText != "")
                {
                    bunifuTileButton3.Visible = true;
                }
                if (bunifuTileButton4.LabelText != "")
                {
                    bunifuTileButton4.Visible = true;
                }
                if (bunifuTileButton6.LabelText != "")
                {
                    bunifuTileButton6.Visible = true;
                }
                if (bunifuTileButton5.LabelText != "")
                {
                    bunifuTileButton5.Visible = true;
                }

            
            
        }

        private void bunifuTileButton2_Click_1(object sender, EventArgs e)
        {
            i = 1;
            Form23 lec = new Form23();
            SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
          lec.pictureBox1.ImageLocation =  dt.Rows[i][2].ToString();

            lec.richTextBox1.Text = "                                     " + dt.Rows[i][0].ToString() + "\n" + "     " + dt.Rows[i][1].ToString().Trim(' ');
            lec.bunifuImageButton1.ImageLocation = dt.Rows[i][2].ToString();
            if (dt.Rows[i][4].ToString() != "")
            {

                lec.bunifuImageButton2.ImageLocation = dt.Rows[i][4].ToString();
            }
            else
            {
                lec.bunifuImageButton2.Visible = false;
            }
            if (dt.Rows[i][5].ToString() != "")
            {

                lec.bunifuImageButton3.ImageLocation =  dt.Rows[i][5].ToString();
            }
            else
            {
                lec.bunifuImageButton3.Visible = false;
            }

            if (dt.Rows[i][6].ToString() != "")
            {
            
                lec.bunifuImageButton4.ImageLocation =  dt.Rows[i][6].ToString();
            }
            else
            {
               
                lec.bunifuImageButton4.Visible = false;
            }
            
            lec.ShowDialog();
        }

        private void bunifuTileButton11_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            bunifuTextbox2.Visible = true;
            richTextBox1.Visible = true;
            bunifuTileButton1.Visible = false;
            bunifuTileButton2.Visible = false;
            bunifuTileButton3.Visible = false;
            bunifuTileButton4.Visible = false;
            bunifuTileButton5.Visible = false;
            bunifuTileButton6.Visible = false;
            bunifuTileButton7.Visible = false;
            bunifuTileButton8.Visible = false;
            bunifuTileButton9.Visible = false;
            bunifuTileButton10.Visible = false;
            bunifuTileButton13.Visible = true;
            bunifuTileButton12.Visible = true;
            bunifuTileButton14.Visible = true;
            bunifuTileButton16.Visible = true;
            bunifuTileButton17.Visible = true;
            bunifuTileButton15.Visible = false;
            SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            nrlec = dt.Rows.Count;
        }

        private void bunifuTextbox2_OnTextChange(object sender, EventArgs e)
        {
            
        }

        private void bunifuTextbox2_Enter(object sender, EventArgs e)
        {
            bunifuTextbox2.text = "";
        }

        private void bunifuTileButton13_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Alege imaginea principala a lectiei!";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pp = openFileDialog1.FileName.ToString();
                
            }
            
        }

        private void bunifuTileButton16_Click(object sender, EventArgs e)
        {
            openFileDialog2.Title = "Alege a doua imagine a lectiei!";

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                p2 = openFileDialog2.FileName.ToString();

            }
        }

        private void bunifuTileButton14_Click(object sender, EventArgs e)
        {
            openFileDialog3.Title = "Alege a treia imagine a lectiei!";

            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                p3 = openFileDialog3.FileName.ToString();

            }
        }

        private void bunifuTileButton17_Click(object sender, EventArgs e)
        {
            openFileDialog4.Title = "Alege a patra imagine a lectiei!";

            if (openFileDialog4.ShowDialog() == DialogResult.OK)
            {
                p4 = openFileDialog4.FileName.ToString();

            }
        }

        private void bunifuTileButton12_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            nrlec = dt.Rows.Count;
            if (nrlec < 10)
            {

                bool test1 = false, test2 = false, test3 = false;

                if (bunifuTextbox2.text == "")
                {
                    errorProvider1.SetError(bunifuTextbox2, "Introduceti un titlu!");

                }
                else
                {
                    errorProvider1.Clear();
                    test1 = true;
                }
                if (richTextBox1.Text == "")
                {
                    errorProvider2.SetError(richTextBox1, "Introduceti un continut lectiei!");
                }
                else
                {
                    errorProvider2.Clear();
                    test2 = true;
                }
                if (pp == "" && p2 == "" && p3 == "" && p4 == "")
                {
                    errorProvider3.SetError(bunifuTileButton13, "Introduceti cel putin o poza lectiei!");

                }
                else
                {
                    errorProvider3.Clear();
                    test3 = true;
                }




                if (test1 == true && test2 == true && test3 == true)
                {
                    SqlDataAdapter ins = new SqlDataAdapter("insert into Lectii(Titlu,Text,ImagineP,i1,i2,i3,i4)values('" + bunifuTextbox2.text + "','" + richTextBox1.Text + "','" + pp + "','" + pp + "','" + p2 + "','" + p3 + "','" + p4 + "')", Form1.con);
                    DataTable dt3 = new DataTable();
                    ins.Fill(dt3);
                    pp = "";
                    p2 = "";
                    p3 = "";
                    p4 = "";

                    label1.Visible = false;
                    bunifuTextbox2.Visible = false;
                    richTextBox1.Visible = false;
                    bunifuTileButton1.Visible = true;
                    bunifuTileButton2.Visible = true;
                    bunifuTileButton3.Visible = true;
                    bunifuTileButton4.Visible = true;
                    bunifuTileButton5.Visible = true;
                    bunifuTileButton6.Visible = true;
                    bunifuTileButton7.Visible = true;
                    bunifuTileButton8.Visible = true;
                    bunifuTileButton9.Visible = true;
                    bunifuTileButton10.Visible = true;
                    bunifuTileButton13.Visible = false;
                    bunifuTileButton12.Visible = false;
                    bunifuTileButton14.Visible = false;
                    bunifuTileButton16.Visible = false;
                    bunifuTileButton17.Visible = false;
                    this.Hide();
                }
            }
            else
            {
                errorProvider4.SetError(bunifuTileButton12, "Numar maxim de lectii a fost atins, daca doriti sa incarcati alta lectie trebuie sa stergeti una pe care nu o mai folositi!");
            }
            
        }

        private void bunifuTileButton9_Click(object sender, EventArgs e)
        {
            i = 2;
            Form23 lec = new Form23();
            SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lec.pictureBox1.ImageLocation = dt.Rows[i][2].ToString();

            lec.richTextBox1.Text = "                                     " + dt.Rows[i][0].ToString() + "\n" + "     " + dt.Rows[i][1].ToString().Trim(' ');
            lec.bunifuImageButton1.ImageLocation = dt.Rows[i][2].ToString();
            if (dt.Rows[i][4].ToString() != "")
            {

                lec.bunifuImageButton2.ImageLocation = dt.Rows[i][4].ToString();
            }
            else
            {
                lec.bunifuImageButton2.Visible = false;
            }
            if (dt.Rows[i][5].ToString() != "")
            {

                lec.bunifuImageButton3.ImageLocation = dt.Rows[i][5].ToString();
            }
            else
            {
                lec.bunifuImageButton3.Visible = false;
            }

            if (dt.Rows[i][6].ToString() != "")
            {

                lec.bunifuImageButton4.ImageLocation = dt.Rows[i][6].ToString();
            }
            else
            {

                lec.bunifuImageButton4.Visible = false;
            }
            lec.ShowDialog();
        }

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            i = 3;
            Form23 lec = new Form23();
            SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lec.pictureBox1.ImageLocation = dt.Rows[i][2].ToString();

            lec.richTextBox1.Text = "                                     " + dt.Rows[i][0].ToString() + "\n" + "     " + dt.Rows[i][1].ToString().Trim(' ');
            lec.bunifuImageButton1.ImageLocation = dt.Rows[i][2].ToString();
            if (dt.Rows[i][4].ToString() != "")
            {

                lec.bunifuImageButton2.ImageLocation = dt.Rows[i][4].ToString();
            }
            else
            {
                lec.bunifuImageButton2.Visible = false;
            }
            if (dt.Rows[i][5].ToString() != "")
            {

                lec.bunifuImageButton3.ImageLocation = dt.Rows[i][5].ToString();
            }
            else
            {
                lec.bunifuImageButton3.Visible = false;
            }

            if (dt.Rows[i][6].ToString() != "")
            {

                lec.bunifuImageButton4.ImageLocation = dt.Rows[i][6].ToString();
            }
            else
            {

                lec.bunifuImageButton4.Visible = false;
            }
            lec.ShowDialog();
        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            i = 4;
            Form23 lec = new Form23();
            SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lec.pictureBox1.ImageLocation = dt.Rows[i][2].ToString();

            lec.richTextBox1.Text = "                                     " + dt.Rows[i][0].ToString() + "\n" + "     " + dt.Rows[i][1].ToString().Trim(' ');
            lec.bunifuImageButton1.ImageLocation = dt.Rows[i][2].ToString();
            if (dt.Rows[i][4].ToString() != "")
            {

                lec.bunifuImageButton2.ImageLocation = dt.Rows[i][4].ToString();
            }
            else
            {
                lec.bunifuImageButton2.Visible = false;
            }
            if (dt.Rows[i][5].ToString() != "")
            {

                lec.bunifuImageButton3.ImageLocation = dt.Rows[i][5].ToString();
            }
            else
            {
                lec.bunifuImageButton3.Visible = false;
            }

            if (dt.Rows[i][6].ToString() != "")
            {

                lec.bunifuImageButton4.ImageLocation = dt.Rows[i][6].ToString();
            }
            else
            {

                lec.bunifuImageButton4.Visible = false;
            }
            lec.ShowDialog();
        }

        private void bunifuTileButton10_Click(object sender, EventArgs e)
        {
            i = 5;
            Form23 lec = new Form23();
            SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lec.pictureBox1.ImageLocation = dt.Rows[i][2].ToString();

            lec.richTextBox1.Text = "                                     " + dt.Rows[i][0].ToString() + "\n" + "     " + dt.Rows[i][1].ToString().Trim(' ');
            lec.bunifuImageButton1.ImageLocation = dt.Rows[i][2].ToString();
            if (dt.Rows[i][4].ToString() != "")
            {

                lec.bunifuImageButton2.ImageLocation = dt.Rows[i][4].ToString();
            }
            else
            {
                lec.bunifuImageButton2.Visible = false;
            }
            if (dt.Rows[i][5].ToString() != "")
            {

                lec.bunifuImageButton3.ImageLocation = dt.Rows[i][5].ToString();
            }
            else
            {
                lec.bunifuImageButton3.Visible = false;
            }

            if (dt.Rows[i][6].ToString() != "")
            {

                lec.bunifuImageButton4.ImageLocation = dt.Rows[i][6].ToString();
            }
            else
            {

                lec.bunifuImageButton4.Visible = false;
            }
            lec.ShowDialog();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            i = 6;
            Form23 lec = new Form23();
            SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lec.pictureBox1.ImageLocation = dt.Rows[i][2].ToString();

            lec.richTextBox1.Text = "                                     " + dt.Rows[i][0].ToString() + "\n" + "     " + dt.Rows[i][1].ToString().Trim(' ');
            lec.bunifuImageButton1.ImageLocation = dt.Rows[i][2].ToString();
            if (dt.Rows[i][4].ToString() != "")
            {

                lec.bunifuImageButton2.ImageLocation = dt.Rows[i][4].ToString();
            }
            else
            {
                lec.bunifuImageButton2.Visible = false;
            }
            if (dt.Rows[i][5].ToString() != "")
            {

                lec.bunifuImageButton3.ImageLocation = dt.Rows[i][5].ToString();
            }
            else
            {
                lec.bunifuImageButton3.Visible = false;
            }

            if (dt.Rows[i][6].ToString() != "")
            {

                lec.bunifuImageButton4.ImageLocation = dt.Rows[i][6].ToString();
            }
            else
            {

                lec.bunifuImageButton4.Visible = false;
            }
            lec.ShowDialog();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            i = 7;
            Form23 lec = new Form23();
            SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lec.pictureBox1.ImageLocation = dt.Rows[i][2].ToString();

            lec.richTextBox1.Text = "                                     " + dt.Rows[i][0].ToString() + "\n" + "     " + dt.Rows[i][1].ToString().Trim(' ');
            lec.bunifuImageButton1.ImageLocation = dt.Rows[i][2].ToString();
            if (dt.Rows[i][4].ToString() != "")
            {

                lec.bunifuImageButton2.ImageLocation = dt.Rows[i][4].ToString();
            }
            else
            {
                lec.bunifuImageButton2.Visible = false;
            }
            if (dt.Rows[i][5].ToString() != "")
            {

                lec.bunifuImageButton3.ImageLocation = dt.Rows[i][5].ToString();
            }
            else
            {
                lec.bunifuImageButton3.Visible = false;
            }

            if (dt.Rows[i][6].ToString() != "")
            {

                lec.bunifuImageButton4.ImageLocation = dt.Rows[i][6].ToString();
            }
            else
            {

                lec.bunifuImageButton4.Visible = false;
            }
            lec.ShowDialog();
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            i = 8;
            Form23 lec = new Form23();
            SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lec.pictureBox1.ImageLocation = dt.Rows[i][2].ToString();

            lec.richTextBox1.Text = "                                     " + dt.Rows[i][0].ToString() + "\n" + "     " + dt.Rows[i][1].ToString().Trim(' ');
            lec.bunifuImageButton1.ImageLocation = dt.Rows[i][2].ToString();
            if (dt.Rows[i][4].ToString() != "")
            {

                lec.bunifuImageButton2.ImageLocation = dt.Rows[i][4].ToString();
            }
            else
            {
                lec.bunifuImageButton2.Visible = false;
            }
            if (dt.Rows[i][5].ToString() != "")
            {

                lec.bunifuImageButton3.ImageLocation = dt.Rows[i][5].ToString();
            }
            else
            {
                lec.bunifuImageButton3.Visible = false;
            }

            if (dt.Rows[i][6].ToString() != "")
            {

                lec.bunifuImageButton4.ImageLocation = dt.Rows[i][6].ToString();
            }
            else
            {

                lec.bunifuImageButton4.Visible = false;
            }
            lec.ShowDialog();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            i = 9;
            Form23 lec = new Form23();
            SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lec.pictureBox1.ImageLocation = dt.Rows[i][2].ToString();

            lec.richTextBox1.Text = "                                     " + dt.Rows[i][0].ToString() + "\n" + "     " + dt.Rows[i][1].ToString().Trim(' ');
            lec.bunifuImageButton1.ImageLocation = dt.Rows[i][2].ToString();
            if (dt.Rows[i][4].ToString() != "")
            {

                lec.bunifuImageButton2.ImageLocation = dt.Rows[i][4].ToString();
            }
            else
            {
                lec.bunifuImageButton2.Visible = false;
            }
            if (dt.Rows[i][5].ToString() != "")
            {

                lec.bunifuImageButton3.ImageLocation = dt.Rows[i][5].ToString();
            }
            else
            {
                lec.bunifuImageButton3.Visible = false;
            }

            if (dt.Rows[i][6].ToString() != "")
            {

                lec.bunifuImageButton4.ImageLocation = dt.Rows[i][6].ToString();
            }
            else
            {

                lec.bunifuImageButton4.Visible = false;
            }
            lec.ShowDialog();
        }

        private void bunifuTileButton15_Click(object sender, EventArgs e)
        {
            bunifuTileButton13.Visible = false;
            bunifuTileButton12.Visible = false;
            bunifuTileButton14.Visible = false;
            bunifuTileButton16.Visible = false;
            bunifuTileButton17.Visible = false;
       
            bunifuTileButton1.Visible = false;
            bunifuTileButton11.Visible = false;
            bunifuTileButton2.Visible = false;
            bunifuTileButton3.Visible = false;
            bunifuTileButton4.Visible = false;
            bunifuTileButton5.Visible = false;
            bunifuTileButton6.Visible = false;
            bunifuTileButton7.Visible = false;
            bunifuTileButton8.Visible = false;
            bunifuTileButton9.Visible = false;
            bunifuTileButton10.Visible = false;
            bunifuTileButton15.Visible = false;
            comboBox1.Visible = true;
            bunifuThinButton21.Visible = true;
            label3.Visible = true;
            SqlDataAdapter sda = new SqlDataAdapter("select Titlu,Text,ImagineP,i1,i2,i3,i4 from Lectii ", Form1.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int k = 0; k < dt.Rows.Count; k++)
            {
                comboBox1.Items.Add(dt.Rows[k][0].ToString());
            }
        }

        

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                errorProvider5.SetError(comboBox1, "Alegeti o lectie!");
            }
            else
            {
                errorProvider5.Clear();
                SqlDataAdapter del = new SqlDataAdapter("delete from Lectii where Titlu='" + comboBox1.Text + "'", Form1.con);
                DataTable dt2 = new DataTable();
                del.Fill(dt2);
                bunifuTileButton13.Visible = true;
                bunifuTileButton12.Visible = true;
                bunifuTileButton14.Visible = true;
                bunifuTileButton16.Visible = true;
                bunifuTileButton17.Visible = true;
    
                bunifuTileButton1.Visible = true;
                bunifuTileButton11.Visible = true;
                bunifuTileButton2.Visible = true;
                bunifuTileButton3.Visible = true;
                bunifuTileButton4.Visible = true;
                bunifuTileButton5.Visible = true;
                bunifuTileButton6.Visible = true;
                bunifuTileButton7.Visible = true;
                bunifuTileButton8.Visible = true;
                bunifuTileButton9.Visible = true;
                bunifuTileButton10.Visible = true;
                bunifuTileButton15.Visible = true;
               comboBox1.Visible = false;
                bunifuThinButton21.Visible = false;
                label3.Visible = false;
                comboBox1.Items.Clear();
                comboBox1.Text = "";
                this.Hide();
            }
        }
        
    }
}

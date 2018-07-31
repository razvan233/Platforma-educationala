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
    public partial class Form25 : Form
    {
        public static int i = 0, nrtrb, scor = 1, test = 0, k = -1, rc;
        Random ran = new Random();
        int[] v = new int[9];
    
         //int randomNumber = ran.Next(0, 100);
          
        // SqlForm1.connection Form1.con = new SqlForm1.connection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + System.IO.Path.GetFullPath("PROIECTed.mdf") + ";Integrated Security=True;User Instance=True");
        public Form25()
        {
            InitializeComponent();
        }


        private void Form25_Load(object sender, EventArgs e)
        {
            
           
           
            if (test == 0)
            {
                string read = "select Intrebare, r1,r2,r3,r4,rc from test1";
                SqlCommand cmd = new SqlCommand(read, Form1.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                label1.Text = dt.Rows[i][0].ToString();
                radioButton1.Text = dt.Rows[i][1].ToString();
                radioButton2.Text = dt.Rows[i][2].ToString();
                radioButton3.Text = dt.Rows[i][3].ToString();
                radioButton4.Text = dt.Rows[i][4].ToString();
            }
            else
            {
                string read1 = "select Intrebare, r1,r2,r3,r4,rc from test2";
                SqlCommand cmd1 = new SqlCommand(read1, Form1.con);
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                label1.Text = dt1.Rows[i][0].ToString();
                radioButton1.Text = dt1.Rows[i][1].ToString();
                radioButton2.Text = dt1.Rows[i][2].ToString();
                radioButton3.Text = dt1.Rows[i][3].ToString();
                radioButton4.Text = dt1.Rows[i][4].ToString();
            }





        }

        private bool corect(int[] v, int n)
        {
            string s=" ";
            for (int i = 0; i <= n; i++)
            {
                s = s + " ";
                s = s + v[i].ToString();
            }
            

            for (int i = 0; i <= n-1 ; i++)
                for (int j = i + 1; j <= n; j++)
                    if (v[i] == v[j]) return false;

            return true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {   
                string read = "select Intrebare, r1,r2,r3,r4,rc from test1";
                SqlCommand cmd = new SqlCommand(read, Form1.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt); 
                
                nrtrb++;    
                    if (nrtrb < 9)
                    {
                        
                        Random rr = new Random();
                        int ix = rr.Next(0, dt.Rows.Count);
                        k++;
                        v[k] = ix;
                 
                        while (!corect(v, k))
                        {
                            
                            ix = rr.Next(0, dt.Rows.Count);
                            
                            v[k] = ix;
                        }
                            
                      

                       
                        
                        label1.Text = dt.Rows[ix][0].ToString();
                        radioButton1.Text = dt.Rows[ix][1].ToString();
                        radioButton2.Text = dt.Rows[ix][2].ToString();
                        radioButton3.Text = dt.Rows[ix][3].ToString();
                        radioButton4.Text = dt.Rows[ix][4].ToString();
                      //  MessageBox.Show(ix.ToString());
                        if (radioButton1.Checked == true)
                        {
                            rc = 1;
                        }
                        if (radioButton2.Checked == true)
                        {
                            rc = 2;
                        }
                        if (radioButton3.Checked == true)
                        {
                            rc = 3;
                        }
                        if (radioButton4.Checked == true)
                        {
                            rc = 4;
                        }
                        if (ix == 0 && Convert.ToInt32( dt.Rows[i][5])==rc)
                        {
                            scor++;
                        }

                        if (ix == 1 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 2 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 3 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 4 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 5 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 6 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 7 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 8 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 9 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }
                        if (ix == 10 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 11 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 12 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 13 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 14 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 15 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 16 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 17 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 18 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 19 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }
                        if (ix == 20 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 21 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 22 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 23 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 24 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 25 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 26 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 27 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 28 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 29 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }
                        if (ix == 30 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 31 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 32 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 33 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 34 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 35 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 36 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 37 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 38 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }

                        if (ix == 39 && Convert.ToInt32(dt.Rows[i][5]) == rc)
                        {
                            scor++;
                        }
                    }
                    else
                    {
                        bunifuThinButton21.Visible = false;
                   
                        radioButton1.Visible = false;
                        radioButton2.Visible = false;
                        radioButton3.Visible = false;
                        radioButton4.Visible = false;
                        label1.Visible = false;
                       
                        
                        nrtrb = 0;


                        k = -1;
                        if (scor > 5)
                        {
                            MessageBox.Show("Felicitari ai obtinut nota:" + " " + scor);
                            string ins = "update elevi set Test1='" + scor + "'where Nume='" + Form4.a + "'";
                            SqlDataAdapter ssda = new SqlDataAdapter(ins, Form1.con);
                            DataTable sdt = new DataTable();
                            ssda.Fill(sdt);
                        }
                        else
                        {
                            MessageBox.Show("Din pacate ai obtinut nota:" + " " + scor);
                            string ins = "update elevi set Test1='" + scor + "'where Nume='" + Form4.a + "'";
                            SqlDataAdapter ssda = new SqlDataAdapter(ins, Form1.con);
                            DataTable sdt = new DataTable();
                            ssda.Fill(sdt);
                        }



                        this.Hide();
                      
                        bunifuImageButton1.Visible = true;
                        scor = 0;
                }

              
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            


       
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form31 f31 = new Form31();
       
         

            
           
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

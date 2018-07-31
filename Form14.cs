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
    public partial class Form14 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + System.IO.Path.GetFullPath("PROIECTed.mdf") + ";Integrated Security=True;User Instance=True");
        public Form14()
        {
            InitializeComponent();
        }

        private void eleviBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eleviBindingSource.EndEdit();


        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.elevi' table. You can move, or remove it, as needed.
           

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Form31 f31 = new Form31();
            Form1 f1 = new Form1();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from elevi where Nume='" + Form1.a + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {


                f31.testeToolStripMenuItem.Visible = true;
                f31.lectiiToolStripMenuItem.Visible = true;
                f31.logareToolStripMenuItem.Visible = false;

            }
            f31.Show();
                this.Hide();
                                        
                        
        }
        

        private void bunifuTileButton2_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
           SqlDataAdapter sda2 = new SqlDataAdapter("select Lectie from elevi where Nume='" + Form1.a + "'",con);
                DataTable dt = new DataTable();
                sda2.Fill(dt);
                
                if (dt.Rows[0][0].ToString()=="1")
                {
                    
                    label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label5.Text = "";
            label1.Text = "Nume";
            label2.Text = "Testul 1";
            label3.Text = "Testul 2";
            label5.Text = "Media";
           
            
          
            string read = "select Nume, Test1, Test2, Average from elevi";
            SqlCommand cmd = new SqlCommand(read, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "elevi");
            label1.Text += "\n\n";
            label2.Text += "\n\n";
            label3.Text += "\n\n";
            label5.Text += "\n\n";
            foreach (DataRow r in ds.Tables["elevi"].Rows)
            {

                label1.Text += r["Nume"] + "\n";
                label2.Text += r["Test1"] + "\n";
                label3.Text += r["Test2"] + "\n";
                label5.Text += r["Average"] + "\n";
            }
             label1.Visible=true;
            label2.Visible=true;
            label3.Visible = true;
            label5.Visible = true;

            
        

                }
                else
                {
                    MessageBox.Show("Trebuie sa parcurgi una din lectii pentru a vedea TOP-ul!");
                }

}
            
    }
}

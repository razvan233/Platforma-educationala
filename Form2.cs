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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
          
        }

        private void testsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void lesson1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(751, 651);
            richTextBox1.Text = @"                                   Scheletul uman "+"\n"+@"
        Scheletul uman este alcătuit din 206 de oase. Funcțiile scheletului au rolul de a oferi sprijin, de a forma corpul nostru, de a proteja alte sisteme și organe ale corpului, de a oferi atașamente pentru mușchi, de a produce mișcări și de a produce celule roșii. Este alcătuită din aproximativ 270 de oase la naștere.
        Sistemul scheletic include toate oasele și articulațiile din corp. Fiecare os este un organ viu complex compus din multe celule, fibre de proteine ​​și minerale. Scheletul acționează ca o schelă oferind suport și protecție pentru țesuturile moi care alcătuiesc restul corpului. Sistemul scheletic oferă, de asemenea, puncte de atașare a mușchilor pentru a permite deplasarea articulațiilor. Noi celule sanguine sunt produse de măduva osoasă roșie în interiorul oaselor noastre.";
         
            
            pictureBox1.ImageLocation = "sk1.jpg";
            pictureBox2.ImageLocation = "sk2.jpg";
        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            string delete = "delete from elevi where Nume='" + Form1.a + "'";
            SqlCommand cmd = new SqlCommand(delete, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cont sters cu succes!");
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void lesson2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(751, 651);
            richTextBox1.Text = @"                                   Craniu " + "\n" + @"
        Craniul este compus din 22 de oase care sunt topite împreună, cu excepția mandibulei. Aceste douăzeci de oase fuzibile sunt separate la copii pentru a permite craniului și creierului să crească, dar fuzionează pentru a da un plus de putere și protecție ca adult. Mandia rămâne ca un os mobil al maxilarului și formează singura articulație mobilă în craniu cu osul temporal.
Oasele porțiunii superioare a craniului sunt cunoscute sub numele de craniu și protejează creierul de deteriorare. Oasele porțiunii inferioare și anterioare a craniului sunt cunoscute sub denumirea de oase faciale și susțin ochii, nasul și gura.

                              Hioid și Oscioarele urechii " + "\n" + @"
        Hioid este un os mic, în formă de U, care se găsește doar inferior mandibulei. Hioidul este singurul os din corp care nu formează o articulație cu nici un alt os - este un os plutitor. Funcția de hyoid este de a ajuta la menținerea traheei deschise și pentru a forma o legătură osoasă pentru mușchii limbii.
Ciocanul, Nicovala și Scărița - cunoscute colectiv ca Oscioarele urechii - sunt cele mai mici oase din organism. S-au găsit într-o cavitate mică din osul temporal și servesc la transmiterea și amplificarea sunetului de la timpan la urechea internă.
        
                                        Vertebrele " + "\n" + @"
        Douăzeci și șase vertebre formează coloana vertebrală a corpului uman. Ele sunt numite după regiune:
    * Cervical (gât) - 7 vertebre
    * Toracic (piept) - 12 vertebre
    * Lombar (spate inferior) - 5 vertebre
    * Sacrum - 1 vertebra
    * Coccyx (coada cozii) - 1 vertebra
Cu excepția sacrumului singular și a coccisului, fiecare vertebră este numită pentru prima literă a regiunii sale și poziția acesteia de-a lungul axei inferioare superioare. De exemplu, vertebra toracică cea mai superioară se numește T1, iar cea mai inferioară se numește T12.";
            pictureBox1.ImageLocation = "skull.jpg";
            pictureBox2.ImageLocation = "vertebre.jpg";
        }

        private void lesson3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(751, 651);
            richTextBox1.Text = @"            Centura scapulară și Membrele superioare " + "\n" + @"
        Brădarea pectorală conectează oasele membrelor superioare (braț) la scheletul axial și constă din claviculele din stânga și din dreapta și scapulele stângi și drepte.
Humerusul este osul brațului superior. Formează îmbinarea mingii și a soclului umărului cu scapula și formează articulația cotului cu oasele brațului inferior. Raza și ulna sunt cele două oase ale antebrațului. Ulna se află pe partea mediană a antebrațului și formează o articulație articulată cu humerusul la cot. Raza permite antebrațul și mâna să se întoarcă la articulația încheieturii mâinii.
Oasele brațului inferior formează articulația încheieturii mâinii cu carpalii, un grup de opt mici oase care dau o flexibilitate suplimentară pentru încheietura mâinii. Carpalii sunt conectați la cele cinci metacarpale care formează oasele mâinii și se conectează la fiecare dintre degete. Fiecare deget are trei oase cunoscute ca falangi, cu excepția degetului mare, care are doar două falangi.

                  Centura pelviană și membre inferioare " + "\n" + @"
        Formată de oasele de șold din stânga și dreapta, centura pelviană leagă oasele membrelor inferioare (piciorului) de scheletul axial.
Femurul este cel mai mare os din corp și singurul os din regiunea coapsei (femurală). Femurul formează îmbinarea șoldului cu bilă și soclu cu osul șoldului și formează articulația genunchiului cu tibia și patella. Frecvent numit genunchi, patella este specială deoarece este una dintre puținele oase care nu sunt prezente la naștere. Patella se formează la începutul copilăriei pentru a sprijini genunchiul pentru mersul pe jos și târârea.
Tibia și fibula sunt oasele piciorului inferior. Tibia este mult mai mare decât fibula și poartă aproape toată greutatea corpului. Fibula este în principal un punct de atașare a mușchilor și este folosit pentru a ajuta la menținerea echilibrului. Tibia și fibula formează articulația gleznei cu talusul, una dintre cele șapte oase tarsiale din picior.

                                    Structura microscopică a oaselor " + "\n" + @"
        Scheletul reprezintă aproximativ 30-40% din masa corporală a unui adult. Masa scheletului este alcătuită din matrice osoasă neviabilă și multe celule osoase mici. Aproximativ jumătate din masa matricei osoase este apa, în timp ce cealaltă jumătate este proteina de colagen și cristale solide de carbonat de calciu și fosfat de calciu.
Celulele osoase vii se găsesc pe marginea oaselor și în cavitățile mici din interiorul matricei osoase. Deși aceste celule constituie foarte puțin din masa osoasă totală, ele au câteva roluri foarte importante în funcțiile sistemului schelet. Celulele osoase permit oaselor:
    * Creșteți și dezvoltați
    * Fiți reparate după un accident sau uzură zilnică
    * Fii descompus pentru a elibera mineralele stocate ";
            pictureBox1.ImageLocation = "girdle.jpg";
            pictureBox2.ImageLocation = "bones.jpg";
        }

        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5.scor = 10;
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
            richTextBox1.Text = "";
            pictureBox1.ImageLocation = "";
            pictureBox2.ImageLocation = "";
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            this.Hide();
            richTextBox1.Text = "";
            pictureBox1.ImageLocation = "";
            pictureBox2.ImageLocation = "";
        }

        private void test2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3.scor2 = 10;
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
            richTextBox1.Text = "";
            pictureBox1.ImageLocation = "";
            pictureBox2.ImageLocation = "";
        }

        private void test3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4.scor3 = 10;
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
            richTextBox1.Text = "";
            pictureBox1.ImageLocation = "";
            pictureBox2.ImageLocation = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}

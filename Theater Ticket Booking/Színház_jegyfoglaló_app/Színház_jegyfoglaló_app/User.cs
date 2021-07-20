using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Színház_jegyfoglaló_app
{
    public partial class User : Form
    {
        private double foldszintJegy = 4000;
        private double karzatJegy = 6000;
        private double VIPJegy = 12000;
        public double osszeg = 0;
        public double osszeg2 = 0;
        public double osszeg3 = 0;

        public User()
        {
            InitializeComponent();
        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Készítette: Kőrösi Krisztofer Roland\nProgramverzió: v1.0\nKiadás dátuma: 2020.11.20", "Információk");
        }

        private void kijelentkezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();

        }


        private void User_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Tisztelt Nézőink!\nKérjük Önöket arra, hogy a koronavírus járvány (COVID-19) miatt csak úgy válasszanak ülőhelyet hogy két foglalt " +
                "ülőhely között minimum 2 hely távolság legyen.\nEgyüttműködésüket és megértésüket köszönjük!");

            foreach (Control c in this.panel1.Controls)
            {
                if(c is PictureBox)
                {
                    c.Click += this.pictureBox1_Click;
                }
            }

            foreach(Control c in this.panel2.Controls)
            {
                if(c is PictureBox)
                {
                    c.Click += this.pictureBox930_Click;
                }

            }

            foreach(Control c in this.panel3.Controls)
            {
                if(c is PictureBox)
                {
                    c.Click += this.pictureBox189_Click;
                }
            }

            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            label2.Text = "Üdvözlünk!";

            this.updateSQLShakespeare();
            this.updateSQLMoliere();
            this.updateSQLMadach();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox1.Text == "Válasszon az alábbi előadások közül...")
                {
                    throw new Exception("HIBA: NINCSEN ELŐADÁS KIVÁLASZTVA.");
                }

                switch (comboBox1.SelectedItem.ToString())
                {
                    case "William Shakespeare: Rómeó és Júlia":
                        panel1.Show();
                        panel2.Hide();
                        panel3.Hide();
                        break;
                    case "Moliere: Tartuffe":
                        panel2.Show();
                        panel3.Hide();
                        panel1.Hide();
                        break;
                    case "Madách Imre: Az ember tragédiája":
                        panel3.Show();
                        panel2.Hide();
                        panel1.Hide();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kérem válasszon egy előadást.\n\n" + ex.Message, "Exception");
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            if (((PictureBox)sender).BackColor == Color.Gray)
            {
                ((PictureBox)sender).BackColor = Color.Green;
                

            }
            else if (((PictureBox)sender).BackColor == Color.Green)
            {
                ((PictureBox)sender).BackColor = Color.Gray;

            }

            if (((PictureBox)sender).BackColor == Color.Gold)
            {
                ((PictureBox)sender).BackColor = Color.DimGray;
                

            }
            else if (((PictureBox)sender).BackColor == Color.DimGray)
            {
                ((PictureBox)sender).BackColor = Color.Gold;
                
            }

            if (((PictureBox)sender).BackColor == Color.LimeGreen)
            {
                ((PictureBox)sender).BackColor = Color.Silver;
                
            }
            else if (((PictureBox)sender).BackColor == Color.Silver)
            {
                ((PictureBox)sender).BackColor = Color.LimeGreen;
            }

            int fszintdb = 0, karzatdb = 0, VIPdb = 0;
            foreach (var c in this.panel1.Controls)
            {
                if (c is PictureBox)
                {
                    if (((PictureBox)c).BackColor == Color.Gray)
                    {
                        fszintdb = fszintdb + 1;
                    }
                    else if (((PictureBox)c).BackColor == Color.DimGray)
                    {
                        VIPdb = VIPdb + 1;
                    }
                    else if (((PictureBox)c).BackColor == Color.Silver)
                    {
                        karzatdb = karzatdb + 1;
                    }
                }
            }
            double fszintAra = fszintdb * foldszintJegy;
            double karzatAra = karzatdb * karzatJegy;
            double VIPAra = VIPdb * VIPJegy;

            osszeg = fszintAra + karzatAra + VIPAra;

           

            label32.Text = osszeg.ToString() + " Ft";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Jelmagyarázat jm = new Jelmagyarázat();
            jm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "William Shakespeare: Rómeó és Júlia":
                    if (this.textBox1.Text == "KEDVEZMENY5")
                    {
                        textBox1.Text = "";
                        osszeg = osszeg - (osszeg * 0.05);
                        label32.Text = osszeg.ToString() + " Ft";
                    }
                    else if (this.textBox1.Text == "KEDVEZMENY10")
                    {
                        textBox1.Text = "";
                        osszeg = osszeg - (osszeg * 0.1);
                        label32.Text = osszeg.ToString() + " Ft";
                    }
                    break;
                case "Moliere: Tartuffe":
                    if (this.textBox1.Text == "KEDVEZMENY5")
                    {
                        textBox1.Text = "";
                        osszeg2 = osszeg2 - (osszeg2 * 0.05);
                        label32.Text = osszeg2.ToString() + " Ft";
                    }
                    else if (this.textBox1.Text == "KEDVEZMENY10")
                    {
                        textBox1.Text = "";
                        osszeg2 = osszeg2 - (osszeg2 * 0.1);
                        label32.Text = osszeg2.ToString() + " Ft";
                    }
                    break;
                case "Madách Imre: Az ember tragédiája":
                    if (this.textBox1.Text == "KEDVEZMENY5")
                    {
                        textBox1.Text = "";
                        osszeg3 = osszeg3 - (osszeg3 * 0.05);
                        label32.Text = osszeg3.ToString() + " Ft";
                    }
                    else if (this.textBox1.Text == "KEDVEZMENY10")
                    {
                        textBox1.Text = "";
                        osszeg3 = osszeg3 - (osszeg3 * 0.1);
                        label32.Text = osszeg3.ToString() + " Ft";
                    }
                    break;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool value = false;

            if (textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Kérjük a vásárláshoz irja be az Ön felhasználónevét, vezetéknevét és keresztnevét.");
                value = true;
            }

            if(value == false) {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "William Shakespeare: Rómeó és Júlia":
                        bool bSelected = false;

                        foreach (Control cont in this.panel1.Controls)
                        {
                            if (cont is PictureBox)
                            {
                                if (((PictureBox)cont).BackColor == Color.Gray || ((PictureBox)cont).BackColor == Color.DimGray || ((PictureBox)cont).BackColor == Color.Silver)
                                {
                                    bSelected = true;
                                }
                            }
                        }
                        /*WILLIAM SHAKESPEARE: RÓMEÓ ÉS JÚLIA*/

                        DB db = new DB();
                        db.openConnection();

                        string iSeatNum;
                        foreach (Control cont in this.panel1.Controls)
                        {
                            if (cont is PictureBox)
                            {
                                if (((PictureBox)cont).BackColor == Color.Gray || ((PictureBox)cont).BackColor == Color.DimGray || ((PictureBox)cont).BackColor == Color.Silver)
                                {
                                    
                                    iSeatNum = ((PictureBox)cont).Name.ToString().Substring(10);
                                    string sqlInsertName = "INSERT INTO foglalasShakespeare (vnev, knev, osszeg, ulohelySzama) VALUES('"+this.textBox3.Text+"' , '"+this.textBox4.Text+"' , '"+ this.jegyAra(cont) +"', '"+iSeatNum+"')";
                                    SQLiteCommand cmdInsertName = new SQLiteCommand(sqlInsertName, db.getConnection());
                                    cmdInsertName.ExecuteNonQuery();
                                }
                            }
                        }
                        MessageBox.Show("Összesen fizetendő: " + osszeg.ToString() + "Ft\n\nKöszönjük a vásárlást!\nJó szórakozást");
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        db.closeConnection();
                        this.updateSQLShakespeare();
                        break;

                    /*MOLIERE: TARTUFFE*/
                    case "Moliere: Tartuffe":
                        
                        DB db2 = new DB();
                        db2.openConnection();

                        string iSeatNum2;
                        foreach (Control cont in this.panel2.Controls)
                        {
                            if (cont is PictureBox)
                            {
                                if (((PictureBox)cont).BackColor == Color.Gray || ((PictureBox)cont).BackColor == Color.DimGray || ((PictureBox)cont).BackColor == Color.Silver)
                                {
                                    iSeatNum2 = ((PictureBox)cont).Name.ToString().Substring(10, 3);
                                    string sqlInsertName = "INSERT INTO foglalasMoliere (vnev, knev, osszeg, ulohelySzama) VALUES('" + this.textBox3.Text + "' , '" + this.textBox4.Text + "' , '" + this.jegyAra(cont) + "', '" +iSeatNum2+ "')";
                                    SQLiteCommand cmdInsertName = new SQLiteCommand(sqlInsertName, db2.getConnection());;
                                    cmdInsertName.ExecuteNonQuery();
                                }
                            }
                        }
                        MessageBox.Show("Összesen fizetendő: " + osszeg2.ToString() + "Ft\n\nKöszönjük a vásárlást!\nJó szórakozást");
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        db2.closeConnection();
                        this.updateSQLMoliere();
                        break;

                    /*Madách Imre: Az ember tragédiája*/
                    case "Madách Imre: Az ember tragédiája":
                        DB db3 = new DB();
                        db3.openConnection();

                        string iSeatNum3;
                        foreach (Control cont in this.panel3.Controls)
                        {
                            if (cont is PictureBox)
                            {
                                if (((PictureBox)cont).BackColor == Color.Gray || ((PictureBox)cont).BackColor == Color.DimGray || ((PictureBox)cont).BackColor == Color.Silver)
                                {
                                    iSeatNum3 = ((PictureBox)cont).Name.ToString().Substring(10, 3);
                                    string sqlInsertName = "INSERT INTO foglalasMadach (vnev, knev, osszeg, ulohelySzama) VALUES('" + this.textBox3.Text + "' , '" + this.textBox4.Text + "' , '" + this.jegyAra(cont) + "', '"+iSeatNum3+"')";
                                    SQLiteCommand cmdInsertName = new SQLiteCommand(sqlInsertName, db3.getConnection());
                                    cmdInsertName.ExecuteNonQuery();
                                }
                            }
                        }
                        MessageBox.Show("Összesen fizetendő: " + osszeg3.ToString() + "Ft\n\nKöszönjük a vásárlást!\nJó szórakozást");
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        db3.closeConnection();
                        this.updateSQLMadach();
                        break;
                }
            }
        }

        private void updateSQLShakespeare()
        {

            DB db = new DB();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            db.openConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM foglalasShakespeare", db.getConnection());
            SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt);
            db.closeConnection();

            foreach (DataRow row in dt.Rows)
            {
                ((PictureBox)panel1.Controls["pictureBox" + row[3]]).BackColor = Color.Red;
            }
        }

        private void updateSQLMoliere()
        {
            DB db = new DB();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            db.openConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM foglalasMoliere", db.getConnection());
            SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt);
            db.closeConnection();

            foreach (DataRow row in dt.Rows)
            {
                ((PictureBox)panel2.Controls["pictureBox" + row[3]]).BackColor = Color.Red;
            }
        }

        private void updateSQLMadach()
        {
            DB db = new DB();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            db.openConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM foglalasMadach", db.getConnection());
            SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt);
            db.closeConnection();

            foreach (DataRow row in dt.Rows)
            {
                ((PictureBox)panel3.Controls["pictureBox" + row[3]]).BackColor = Color.Red;
            }
        }

        private void pictureBox930_Click(object sender, EventArgs e)
        {
            if (((PictureBox)sender).BackColor == Color.Gray)
            {
                ((PictureBox)sender).BackColor = Color.Green;
            }
            else if (((PictureBox)sender).BackColor == Color.Green)
            {
                ((PictureBox)sender).BackColor = Color.Gray;
            }

            if (((PictureBox)sender).BackColor == Color.Gold)
            {
                ((PictureBox)sender).BackColor = Color.DimGray;
            }
            else if (((PictureBox)sender).BackColor == Color.DimGray)
            {
                ((PictureBox)sender).BackColor = Color.Gold;
            }

            if (((PictureBox)sender).BackColor == Color.LimeGreen)
            {
                ((PictureBox)sender).BackColor = Color.Silver;
            }
            else if (((PictureBox)sender).BackColor == Color.Silver)
            {
                ((PictureBox)sender).BackColor = Color.LimeGreen;
            }

            int fszintdb = 0, karzatdb = 0, VIPdb = 0;
            foreach (var c in this.panel2.Controls)
            {
                if (c is PictureBox)
                {
                    if (((PictureBox)c).BackColor == Color.Gray)
                    {
                        fszintdb = fszintdb + 1;
                    }
                    else if (((PictureBox)c).BackColor == Color.DimGray)
                    {
                        VIPdb = VIPdb + 1;
                    }
                    else if (((PictureBox)c).BackColor == Color.Silver)
                    {
                        karzatdb = karzatdb + 1;
                    }
                }
            }
            double fszintAra = fszintdb * foldszintJegy;
            double karzatAra = karzatdb * karzatJegy;
            double VIPAra = VIPdb * VIPJegy;

            osszeg2 = fszintAra + karzatAra + VIPAra;



            label32.Text = osszeg2.ToString() + " Ft";
        }

        private void pictureBox189_Click(object sender, EventArgs e)
        {
            if (((PictureBox)sender).BackColor == Color.Gray)
            {
                ((PictureBox)sender).BackColor = Color.Green;
            }
            else if (((PictureBox)sender).BackColor == Color.Green)
            {
                ((PictureBox)sender).BackColor = Color.Gray;
            }

            if (((PictureBox)sender).BackColor == Color.Gold)
            {
                ((PictureBox)sender).BackColor = Color.DimGray;
            }
            else if (((PictureBox)sender).BackColor == Color.DimGray)
            {
                ((PictureBox)sender).BackColor = Color.Gold;
            }

            if (((PictureBox)sender).BackColor == Color.LimeGreen)
            {
                ((PictureBox)sender).BackColor = Color.Silver;
            }
            else if (((PictureBox)sender).BackColor == Color.Silver)
            {
                ((PictureBox)sender).BackColor = Color.LimeGreen;
            }

           

            int fszintdb = 0, karzatdb = 0, VIPdb = 0;
            foreach (var c in this.panel3.Controls)
            {
                if (c is PictureBox)
                {
                    if (((PictureBox)c).BackColor == Color.Gray)
                    {
                        fszintdb = fszintdb + 1;
                    }
                    else if (((PictureBox)c).BackColor == Color.DimGray)
                    {
                        VIPdb = VIPdb + 1;
                    }
                    else if (((PictureBox)c).BackColor == Color.Silver)
                    {
                        karzatdb = karzatdb + 1;
                    }
                }
            }
            double fszintAra = fszintdb * foldszintJegy;
            double karzatAra = karzatdb * karzatJegy;
            double VIPAra = VIPdb * VIPJegy;

            osszeg3 = fszintAra + karzatAra + VIPAra;



            label32.Text = osszeg3.ToString() + " Ft";
        }

        private int kijeloltHelyDarabszamaShakespeare()
        {
            int VIPdb = 0, karzatdb = 0, fszintdb = 0;

            foreach(Control c in this.panel1.Controls)
            {
                if(c is PictureBox)
                {
                    if(((PictureBox)c).BackColor == Color.Gray)
                    {
                        fszintdb = fszintdb + 1;
                        return fszintdb;
                    }
                    else if (((PictureBox)c).BackColor == Color.Silver)
                    {
                        karzatdb++;
                        return karzatdb;
                    }
                    else if(((PictureBox)c).BackColor == Color.DimGray)
                    {
                        VIPdb++;
                        return karzatdb;
                    }
                }
            }

            return 0;
        }

        private int kedvezmenyBool()
        {
            if(textBox1.Text == "KEDVEZMENY5" || textBox1.Text == "KEDVEZMENY10")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private double jegyAra(Control c)
        {
            if(((PictureBox)c).BackColor == Color.Gray)
            {
                return foldszintJegy;
            }
            else if(((PictureBox)c).BackColor == Color.Silver)
            {
                return karzatJegy;
            }
            else if(((PictureBox)c).BackColor == Color.DimGray)
            {
                return VIPJegy;
            }
            else if(((PictureBox)c).BackColor == Color.Gray && textBox1.Text == "KEDVEZMENY5")
            {
                return foldszintJegy - (foldszintJegy * 0.05);
            }
            else if((((PictureBox)c).BackColor == Color.Gray && textBox1.Text == "KEDVEZMENY10"))
            {
                return foldszintJegy - (foldszintJegy * 0.1);
            }
            else if (((PictureBox)c).BackColor == Color.DimGray && textBox1.Text == "KEDVEZMENY5")
            {
                return VIPJegy - (VIPJegy * 0.05);
            }
            else if ((((PictureBox)c).BackColor == Color.DimGray && textBox1.Text == "KEDVEZMENY10"))
            {
                return VIPJegy - (VIPJegy * 0.1);
            }
            else if (((PictureBox)c).BackColor == Color.Silver && textBox1.Text == "KEDVEZMENY5")
            {
                return karzatJegy - (karzatJegy * 0.05);
            }
            else if ((((PictureBox)c).BackColor == Color.Silver && textBox1.Text == "KEDVEZMENY10"))
            {
                return karzatJegy - (karzatJegy * 0.1);
            }
            else
            {
                return 0;
            }
            
        }
    }
}